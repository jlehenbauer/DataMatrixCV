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
using ZXing;
using ZXing.Common;
using ZXing.Datamatrix;

namespace DataMatrixCV
{
    public partial class Form1 : Form
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
        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {
            frame = new Mat();
            capture = new VideoCapture(0);
            capture.AutoFocus = true;
            capture.Open(0);

            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {
                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }

                    pictureBox1.Image = image;
                    //byte[] intArray = ImageToByte(image);
                    //LuminanceSource lumSource = new RGBLuminanceSource(intArray, image.Width, image.Height);
                    //BinaryBitmap operableImage = new BinaryBitmap(new HybridBinarizer(lumSource));
                    //var result = DReader.decode(operableImage);

                    Bitmap operableImage = (Bitmap)image.Clone();
                    var result = BReader.Decode(operableImage);
                    if (result != null)
                    {
                        coord = $"({result.ResultPoints[1].X}, {result.ResultPoints[1].Y})";
                        label = result.Text;
                        try
                        {
                            rectangle = new System.Drawing.Rectangle(
                                (int) result.ResultPoints[1].X, 
                                pictureBox1.Image.Height - (int) result.ResultPoints[1].Y,
                                (int) (result.ResultPoints[2].X - result.ResultPoints[0].X),
                                (int) (result.ResultPoints[2].Y - result.ResultPoints[0].Y));
                        }
                        catch { }
                        //MessageBox.Show($"Data matrix found: {result}", "Decoded data matrix");
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            CaptureCamera();
            buttonStart.Text = "End capture";
            isCameraRunning = true;
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
            }
            else
            {
                CaptureCamera();
                buttonStart.Text = "End capture";
                isCameraRunning = true;
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.LimeGreen, 2))
            {
                e.Graphics.DrawRectangle(pen, rectangle);
            }
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
    }
}
