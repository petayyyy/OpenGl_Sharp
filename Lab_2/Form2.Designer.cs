namespace Lab_2
{
    partial class Kholodilov_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kholodilov_2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start_but = new System.Windows.Forms.Button();
            this.Refr_but = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_point = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noise = new System.Windows.Forms.NumericUpDown();
            this.Main_box = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.is_density = new System.Windows.Forms.CheckBox();
            this.generate_var_but = new System.Windows.Forms.Button();
            this.picture_but = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_box)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start_but
            // 
            this.Start_but.Location = new System.Drawing.Point(1667, 46);
            this.Start_but.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_but.Name = "Start_but";
            this.Start_but.Size = new System.Drawing.Size(87, 64);
            this.Start_but.TabIndex = 0;
            this.Start_but.Text = "Generate points";
            this.Start_but.UseVisualStyleBackColor = true;
            this.Start_but.Click += new System.EventHandler(this.Start_but_Click);
            // 
            // Refr_but
            // 
            this.Refr_but.Location = new System.Drawing.Point(1759, 46);
            this.Refr_but.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Refr_but.Name = "Refr_but";
            this.Refr_but.Size = new System.Drawing.Size(87, 64);
            this.Refr_but.TabIndex = 2;
            this.Refr_but.Text = "Refresh";
            this.Refr_but.UseVisualStyleBackColor = true;
            this.Refr_but.Click += new System.EventHandler(this.Send_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y,
            this.z});
            this.dataGridView1.Location = new System.Drawing.Point(1450, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(231, 1284);
            this.dataGridView1.TabIndex = 5;
            // 
            // x
            // 
            this.x.HeaderText = "X";
            this.x.MinimumWidth = 6;
            this.x.Name = "x";
            this.x.Width = 125;
            // 
            // y
            // 
            this.y.HeaderText = "Y";
            this.y.MinimumWidth = 6;
            this.y.Name = "y";
            this.y.Width = 125;
            // 
            // z
            // 
            this.z.HeaderText = "Z";
            this.z.MinimumWidth = 6;
            this.z.Name = "z";
            this.z.Width = 125;
            // 
            // num_point
            // 
            this.num_point.Location = new System.Drawing.Point(1690, 288);
            this.num_point.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_point.Name = "num_point";
            this.num_point.Size = new System.Drawing.Size(64, 22);
            this.num_point.TabIndex = 7;
            this.num_point.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1690, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of points";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1687, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Noise";
            // 
            // noise
            // 
            this.noise.Location = new System.Drawing.Point(1687, 219);
            this.noise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noise.Name = "noise";
            this.noise.Size = new System.Drawing.Size(167, 22);
            this.noise.TabIndex = 15;
            this.noise.ValueChanged += new System.EventHandler(this.y2_1_param_ValueChanged);
            // 
            // Main_box
            // 
            this.Main_box.BackColor = System.Drawing.Color.White;
            this.Main_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_box.Location = new System.Drawing.Point(12, 11);
            this.Main_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Main_box.Name = "Main_box";
            this.Main_box.Size = new System.Drawing.Size(1000, 1000);
            this.Main_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Main_box.TabIndex = 63;
            this.Main_box.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // is_density
            // 
            this.is_density.AutoSize = true;
            this.is_density.BackColor = System.Drawing.Color.White;
            this.is_density.Location = new System.Drawing.Point(1690, 333);
            this.is_density.Margin = new System.Windows.Forms.Padding(4);
            this.is_density.Name = "is_density";
            this.is_density.Size = new System.Drawing.Size(65, 20);
            this.is_density.TabIndex = 64;
            this.is_density.Text = "Noise";
            this.is_density.UseVisualStyleBackColor = false;
            this.is_density.CheckedChanged += new System.EventHandler(this.is_density_CheckedChanged);
            // 
            // generate_var_but
            // 
            this.generate_var_but.Location = new System.Drawing.Point(1852, 46);
            this.generate_var_but.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generate_var_but.Name = "generate_var_but";
            this.generate_var_but.Size = new System.Drawing.Size(87, 64);
            this.generate_var_but.TabIndex = 65;
            this.generate_var_but.Text = "Generate points by task";
            this.generate_var_but.UseVisualStyleBackColor = true;
            this.generate_var_but.Click += new System.EventHandler(this.generate_var_Click);
            // 
            // picture_but
            // 
            this.picture_but.Location = new System.Drawing.Point(1852, 114);
            this.picture_but.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_but.Name = "picture_but";
            this.picture_but.Size = new System.Drawing.Size(87, 64);
            this.picture_but.TabIndex = 66;
            this.picture_but.Text = "Take picture";
            this.picture_but.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Kholodilov_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1947, 1306);
            this.Controls.Add(this.picture_but);
            this.Controls.Add(this.generate_var_but);
            this.Controls.Add(this.is_density);
            this.Controls.Add(this.Main_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.noise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_point);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Refr_but);
            this.Controls.Add(this.Start_but);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Kholodilov_2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Kholodilov_2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed_1);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Start_but;
        private System.Windows.Forms.Button Refr_but;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox num_point;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown noise;
        private System.Windows.Forms.PictureBox Main_box;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox is_density;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn z;
        private System.Windows.Forms.Button generate_var_but;
        private System.Windows.Forms.Button picture_but;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

