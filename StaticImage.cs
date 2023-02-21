using OpenCvSharp.Extensions;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using Point = OpenCvSharp.Point;
using Size = OpenCvSharp.Size;

namespace DataMatrixCV
{
    public partial class StaticImage : Form
    {
        public StaticImage()
        {
            InitializeComponent();
        }

        private void buttonImageSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); 
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            labelShowResultPoints.Text = "";
            labelClickPoint.Text = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the image
                Mat image = Cv2.ImRead(openFileDialog.FileName, ImreadModes.Color);

                // Resize the image
                if (image.Width > 1000 || image.Height > 1000)
                {
                    Size size = new Size(image.Width / 10, image.Height / 10);
                    Mat resized = new Mat();
                    Cv2.Resize(image, resized, size);
                    image = resized;
                }


                // Convert the image to grayscale
                Mat gray = new Mat();
                Cv2.CvtColor(image, gray, ColorConversionCodes.BGR2GRAY);

                // Create a DataMatrix detector
                BarcodeReader reader = new BarcodeReader();
                reader.AutoRotate = true;
                reader.Options.PossibleFormats = new BarcodeFormat[] { BarcodeFormat.DATA_MATRIX };


                // Detect the DataMatrix in the image
                Result result = reader.Decode(gray.ToBitmap());


                if (result != null)
                {
                    // Draw a rectangle around the DataMatrix
                    Point[] points = Array.ConvertAll(result.ResultPoints, point => new Point(point.X, point.Y));
                    Cv2.Polylines(image, new Point[][] { points }, true, Scalar.LimeGreen, 2);

                    // Write the image to the picturebox and to a file
                    image.SaveImage("C://Users/jlehenbauer/Desktop/datamatrixtestimage.bmp");
                    // Display the result
                    pictureBox1.Image = BitmapConverter.ToBitmap(image);
                    MessageBox.Show("DataMatrix detected: " + result.Text + Environment.NewLine);

                    foreach (var point in points)
                    {
                        labelShowResultPoints.Text += $"({point.X}, {point.Y})" + Environment.NewLine;
                    }
                }
                else
                {
                    pictureBox1.Image = BitmapConverter.ToBitmap(gray);
                    MessageBox.Show("DataMatrix not detected.");
                }
            }
        }

        private void ResizeWindow(Mat resized)
        {
            this.Width = resized.Width + 100;
            this.Height = resized.Height + 80;
            buttonImageSelect.Location = new System.Drawing.Point((this.Width - buttonImageSelect.Width) / 2, this.Height - 80);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            labelClickPoint.Text = $"({MousePosition.X - pictureBox1.Location.X}, {MousePosition.Y - pictureBox1.Location.Y})";
        }
    }
}

