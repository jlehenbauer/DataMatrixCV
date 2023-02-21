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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.labelRectangleCoordinates.Location = new System.Drawing.Point(43, 409);
            this.labelRectangleCoordinates.Name = "labelRectangleCoordinates";
            this.labelRectangleCoordinates.Size = new System.Drawing.Size(31, 13);
            this.labelRectangleCoordinates.TabIndex = 2;
            this.labelRectangleCoordinates.Text = "(0, 0)";
            // 
            // labelDMData
            // 
            this.labelDMData.AutoSize = true;
            this.labelDMData.Location = new System.Drawing.Point(520, 409);
            this.labelDMData.Name = "labelDMData";
            this.labelDMData.Size = new System.Drawing.Size(33, 13);
            this.labelDMData.TabIndex = 3;
            this.labelDMData.Text = "None";
            // 
            // buttonImage
            // 
            this.buttonImage.Location = new System.Drawing.Point(664, 414);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(32, 24);
            this.buttonImage.TabIndex = 4;
            this.buttonImage.Text = "img";
            this.buttonImage.UseVisualStyleBackColor = true;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.buttonImage);
            this.Controls.Add(this.labelDMData);
            this.Controls.Add(this.labelRectangleCoordinates);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Data Matrix Capture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelRectangleCoordinates;
        private System.Windows.Forms.Label labelDMData;
        private System.Windows.Forms.Button buttonImage;
    }
}

