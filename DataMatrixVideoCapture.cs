using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.Internal.Vectors;
using ZXing;
using ZXing.Common;
using ZXing.Datamatrix;
using Point = OpenCvSharp.Point;

namespace DataMatrixCV
{
    public partial class DataMatrixVideoCapture : Form
    {
        // variables for video capture
        private VideoCapture capture;
        private Mat frame;
        private Bitmap image;
        private Thread camera;
        private bool isCameraRunning = false;
        private BarcodeReader BReader = new BarcodeReader();
        private DataMatrixReader DReader = new DataMatrixReader();
        private Rectangle rectangle;
        private string coord;
        private string label;
        private ImageConverter converter = new ImageConverter();
        private HashSet<string> scanned = new HashSet<string>();
        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }
        private void CaptureCameraCallback()
        {
            frame = new Mat();
            capture = new VideoCapture(0);
            capture.AutoFocus = false;
            capture.Open(1);
            capture.Exposure = -4;
            capture.Contrast = 0;
            capture.Brightness = 256;
            capture.Focus = 100;
            BReader.AutoRotate = true;
            BReader.Options.PossibleFormats = new BarcodeFormat[] { BarcodeFormat.DATA_MATRIX };

            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {
                    capture.Read(frame);
                    
                    Bitmap operableImage = BitmapConverter.ToBitmap(frame);
                    var result = BReader.Decode(operableImage);
                    if (result != null)
                    {
                        coord = $"({result.ResultPoints[1].X}, {result.ResultPoints[1].Y})"; 
                        Point[] points = Array.ConvertAll(result.ResultPoints, point => new Point(point.X, point.Y));
                        label = result.Text;
                        Cv2.Polylines(frame, new Point[][] {points}, true, Scalar.LimeGreen,  2);
                        scanned.Add(result.Text);
                        this.Invoke((MethodInvoker)delegate
                        {
                            labelNumScanned.Text = scanned.Count.ToString();
                        });
                    }

                    image = BitmapConverter.ToBitmap(frame);
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }
                    pictureBox1.Image = image;
                }
            }
        }
        public DataMatrixVideoCapture()
        {
            InitializeComponent();
            CaptureCamera();
            buttonStart.Text = "End capture";
            isCameraRunning = true;
            buttonImage.Enabled = true;
            buttonAdvanced.Enabled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text == "End capture")
            {
                isCameraRunning = false;
                capture.Release();
                buttonStart.Text = "Begin capture";
                labelRectangleCoordinates.Text = "";
                labelDMData.Text = "";
                SaveScansToFile();
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            else
            {
                CaptureCamera();
                buttonStart.Text = "End capture";
                isCameraRunning = true;
                scanned = new HashSet<string>();
                labelNumScanned.Text = scanned.Count.ToString();
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            labelRectangleCoordinates.Text = coord;
            labelDMData.Text = label;
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            isCameraRunning = false;
            try
            {
                capture.Release();
                camera.Abort();
            }
            catch (Exception ex)
            {
            }
        }
        protected static byte[] ImageToByte(Bitmap img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                return stream.ToArray();
            }
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            isCameraRunning = false;
            capture.Release();
            StaticImage staticImageDialog = new StaticImage();
            staticImageDialog.Show();
        }

        private void buttonAdvanced_Click(object sender, EventArgs e)
        {
            if (panelAdvanced.Visible)
            {
                panelAdvanced.Visible = false;
                this.Height = 498;
            }
            else
            {
                this.Height =710;
                panelAdvanced.Visible = true;
                if (capture != null)
                {
                    trackBarExposure.Value = (int)capture.Exposure;
                    labelExposureNum.Text = trackBarExposure.Value.ToString();
                    trackBarContrast.Value = (int)capture.Contrast;
                    labelContrastNum.Text = trackBarContrast.Value.ToString();
                    trackBarBrightness.Value = (int)capture.Brightness;
                    labelBrightnessNum.Text = trackBarBrightness.Value.ToString();
                    trackBarFocus.Value = (int)capture.Focus;
                    labelFocusNum.Text = trackBarFocus.Value.ToString();
                }
            }
        }

        private void SaveScansToFile()
        {
            if (scanned.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = $"{DateTime.Now.ToString("MM_dd_yyyy-hh.mm.ss")} PCBA SN Auto Scan Complete.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = 1;
                            string columnNames = "Serial Numbers";
                            string[] outputCsv = new string[scanned.Count + 1];
                            outputCsv[0] += columnNames;
                            int i = 1;

                            foreach (string sn in scanned)
                            {
                                outputCsv[i] = sn;
                                i++;
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show($"Data exported successfully to {sfd.FileName}", "Export complete.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void trackBarExposure_Scroll(object sender, EventArgs e)
        {
            capture.Exposure = trackBarExposure.Value;
            labelExposureNum.Text = trackBarExposure.Value.ToString();
        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            capture.Contrast = trackBarContrast.Value;
            labelContrastNum.Text = trackBarContrast.Value.ToString();
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            capture.Brightness = trackBarBrightness.Value;
            labelBrightnessNum.Text = trackBarBrightness.Value.ToString();
        }
        private void trackBarFocus_Scroll(object sender, EventArgs e)
        {
            capture.Focus = trackBarFocus.Value;
            labelFocusNum.Text = trackBarFocus.Value.ToString();
        }

        private void labelExposure_DoubleClick(object sender, EventArgs e)
        {
            trackBarExposure.Value = -4; 
            capture.Exposure = trackBarExposure.Value;
            labelExposureNum.Text = trackBarExposure.Value.ToString();
        }

        private void labelContrast_DoubleClick(object sender, EventArgs e)
        {
            trackBarContrast.Value = 128;
            capture.Contrast = trackBarContrast.Value;
            labelContrastNum.Text = trackBarContrast.Value.ToString();
        }

        private void labelBrightness_DoubleClick(object sender, EventArgs e)
        {
            trackBarBrightness.Value = 128;
            capture.Brightness = trackBarBrightness.Value;
            labelBrightnessNum.Text = trackBarBrightness.Value.ToString();
        }
        private void labelFocus_DoubleClick(object sender, EventArgs e)
        {
            trackBarFocus.Value = 128;
            capture.Focus = trackBarFocus.Value;
            labelFocusNum.Text = trackBarFocus.Value.ToString();
        }

    }
}
