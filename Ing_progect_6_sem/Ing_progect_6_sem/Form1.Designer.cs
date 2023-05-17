namespace Ing_progect_6_sem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Main_picture = new System.Windows.Forms.PictureBox();
            this.Open_but = new System.Windows.Forms.Button();
            this.Start_cam_but = new System.Windows.Forms.Button();
            this.Restart_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Main_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "MP4|*.mp4|PNG|*.png|JPG|*.jpg|BMP|*.bmp|AVI|*.avi";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main_picture
            // 
            this.Main_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_picture.Location = new System.Drawing.Point(12, 12);
            this.Main_picture.Name = "Main_picture";
            this.Main_picture.Size = new System.Drawing.Size(1280, 960);
            this.Main_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Main_picture.TabIndex = 0;
            this.Main_picture.TabStop = false;
            // 
            // Open_but
            // 
            this.Open_but.BackColor = System.Drawing.Color.White;
            this.Open_but.Location = new System.Drawing.Point(1320, 12);
            this.Open_but.Name = "Open_but";
            this.Open_but.Size = new System.Drawing.Size(120, 80);
            this.Open_but.TabIndex = 1;
            this.Open_but.Text = "Open video";
            this.Open_but.UseVisualStyleBackColor = false;
            this.Open_but.Click += new System.EventHandler(this.Open_but_Click);
            // 
            // Start_cam_but
            // 
            this.Start_cam_but.BackColor = System.Drawing.Color.White;
            this.Start_cam_but.Location = new System.Drawing.Point(1320, 107);
            this.Start_cam_but.Name = "Start_cam_but";
            this.Start_cam_but.Size = new System.Drawing.Size(120, 80);
            this.Start_cam_but.TabIndex = 2;
            this.Start_cam_but.Text = "Start read camera";
            this.Start_cam_but.UseVisualStyleBackColor = false;
            this.Start_cam_but.Click += new System.EventHandler(this.Start_cam_but_Click);
            // 
            // Restart_but
            // 
            this.Restart_but.BackColor = System.Drawing.Color.White;
            this.Restart_but.Location = new System.Drawing.Point(1320, 207);
            this.Restart_but.Name = "Restart_but";
            this.Restart_but.Size = new System.Drawing.Size(120, 80);
            this.Restart_but.TabIndex = 3;
            this.Restart_but.Text = "Refresh";
            this.Restart_but.UseVisualStyleBackColor = false;
            this.Restart_but.Click += new System.EventHandler(this.Restart_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1654, 992);
            this.Controls.Add(this.Restart_but);
            this.Controls.Add(this.Start_cam_but);
            this.Controls.Add(this.Open_but);
            this.Controls.Add(this.Main_picture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Main_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox Main_picture;
        private System.Windows.Forms.Button Open_but;
        private System.Windows.Forms.Button Start_cam_but;
        private System.Windows.Forms.Button Restart_but;
    }
}

