namespace DataMatrixCV
{
    partial class StaticImage
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
            this.buttonImageSelect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelImagePoints = new System.Windows.Forms.Label();
            this.labelResultPoints = new System.Windows.Forms.Label();
            this.labelClickPoint = new System.Windows.Forms.Label();
            this.labelShowResultPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonImageSelect
            // 
            this.buttonImageSelect.Location = new System.Drawing.Point(344, 390);
            this.buttonImageSelect.Name = "buttonImageSelect";
            this.buttonImageSelect.Size = new System.Drawing.Size(123, 37);
            this.buttonImageSelect.TabIndex = 0;
            this.buttonImageSelect.Text = "Select Image";
            this.buttonImageSelect.UseVisualStyleBackColor = true;
            this.buttonImageSelect.Click += new System.EventHandler(this.buttonImageSelect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 348);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelImagePoints
            // 
            this.labelImagePoints.AutoSize = true;
            this.labelImagePoints.Location = new System.Drawing.Point(834, 57);
            this.labelImagePoints.Name = "labelImagePoints";
            this.labelImagePoints.Size = new System.Drawing.Size(66, 13);
            this.labelImagePoints.TabIndex = 2;
            this.labelImagePoints.Text = "Image Point:";
            // 
            // labelResultPoints
            // 
            this.labelResultPoints.AutoSize = true;
            this.labelResultPoints.Location = new System.Drawing.Point(834, 189);
            this.labelResultPoints.Name = "labelResultPoints";
            this.labelResultPoints.Size = new System.Drawing.Size(72, 13);
            this.labelResultPoints.TabIndex = 3;
            this.labelResultPoints.Text = "Result Points:";
            // 
            // labelClickPoint
            // 
            this.labelClickPoint.AutoSize = true;
            this.labelClickPoint.Location = new System.Drawing.Point(906, 57);
            this.labelClickPoint.Name = "labelClickPoint";
            this.labelClickPoint.Size = new System.Drawing.Size(35, 13);
            this.labelClickPoint.TabIndex = 4;
            this.labelClickPoint.Text = "label3";
            // 
            // labelShowResultPoints
            // 
            this.labelShowResultPoints.AutoSize = true;
            this.labelShowResultPoints.Location = new System.Drawing.Point(912, 189);
            this.labelShowResultPoints.Name = "labelShowResultPoints";
            this.labelShowResultPoints.Size = new System.Drawing.Size(35, 13);
            this.labelShowResultPoints.TabIndex = 5;
            this.labelShowResultPoints.Text = "label4";
            // 
            // StaticImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 450);
            this.Controls.Add(this.labelShowResultPoints);
            this.Controls.Add(this.labelClickPoint);
            this.Controls.Add(this.labelResultPoints);
            this.Controls.Add(this.labelImagePoints);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonImageSelect);
            this.Name = "StaticImage";
            this.Text = "StaticImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonImageSelect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelImagePoints;
        private System.Windows.Forms.Label labelResultPoints;
        private System.Windows.Forms.Label labelClickPoint;
        private System.Windows.Forms.Label labelShowResultPoints;
    }
}