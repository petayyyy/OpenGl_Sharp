namespace Lab_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picture_but = new System.Windows.Forms.Button();
            this.is_density = new System.Windows.Forms.CheckBox();
            this.Open_but = new System.Windows.Forms.Button();
            this.Save_but = new System.Windows.Forms.Button();
            this.Start_but = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OpenGL = new SharpGL.OpenGLControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Vertical_Histograms_pictureBox = new System.Windows.Forms.PictureBox();
            this.Horizontal_Histograms_pictureBox = new System.Windows.Forms.PictureBox();
            this.Histograms = new System.Windows.Forms.PictureBox();
            this.num_point = new System.Windows.Forms.TextBox();
            this.noise = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generate_var_but = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Refr_but = new System.Windows.Forms.Button();
            this.angleY_bar = new System.Windows.Forms.VScrollBar();
            this.angleX_bar = new System.Windows.Forms.HScrollBar();
            this.debug = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenGL)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vertical_Histograms_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontal_Histograms_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_but
            // 
            this.picture_but.BackColor = System.Drawing.Color.GhostWhite;
            this.picture_but.Location = new System.Drawing.Point(1075, 347);
            this.picture_but.Margin = new System.Windows.Forms.Padding(4);
            this.picture_but.Name = "picture_but";
            this.picture_but.Size = new System.Drawing.Size(134, 97);
            this.picture_but.TabIndex = 11;
            this.picture_but.Text = "Take picture";
            this.picture_but.UseVisualStyleBackColor = false;
            this.picture_but.Click += new System.EventHandler(this.SaveImage_button_Click);
            // 
            // is_density
            // 
            this.is_density.AutoSize = true;
            this.is_density.Location = new System.Drawing.Point(1078, 942);
            this.is_density.Margin = new System.Windows.Forms.Padding(4);
            this.is_density.Name = "is_density";
            this.is_density.Size = new System.Drawing.Size(74, 20);
            this.is_density.TabIndex = 8;
            this.is_density.Text = "Density";
            this.is_density.UseVisualStyleBackColor = true;
            this.is_density.CheckedChanged += new System.EventHandler(this.Surface_checkBox_CheckedChanged);
            // 
            // Open_but
            // 
            this.Open_but.BackColor = System.Drawing.Color.GhostWhite;
            this.Open_but.Location = new System.Drawing.Point(1075, 551);
            this.Open_but.Margin = new System.Windows.Forms.Padding(4);
            this.Open_but.Name = "Open_but";
            this.Open_but.Size = new System.Drawing.Size(134, 92);
            this.Open_but.TabIndex = 4;
            this.Open_but.Text = "Open file";
            this.Open_but.UseVisualStyleBackColor = false;
            this.Open_but.Click += new System.EventHandler(this.Download_button_Click);
            // 
            // Save_but
            // 
            this.Save_but.BackColor = System.Drawing.Color.GhostWhite;
            this.Save_but.Enabled = false;
            this.Save_but.Location = new System.Drawing.Point(1075, 452);
            this.Save_but.Margin = new System.Windows.Forms.Padding(4);
            this.Save_but.Name = "Save_but";
            this.Save_but.Size = new System.Drawing.Size(134, 91);
            this.Save_but.TabIndex = 3;
            this.Save_but.Text = "Save csv";
            this.Save_but.UseVisualStyleBackColor = false;
            this.Save_but.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Start_but
            // 
            this.Start_but.BackColor = System.Drawing.Color.White;
            this.Start_but.Location = new System.Drawing.Point(1075, 147);
            this.Start_but.Margin = new System.Windows.Forms.Padding(4);
            this.Start_but.Name = "Start_but";
            this.Start_but.Size = new System.Drawing.Size(134, 92);
            this.Start_but.TabIndex = 1;
            this.Start_but.Text = "Generate points";
            this.Start_but.UseVisualStyleBackColor = false;
            this.Start_but.Click += new System.EventHandler(this.Generate_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 1000);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OpenGL);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(992, 971);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Point3D";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OpenGL
            // 
            this.OpenGL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpenGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenGL.DrawFPS = false;
            this.OpenGL.Location = new System.Drawing.Point(4, 4);
            this.OpenGL.Margin = new System.Windows.Forms.Padding(5);
            this.OpenGL.Name = "OpenGL";
            this.OpenGL.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.OpenGL.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.OpenGL.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.OpenGL.Size = new System.Drawing.Size(984, 963);
            this.OpenGL.TabIndex = 0;
            this.OpenGL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PointsControl_MouseDown);
            this.OpenGL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PointsControl_MouseMove);
            this.OpenGL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PointsControl_MouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.Vertical_Histograms_pictureBox);
            this.tabPage2.Controls.Add(this.Horizontal_Histograms_pictureBox);
            this.tabPage2.Controls.Add(this.Histograms);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(992, 971);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Point2D";
            // 
            // Vertical_Histograms_pictureBox
            // 
            this.Vertical_Histograms_pictureBox.BackColor = System.Drawing.Color.White;
            this.Vertical_Histograms_pictureBox.Location = new System.Drawing.Point(731, 298);
            this.Vertical_Histograms_pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.Vertical_Histograms_pictureBox.Name = "Vertical_Histograms_pictureBox";
            this.Vertical_Histograms_pictureBox.Size = new System.Drawing.Size(220, 620);
            this.Vertical_Histograms_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vertical_Histograms_pictureBox.TabIndex = 4;
            this.Vertical_Histograms_pictureBox.TabStop = false;
            // 
            // Horizontal_Histograms_pictureBox
            // 
            this.Horizontal_Histograms_pictureBox.BackColor = System.Drawing.Color.White;
            this.Horizontal_Histograms_pictureBox.Location = new System.Drawing.Point(83, 52);
            this.Horizontal_Histograms_pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.Horizontal_Histograms_pictureBox.Name = "Horizontal_Histograms_pictureBox";
            this.Horizontal_Histograms_pictureBox.Size = new System.Drawing.Size(620, 220);
            this.Horizontal_Histograms_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horizontal_Histograms_pictureBox.TabIndex = 3;
            this.Horizontal_Histograms_pictureBox.TabStop = false;
            // 
            // Histograms
            // 
            this.Histograms.BackColor = System.Drawing.Color.White;
            this.Histograms.Location = new System.Drawing.Point(83, 298);
            this.Histograms.Margin = new System.Windows.Forms.Padding(4);
            this.Histograms.Name = "Histograms";
            this.Histograms.Size = new System.Drawing.Size(620, 620);
            this.Histograms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Histograms.TabIndex = 2;
            this.Histograms.TabStop = false;
            // 
            // num_point
            // 
            this.num_point.Location = new System.Drawing.Point(1075, 842);
            this.num_point.Name = "num_point";
            this.num_point.Size = new System.Drawing.Size(134, 22);
            this.num_point.TabIndex = 14;
            this.num_point.Text = "1000";
            // 
            // noise
            // 
            this.noise.Location = new System.Drawing.Point(1075, 900);
            this.noise.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.noise.Name = "noise";
            this.noise.Size = new System.Drawing.Size(134, 22);
            this.noise.TabIndex = 16;
            this.noise.ValueChanged += new System.EventHandler(this.noise_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1075, 820);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Number of points";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1078, 878);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Noise % (0,1 - 100)";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.Z});
            this.dataGridView1.Location = new System.Drawing.Point(1246, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(305, 972);
            this.dataGridView1.TabIndex = 19;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 125;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 125;
            // 
            // Z
            // 
            this.Z.HeaderText = "Z";
            this.Z.MinimumWidth = 6;
            this.Z.Name = "Z";
            this.Z.Width = 125;
            // 
            // generate_var_but
            // 
            this.generate_var_but.BackColor = System.Drawing.Color.White;
            this.generate_var_but.Location = new System.Drawing.Point(1075, 247);
            this.generate_var_but.Margin = new System.Windows.Forms.Padding(4);
            this.generate_var_but.Name = "generate_var_but";
            this.generate_var_but.Size = new System.Drawing.Size(134, 92);
            this.generate_var_but.TabIndex = 20;
            this.generate_var_but.Text = "Generate points by task";
            this.generate_var_but.UseVisualStyleBackColor = false;
            this.generate_var_but.Click += new System.EventHandler(this.generate_var_but_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Refr_but
            // 
            this.Refr_but.BackColor = System.Drawing.Color.GhostWhite;
            this.Refr_but.Location = new System.Drawing.Point(1075, 651);
            this.Refr_but.Margin = new System.Windows.Forms.Padding(4);
            this.Refr_but.Name = "Refr_but";
            this.Refr_but.Size = new System.Drawing.Size(134, 92);
            this.Refr_but.TabIndex = 21;
            this.Refr_but.Text = "Refresh";
            this.Refr_but.UseVisualStyleBackColor = false;
            this.Refr_but.Click += new System.EventHandler(this.Refr_but_Click);
            // 
            // angleY_bar
            // 
            this.angleY_bar.Location = new System.Drawing.Point(1017, 38);
            this.angleY_bar.Maximum = 180;
            this.angleY_bar.Name = "angleY_bar";
            this.angleY_bar.Size = new System.Drawing.Size(21, 971);
            this.angleY_bar.TabIndex = 22;
            this.angleY_bar.Value = 90;
            this.angleY_bar.ValueChanged += new System.EventHandler(this.angleY_bar_ValueChanged);
            // 
            // angleX_bar
            // 
            this.angleX_bar.Location = new System.Drawing.Point(17, 1017);
            this.angleX_bar.Maximum = 180;
            this.angleX_bar.Minimum = -180;
            this.angleX_bar.Name = "angleX_bar";
            this.angleX_bar.Size = new System.Drawing.Size(988, 21);
            this.angleX_bar.TabIndex = 23;
            this.angleX_bar.ValueChanged += new System.EventHandler(this.angleX_bar_ValueChanged);
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(1056, 38);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(495, 22);
            this.debug.TabIndex = 24;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Points",
            "Voxels"});
            this.listBox1.Location = new System.Drawing.Point(1075, 763);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(134, 36);
            this.listBox1.TabIndex = 25;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1562, 1044);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.angleX_bar);
            this.Controls.Add(this.angleY_bar);
            this.Controls.Add(this.Refr_but);
            this.Controls.Add(this.generate_var_but);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noise);
            this.Controls.Add(this.num_point);
            this.Controls.Add(this.picture_but);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.is_density);
            this.Controls.Add(this.Start_but);
            this.Controls.Add(this.Save_but);
            this.Controls.Add(this.Open_but);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kholodilov_3";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OpenGL)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Vertical_Histograms_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontal_Histograms_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start_but;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Open_but;
        private System.Windows.Forms.Button Save_but;
        private System.Windows.Forms.PictureBox Histograms;
        private System.Windows.Forms.CheckBox is_density;
        private System.Windows.Forms.Button picture_but;
        private System.Windows.Forms.TextBox num_point;
        private System.Windows.Forms.NumericUpDown noise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button generate_var_but;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Refr_but;
        private System.Windows.Forms.VScrollBar angleY_bar;
        private System.Windows.Forms.HScrollBar angleX_bar;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.TextBox debug;
        private SharpGL.OpenGLControl OpenGL;
        private System.Windows.Forms.PictureBox Horizontal_Histograms_pictureBox;
        private System.Windows.Forms.PictureBox Vertical_Histograms_pictureBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

