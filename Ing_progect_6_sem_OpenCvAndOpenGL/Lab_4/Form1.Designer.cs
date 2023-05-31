namespace Lab_4
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
            this.ZComboBox = new System.Windows.Forms.ComboBox();
            this.YComboBox = new System.Windows.Forms.ComboBox();
            this.XComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picture_but = new System.Windows.Forms.Button();
            this.Open_but = new System.Windows.Forms.Button();
            this.DataControl = new SharpGL.OpenGLControl();
            this.angleY_bar = new System.Windows.Forms.VScrollBar();
            this.angleX_bar = new System.Windows.Forms.HScrollBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.debug = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Main_picture = new System.Windows.Forms.PictureBox();
            this.debugg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // ZComboBox
            // 
            this.ZComboBox.FormattingEnabled = true;
            this.ZComboBox.Location = new System.Drawing.Point(1125, 939);
            this.ZComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ZComboBox.Name = "ZComboBox";
            this.ZComboBox.Size = new System.Drawing.Size(160, 24);
            this.ZComboBox.TabIndex = 55;
            this.ZComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // YComboBox
            // 
            this.YComboBox.FormattingEnabled = true;
            this.YComboBox.Location = new System.Drawing.Point(1125, 906);
            this.YComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.YComboBox.Name = "YComboBox";
            this.YComboBox.Size = new System.Drawing.Size(160, 24);
            this.YComboBox.TabIndex = 54;
            this.YComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // XComboBox
            // 
            this.XComboBox.FormattingEnabled = true;
            this.XComboBox.Location = new System.Drawing.Point(1125, 873);
            this.XComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.XComboBox.Name = "XComboBox";
            this.XComboBox.Size = new System.Drawing.Size(160, 24);
            this.XComboBox.TabIndex = 53;
            this.XComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1094, 947);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Z:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1094, 913);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1094, 880);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "X:";
            // 
            // picture_but
            // 
            this.picture_but.BackColor = System.Drawing.Color.White;
            this.picture_but.Location = new System.Drawing.Point(1095, 72);
            this.picture_but.Margin = new System.Windows.Forms.Padding(4);
            this.picture_but.Name = "picture_but";
            this.picture_but.Size = new System.Drawing.Size(228, 42);
            this.picture_but.TabIndex = 38;
            this.picture_but.Text = "Take picture";
            this.picture_but.UseVisualStyleBackColor = false;
            this.picture_but.Click += new System.EventHandler(this.GetScreenshotButton_Click);
            // 
            // Open_but
            // 
            this.Open_but.BackColor = System.Drawing.Color.White;
            this.Open_but.Location = new System.Drawing.Point(1095, 22);
            this.Open_but.Margin = new System.Windows.Forms.Padding(4);
            this.Open_but.Name = "Open_but";
            this.Open_but.Size = new System.Drawing.Size(228, 42);
            this.Open_but.TabIndex = 37;
            this.Open_but.Text = "Open file";
            this.Open_but.UseVisualStyleBackColor = false;
            this.Open_but.Click += new System.EventHandler(this.LoadCANFileButton_Click);
            // 
            // DataControl
            // 
            this.DataControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataControl.DrawFPS = false;
            this.DataControl.Location = new System.Drawing.Point(14, 16);
            this.DataControl.Margin = new System.Windows.Forms.Padding(5);
            this.DataControl.Name = "DataControl";
            this.DataControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.DataControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.DataControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.DataControl.Size = new System.Drawing.Size(1000, 1000);
            this.DataControl.TabIndex = 25;
            this.DataControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataControl_MouseDown);
            this.DataControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DataControl_MouseMove);
            this.DataControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DataControl_MouseUp);
            // 
            // angleY_bar
            // 
            this.angleY_bar.Location = new System.Drawing.Point(1023, 16);
            this.angleY_bar.Maximum = 180;
            this.angleY_bar.Name = "angleY_bar";
            this.angleY_bar.Size = new System.Drawing.Size(21, 1000);
            this.angleY_bar.TabIndex = 56;
            this.angleY_bar.Value = 90;
            this.angleY_bar.ValueChanged += new System.EventHandler(this.angleY_bar_ValueChanged);
            // 
            // angleX_bar
            // 
            this.angleX_bar.Location = new System.Drawing.Point(14, 1025);
            this.angleX_bar.Maximum = 180;
            this.angleX_bar.Minimum = -180;
            this.angleX_bar.Name = "angleX_bar";
            this.angleX_bar.Size = new System.Drawing.Size(1000, 21);
            this.angleX_bar.TabIndex = 57;
            this.angleX_bar.ValueChanged += new System.EventHandler(this.angleX_bar_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(1044, 1036);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(784, 22);
            this.debug.TabIndex = 59;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main_picture
            // 
            this.Main_picture.Location = new System.Drawing.Point(1074, 121);
            this.Main_picture.Name = "Main_picture";
            this.Main_picture.Size = new System.Drawing.Size(405, 319);
            this.Main_picture.TabIndex = 60;
            this.Main_picture.TabStop = false;
            // 
            // debugg
            // 
            this.debugg.Location = new System.Drawing.Point(1163, 522);
            this.debugg.Name = "debugg";
            this.debugg.Size = new System.Drawing.Size(100, 22);
            this.debugg.TabIndex = 61;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1710, 844);
            this.Controls.Add(this.debugg);
            this.Controls.Add(this.Main_picture);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.angleX_bar);
            this.Controls.Add(this.angleY_bar);
            this.Controls.Add(this.ZComboBox);
            this.Controls.Add(this.YComboBox);
            this.Controls.Add(this.XComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picture_but);
            this.Controls.Add(this.Open_but);
            this.Controls.Add(this.DataControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lab_4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ZComboBox;
        private System.Windows.Forms.ComboBox YComboBox;
        private System.Windows.Forms.ComboBox XComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button picture_but;
        private System.Windows.Forms.Button Open_but;
        private SharpGL.OpenGLControl DataControl;
        private System.Windows.Forms.VScrollBar angleY_bar;
        private System.Windows.Forms.HScrollBar angleX_bar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox debug;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Main_picture;
        private System.Windows.Forms.TextBox debugg;
    }
}