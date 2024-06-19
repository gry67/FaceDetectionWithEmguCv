namespace FaceApp
{
    partial class FaceDetectionApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pctrBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pctrBox1).BeginInit();
            SuspendLayout();
            // 
            // pctrBox1
            // 
            pctrBox1.BorderStyle = BorderStyle.FixedSingle;
            pctrBox1.Location = new Point(54, 53);
            pctrBox1.Name = "pctrBox1";
            pctrBox1.Size = new Size(640, 480);
            pctrBox1.TabIndex = 0;
            pctrBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FaceDetectionApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(786, 604);
            Controls.Add(pctrBox1);
            Name = "FaceDetectionApp";
            Text = "FaceDetectionApp";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pctrBox1).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private PictureBox pctrBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
