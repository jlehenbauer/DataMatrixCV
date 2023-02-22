namespace DataMatrixCV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelRectangleCoordinates = new System.Windows.Forms.Label();
            this.labelDMData = new System.Windows.Forms.Label();
            this.buttonImage = new System.Windows.Forms.Button();
            this.buttonAdvanced = new System.Windows.Forms.Button();
            this.trackBarExposure = new System.Windows.Forms.TrackBar();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.labelExposure = new System.Windows.Forms.Label();
            this.labelContrast = new System.Windows.Forms.Label();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.panelAdvanced = new System.Windows.Forms.Panel();
            this.labelFocusNum = new System.Windows.Forms.Label();
            this.labelFocus = new System.Windows.Forms.Label();
            this.trackBarFocus = new System.Windows.Forms.TrackBar();
            this.labelBrightnessNum = new System.Windows.Forms.Label();
            this.labelContrastNum = new System.Windows.Forms.Label();
            this.labelExposureNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExposure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.panelAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFocus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 376);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(265, 394);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(161, 44);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Begin Capture";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelRectangleCoordinates
            // 
            this.labelRectangleCoordinates.AutoSize = true;
            this.labelRectangleCoordinates.Location = new System.Drawing.Point(41, 420);
            this.labelRectangleCoordinates.Name = "labelRectangleCoordinates";
            this.labelRectangleCoordinates.Size = new System.Drawing.Size(31, 13);
            this.labelRectangleCoordinates.TabIndex = 2;
            this.labelRectangleCoordinates.Text = "(0, 0)";
            // 
            // labelDMData
            // 
            this.labelDMData.AutoSize = true;
            this.labelDMData.Location = new System.Drawing.Point(41, 402);
            this.labelDMData.Name = "labelDMData";
            this.labelDMData.Size = new System.Drawing.Size(33, 13);
            this.labelDMData.TabIndex = 3;
            this.labelDMData.Text = "None";
            // 
            // buttonImage
            // 
            this.buttonImage.Enabled = false;
            this.buttonImage.Location = new System.Drawing.Point(657, 394);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(39, 24);
            this.buttonImage.TabIndex = 4;
            this.buttonImage.Text = "img";
            this.buttonImage.UseVisualStyleBackColor = true;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // buttonAdvanced
            // 
            this.buttonAdvanced.Enabled = false;
            this.buttonAdvanced.Location = new System.Drawing.Point(657, 424);
            this.buttonAdvanced.Name = "buttonAdvanced";
            this.buttonAdvanced.Size = new System.Drawing.Size(39, 24);
            this.buttonAdvanced.TabIndex = 5;
            this.buttonAdvanced.Text = "adv";
            this.buttonAdvanced.UseVisualStyleBackColor = true;
            this.buttonAdvanced.Click += new System.EventHandler(this.buttonAdvanced_Click);
            // 
            // trackBarExposure
            // 
            this.trackBarExposure.Location = new System.Drawing.Point(205, 13);
            this.trackBarExposure.Maximum = 0;
            this.trackBarExposure.Minimum = -10;
            this.trackBarExposure.Name = "trackBarExposure";
            this.trackBarExposure.Size = new System.Drawing.Size(402, 45);
            this.trackBarExposure.TabIndex = 6;
            this.trackBarExposure.TickFrequency = 10;
            this.trackBarExposure.Value = -3;
            this.trackBarExposure.Scroll += new System.EventHandler(this.trackBarExposure_Scroll);
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Location = new System.Drawing.Point(205, 64);
            this.trackBarContrast.Maximum = 256;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(402, 45);
            this.trackBarContrast.TabIndex = 7;
            this.trackBarContrast.TickFrequency = 10;
            this.trackBarContrast.Value = 128;
            this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(205, 115);
            this.trackBarBrightness.Maximum = 256;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(402, 45);
            this.trackBarBrightness.TabIndex = 8;
            this.trackBarBrightness.TickFrequency = 10;
            this.trackBarBrightness.Value = 128;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            // 
            // labelExposure
            // 
            this.labelExposure.AutoSize = true;
            this.labelExposure.Location = new System.Drawing.Point(139, 15);
            this.labelExposure.Name = "labelExposure";
            this.labelExposure.Size = new System.Drawing.Size(51, 13);
            this.labelExposure.TabIndex = 9;
            this.labelExposure.Text = "Exposure";
            this.labelExposure.DoubleClick += new System.EventHandler(this.labelExposure_DoubleClick);
            // 
            // labelContrast
            // 
            this.labelContrast.AutoSize = true;
            this.labelContrast.Location = new System.Drawing.Point(139, 67);
            this.labelContrast.Name = "labelContrast";
            this.labelContrast.Size = new System.Drawing.Size(46, 13);
            this.labelContrast.TabIndex = 10;
            this.labelContrast.Text = "Contrast";
            this.labelContrast.DoubleClick += new System.EventHandler(this.labelContrast_DoubleClick);
            // 
            // labelBrightness
            // 
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Location = new System.Drawing.Point(139, 119);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(56, 13);
            this.labelBrightness.TabIndex = 11;
            this.labelBrightness.Text = "Brightness";
            this.labelBrightness.DoubleClick += new System.EventHandler(this.labelBrightness_DoubleClick);
            // 
            // panelAdvanced
            // 
            this.panelAdvanced.Controls.Add(this.labelFocusNum);
            this.panelAdvanced.Controls.Add(this.labelFocus);
            this.panelAdvanced.Controls.Add(this.trackBarFocus);
            this.panelAdvanced.Controls.Add(this.labelBrightnessNum);
            this.panelAdvanced.Controls.Add(this.labelContrastNum);
            this.panelAdvanced.Controls.Add(this.labelExposureNum);
            this.panelAdvanced.Controls.Add(this.labelBrightness);
            this.panelAdvanced.Controls.Add(this.labelContrast);
            this.panelAdvanced.Controls.Add(this.labelExposure);
            this.panelAdvanced.Controls.Add(this.trackBarBrightness);
            this.panelAdvanced.Controls.Add(this.trackBarContrast);
            this.panelAdvanced.Controls.Add(this.trackBarExposure);
            this.panelAdvanced.Location = new System.Drawing.Point(11, 454);
            this.panelAdvanced.Name = "panelAdvanced";
            this.panelAdvanced.Size = new System.Drawing.Size(684, 235);
            this.panelAdvanced.TabIndex = 12;
            this.panelAdvanced.Visible = false;
            // 
            // labelFocusNum
            // 
            this.labelFocusNum.AutoSize = true;
            this.labelFocusNum.Location = new System.Drawing.Point(614, 170);
            this.labelFocusNum.Name = "labelFocusNum";
            this.labelFocusNum.Size = new System.Drawing.Size(35, 13);
            this.labelFocusNum.TabIndex = 17;
            this.labelFocusNum.Text = "label1";
            // 
            // labelFocus
            // 
            this.labelFocus.AutoSize = true;
            this.labelFocus.Location = new System.Drawing.Point(139, 170);
            this.labelFocus.Name = "labelFocus";
            this.labelFocus.Size = new System.Drawing.Size(36, 13);
            this.labelFocus.TabIndex = 16;
            this.labelFocus.Text = "Focus";
            // 
            // trackBarFocus
            // 
            this.trackBarFocus.Location = new System.Drawing.Point(205, 166);
            this.trackBarFocus.Maximum = 100;
            this.trackBarFocus.Name = "trackBarFocus";
            this.trackBarFocus.Size = new System.Drawing.Size(402, 45);
            this.trackBarFocus.TabIndex = 15;
            this.trackBarFocus.TickFrequency = 10;
            this.trackBarFocus.Value = 100;
            this.trackBarFocus.Scroll += new System.EventHandler(this.trackBarFocus_Scroll);
            // 
            // labelBrightnessNum
            // 
            this.labelBrightnessNum.AutoSize = true;
            this.labelBrightnessNum.Location = new System.Drawing.Point(614, 119);
            this.labelBrightnessNum.Name = "labelBrightnessNum";
            this.labelBrightnessNum.Size = new System.Drawing.Size(35, 13);
            this.labelBrightnessNum.TabIndex = 14;
            this.labelBrightnessNum.Text = "label1";
            // 
            // labelContrastNum
            // 
            this.labelContrastNum.AutoSize = true;
            this.labelContrastNum.Location = new System.Drawing.Point(614, 67);
            this.labelContrastNum.Name = "labelContrastNum";
            this.labelContrastNum.Size = new System.Drawing.Size(35, 13);
            this.labelContrastNum.TabIndex = 13;
            this.labelContrastNum.Text = "label1";
            // 
            // labelExposureNum
            // 
            this.labelExposureNum.AutoSize = true;
            this.labelExposureNum.Location = new System.Drawing.Point(614, 15);
            this.labelExposureNum.Name = "labelExposureNum";
            this.labelExposureNum.Size = new System.Drawing.Size(35, 13);
            this.labelExposureNum.TabIndex = 12;
            this.labelExposureNum.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 456);
            this.Controls.Add(this.panelAdvanced);
            this.Controls.Add(this.buttonAdvanced);
            this.Controls.Add(this.buttonImage);
            this.Controls.Add(this.labelDMData);
            this.Controls.Add(this.labelRectangleCoordinates);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Data Matrix Capture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExposure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.panelAdvanced.ResumeLayout(false);
            this.panelAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFocus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelRectangleCoordinates;
        private System.Windows.Forms.Label labelDMData;
        private System.Windows.Forms.Button buttonImage;
        private System.Windows.Forms.Button buttonAdvanced;
        private System.Windows.Forms.TrackBar trackBarExposure;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Label labelExposure;
        private System.Windows.Forms.Label labelContrast;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.Panel panelAdvanced;
        private System.Windows.Forms.Label labelBrightnessNum;
        private System.Windows.Forms.Label labelContrastNum;
        private System.Windows.Forms.Label labelExposureNum;
        private System.Windows.Forms.Label labelFocusNum;
        private System.Windows.Forms.Label labelFocus;
        private System.Windows.Forms.TrackBar trackBarFocus;
    }
}

