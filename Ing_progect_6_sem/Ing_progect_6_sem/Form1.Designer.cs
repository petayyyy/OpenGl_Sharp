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
            this.Main_picture = new System.Windows.Forms.PictureBox();
            this.Open_but = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Start_cam_but = new System.Windows.Forms.Button();
            this.Restart_but = new System.Windows.Forms.Button();
            this.debug_1 = new System.Windows.Forms.TextBox();
            this.debug_2 = new System.Windows.Forms.TextBox();
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.step_flight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.takeoff = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.altitude = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Main_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.step_flight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_picture
            // 
            this.Main_picture.BackColor = System.Drawing.Color.White;
            this.Main_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_picture.Location = new System.Drawing.Point(1616, 12);
            this.Main_picture.Name = "Main_picture";
            this.Main_picture.Size = new System.Drawing.Size(640, 480);
            this.Main_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Main_picture.TabIndex = 0;
            this.Main_picture.TabStop = false;
            // 
            // Open_but
            // 
            this.Open_but.BackColor = System.Drawing.Color.White;
            this.Open_but.Location = new System.Drawing.Point(1413, 69);
            this.Open_but.Name = "Open_but";
            this.Open_but.Size = new System.Drawing.Size(131, 92);
            this.Open_but.TabIndex = 1;
            this.Open_but.Text = "Open video";
            this.Open_but.UseVisualStyleBackColor = false;
            this.Open_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Start_cam_but
            // 
            this.Start_cam_but.BackColor = System.Drawing.Color.White;
            this.Start_cam_but.Location = new System.Drawing.Point(1413, 220);
            this.Start_cam_but.Name = "Start_cam_but";
            this.Start_cam_but.Size = new System.Drawing.Size(131, 92);
            this.Start_cam_but.TabIndex = 2;
            this.Start_cam_but.Text = "Start read camera";
            this.Start_cam_but.UseVisualStyleBackColor = false;
            this.Start_cam_but.Click += new System.EventHandler(this.Start_cam_but_Click);
            // 
            // Restart_but
            // 
            this.Restart_but.BackColor = System.Drawing.Color.White;
            this.Restart_but.Location = new System.Drawing.Point(1413, 368);
            this.Restart_but.Name = "Restart_but";
            this.Restart_but.Size = new System.Drawing.Size(131, 92);
            this.Restart_but.TabIndex = 3;
            this.Restart_but.Text = "Refresh";
            this.Restart_but.UseVisualStyleBackColor = false;
            this.Restart_but.Click += new System.EventHandler(this.Restart_but_Click);
            // 
            // debug_1
            // 
            this.debug_1.Location = new System.Drawing.Point(12, 7);
            this.debug_1.Name = "debug_1";
            this.debug_1.Size = new System.Drawing.Size(1400, 22);
            this.debug_1.TabIndex = 4;
            // 
            // debug_2
            // 
            this.debug_2.Location = new System.Drawing.Point(12, 35);
            this.debug_2.Name = "debug_2";
            this.debug_2.Size = new System.Drawing.Size(1400, 22);
            this.debug_2.TabIndex = 5;
            // 
            // openGLControl1
            // 
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.Location = new System.Drawing.Point(776, 62);
            this.openGLControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.FBO;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(640, 480);
            this.openGLControl1.TabIndex = 8;
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(551, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Left";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(609, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Down";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(609, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Up";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(668, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 41);
            this.button4.TabIndex = 10;
            this.button4.Text = "Right";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // step_flight
            // 
            this.step_flight.Location = new System.Drawing.Point(584, 84);
            this.step_flight.Name = "step_flight";
            this.step_flight.Size = new System.Drawing.Size(120, 22);
            this.step_flight.TabIndex = 11;
            this.step_flight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(584, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Step move (in cm)";
            // 
            // takeoff
            // 
            this.takeoff.BackColor = System.Drawing.Color.White;
            this.takeoff.Location = new System.Drawing.Point(568, 392);
            this.takeoff.Name = "takeoff";
            this.takeoff.Size = new System.Drawing.Size(136, 63);
            this.takeoff.TabIndex = 13;
            this.takeoff.Text = "TakeOFF";
            this.takeoff.UseVisualStyleBackColor = false;
            this.takeoff.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(584, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fly altitude (in cm)";
            // 
            // altitude
            // 
            this.altitude.Location = new System.Drawing.Point(584, 176);
            this.altitude.Name = "altitude";
            this.altitude.Size = new System.Drawing.Size(120, 22);
            this.altitude.TabIndex = 14;
            this.altitude.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.altitude.ValueChanged += new System.EventHandler(this.altitude_ValueChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(510, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 41);
            this.button5.TabIndex = 16;
            this.button5.Text = "Clockwise";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(689, 312);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 41);
            this.button6.TabIndex = 17;
            this.button6.Text = "Сounter-    clockwise";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(584, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Step rotate (in degrees)";
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(584, 126);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(120, 22);
            this.angle.TabIndex = 18;
            this.angle.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 390);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1681, 597);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.altitude);
            this.Controls.Add(this.takeoff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.step_flight);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openGLControl1);
            this.Controls.Add(this.debug_2);
            this.Controls.Add(this.debug_1);
            this.Controls.Add(this.Restart_but);
            this.Controls.Add(this.Start_cam_but);
            this.Controls.Add(this.Open_but);
            this.Controls.Add(this.Main_picture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Main_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.step_flight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Main_picture;
        private System.Windows.Forms.Button Open_but;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Start_cam_but;
        private System.Windows.Forms.Button Restart_but;
        private System.Windows.Forms.TextBox debug_1;
        private System.Windows.Forms.TextBox debug_2;
        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown step_flight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button takeoff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown altitude;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown angle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

