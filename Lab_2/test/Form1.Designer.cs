﻿namespace test
{
    partial class Kholodilov_2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kholodilov_2));
            this.Main_box = new System.Windows.Forms.PictureBox();
            this.Start_but = new System.Windows.Forms.Button();
            this.noise = new System.Windows.Forms.NumericUpDown();
            this.num_point = new System.Windows.Forms.TextBox();
            this.generate_var_but = new System.Windows.Forms.Button();
            this.Refr_but = new System.Windows.Forms.Button();
            this.picture_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox_n = new System.Windows.Forms.CheckBox();
            this.angleX_bar = new System.Windows.Forms.HScrollBar();
            this.angleY_bar = new System.Windows.Forms.VScrollBar();
            this.Open_but = new System.Windows.Forms.Button();
            this.Save_but = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Main_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_box
            // 
            this.Main_box.BackColor = System.Drawing.Color.White;
            this.Main_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_box.Location = new System.Drawing.Point(12, 12);
            this.Main_box.Name = "Main_box";
            this.Main_box.Size = new System.Drawing.Size(1100, 1100);
            this.Main_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Main_box.TabIndex = 0;
            this.Main_box.TabStop = false;
            this.Main_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_box_MouseDown);
            this.Main_box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_box_MouseMove);
            this.Main_box.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_box_MouseUp);
            // 
            // Start_but
            // 
            this.Start_but.BackColor = System.Drawing.Color.White;
            this.Start_but.Location = new System.Drawing.Point(1171, 72);
            this.Start_but.Name = "Start_but";
            this.Start_but.Size = new System.Drawing.Size(139, 111);
            this.Start_but.TabIndex = 1;
            this.Start_but.Text = "Generate points";
            this.Start_but.UseVisualStyleBackColor = false;
            this.Start_but.Click += new System.EventHandler(this.Start_but_Click_1);
            // 
            // noise
            // 
            this.noise.Location = new System.Drawing.Point(1171, 451);
            this.noise.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.noise.Name = "noise";
            this.noise.Size = new System.Drawing.Size(139, 27);
            this.noise.TabIndex = 2;
            this.noise.ValueChanged += new System.EventHandler(this.noise_ValueChanged);
            // 
            // num_point
            // 
            this.num_point.Location = new System.Drawing.Point(1171, 394);
            this.num_point.Name = "num_point";
            this.num_point.Size = new System.Drawing.Size(138, 27);
            this.num_point.TabIndex = 3;
            this.num_point.Text = "1000";
            // 
            // generate_var_but
            // 
            this.generate_var_but.BackColor = System.Drawing.Color.White;
            this.generate_var_but.Location = new System.Drawing.Point(1172, 189);
            this.generate_var_but.Name = "generate_var_but";
            this.generate_var_but.Size = new System.Drawing.Size(139, 111);
            this.generate_var_but.TabIndex = 4;
            this.generate_var_but.Text = "Generate points by task";
            this.generate_var_but.UseVisualStyleBackColor = false;
            this.generate_var_but.Click += new System.EventHandler(this.generate_var_but_Click);
            // 
            // Refr_but
            // 
            this.Refr_but.BackColor = System.Drawing.Color.White;
            this.Refr_but.Location = new System.Drawing.Point(1171, 585);
            this.Refr_but.Name = "Refr_but";
            this.Refr_but.Size = new System.Drawing.Size(139, 111);
            this.Refr_but.TabIndex = 5;
            this.Refr_but.Text = "Refresh";
            this.Refr_but.UseVisualStyleBackColor = false;
            this.Refr_but.Click += new System.EventHandler(this.Refr_but_Click);
            // 
            // picture_but
            // 
            this.picture_but.BackColor = System.Drawing.Color.White;
            this.picture_but.Location = new System.Drawing.Point(1170, 936);
            this.picture_but.Name = "picture_but";
            this.picture_but.Size = new System.Drawing.Size(139, 111);
            this.picture_but.TabIndex = 6;
            this.picture_but.Text = "Take picture";
            this.picture_but.UseVisualStyleBackColor = false;
            this.picture_but.Click += new System.EventHandler(this.picture_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1171, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Noise % (0,1 - 100)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1171, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of points";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.Z,
            this.n});
            this.dataGridView1.Location = new System.Drawing.Point(1330, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(252, 1142);
            this.dataGridView1.TabIndex = 9;
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
            // n
            // 
            this.n.HeaderText = "№";
            this.n.MinimumWidth = 6;
            this.n.Name = "n";
            this.n.Width = 125;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "CSV|*.csv";
            // 
            // checkBox_n
            // 
            this.checkBox_n.AutoSize = true;
            this.checkBox_n.BackColor = System.Drawing.Color.White;
            this.checkBox_n.Location = new System.Drawing.Point(1199, 498);
            this.checkBox_n.Name = "checkBox_n";
            this.checkBox_n.Size = new System.Drawing.Size(83, 24);
            this.checkBox_n.TabIndex = 12;
            this.checkBox_n.Text = "With №";
            this.checkBox_n.UseVisualStyleBackColor = false;
            this.checkBox_n.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // angleX_bar
            // 
            this.angleX_bar.Location = new System.Drawing.Point(9, 1128);
            this.angleX_bar.Maximum = 180;
            this.angleX_bar.Minimum = -180;
            this.angleX_bar.Name = "angleX_bar";
            this.angleX_bar.Size = new System.Drawing.Size(1100, 26);
            this.angleX_bar.TabIndex = 13;
            this.angleX_bar.ValueChanged += new System.EventHandler(this.angleX_bar_ValueChanged);
            // 
            // angleY_bar
            // 
            this.angleY_bar.Location = new System.Drawing.Point(1126, 12);
            this.angleY_bar.Maximum = 180;
            this.angleY_bar.Minimum = -180;
            this.angleY_bar.Name = "angleY_bar";
            this.angleY_bar.Size = new System.Drawing.Size(26, 1100);
            this.angleY_bar.TabIndex = 14;
            this.angleY_bar.ValueChanged += new System.EventHandler(this.angleY_bar_ValueChanged);
            // 
            // Open_but
            // 
            this.Open_but.BackColor = System.Drawing.Color.White;
            this.Open_but.Location = new System.Drawing.Point(1170, 702);
            this.Open_but.Name = "Open_but";
            this.Open_but.Size = new System.Drawing.Size(139, 111);
            this.Open_but.TabIndex = 15;
            this.Open_but.Text = "Open file";
            this.Open_but.UseVisualStyleBackColor = false;
            this.Open_but.Click += new System.EventHandler(this.Open_but_Click);
            // 
            // Save_but
            // 
            this.Save_but.BackColor = System.Drawing.Color.White;
            this.Save_but.Location = new System.Drawing.Point(1170, 819);
            this.Save_but.Name = "Save_but";
            this.Save_but.Size = new System.Drawing.Size(139, 111);
            this.Save_but.TabIndex = 16;
            this.Save_but.Text = "Save csv";
            this.Save_but.UseVisualStyleBackColor = false;
            this.Save_but.Click += new System.EventHandler(this.Save_but_Click);
            // 
            // Kholodilov_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1539, 1055);
            this.Controls.Add(this.Save_but);
            this.Controls.Add(this.Open_but);
            this.Controls.Add(this.angleY_bar);
            this.Controls.Add(this.angleX_bar);
            this.Controls.Add(this.checkBox_n);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_but);
            this.Controls.Add(this.Refr_but);
            this.Controls.Add(this.generate_var_but);
            this.Controls.Add(this.num_point);
            this.Controls.Add(this.noise);
            this.Controls.Add(this.Start_but);
            this.Controls.Add(this.Main_box);
            this.Name = "Kholodilov_2";
            this.Text = "Kholodilov_2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Main_box;
        private Button Start_but;
        private NumericUpDown noise;
        private TextBox num_point;
        private Button generate_var_but;
        private Button Refr_but;
        private Button picture_but;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private OpenFileDialog openFileDialog1;
        private CheckBox checkBox_n;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private DataGridViewTextBoxColumn Z;
        private DataGridViewTextBoxColumn n;
        private HScrollBar angleX_bar;
        private VScrollBar angleY_bar;
        private Button Open_but;
        private Button Save_but;
        private SaveFileDialog saveFileDialog1;
    }
}