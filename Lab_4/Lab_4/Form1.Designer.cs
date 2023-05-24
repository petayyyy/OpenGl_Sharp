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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ZComboBox = new System.Windows.Forms.ComboBox();
            this.YComboBox = new System.Windows.Forms.ComboBox();
            this.XComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeToComboBox = new System.Windows.Forms.ComboBox();
            this.TimeFromComboBox = new System.Windows.Forms.ComboBox();
            this.NodesComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picture_but = new System.Windows.Forms.Button();
            this.Open_but = new System.Windows.Forms.Button();
            this.HideBottomPlaneCheckBox = new System.Windows.Forms.CheckBox();
            this.HideFrontPlaneCheckBox = new System.Windows.Forms.CheckBox();
            this.HideTopPlaneCheckBox = new System.Windows.Forms.CheckBox();
            this.HideRightPlaneCheckBox = new System.Windows.Forms.CheckBox();
            this.HideCubeCheckBox = new System.Windows.Forms.CheckBox();
            this.CANDataGrid = new System.Windows.Forms.DataGridView();
            this.HideLeftPlaneCheckBox = new System.Windows.Forms.CheckBox();
            this.HideBackPlaneCheckBox = new System.Windows.Forms.CheckBox();
            this.DataControl = new SharpGL.OpenGLControl();
            this.label3 = new System.Windows.Forms.Label();
            this.angleY_bar = new System.Windows.Forms.VScrollBar();
            this.angleX_bar = new System.Windows.Forms.HScrollBar();
            this.sliding = new System.Windows.Forms.HScrollBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.debug = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CANDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ZComboBox
            // 
            this.ZComboBox.FormattingEnabled = true;
            this.ZComboBox.Location = new System.Drawing.Point(1266, 1174);
            this.ZComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ZComboBox.Name = "ZComboBox";
            this.ZComboBox.Size = new System.Drawing.Size(180, 28);
            this.ZComboBox.TabIndex = 55;
            this.ZComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // YComboBox
            // 
            this.YComboBox.FormattingEnabled = true;
            this.YComboBox.Location = new System.Drawing.Point(1266, 1132);
            this.YComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.YComboBox.Name = "YComboBox";
            this.YComboBox.Size = new System.Drawing.Size(180, 28);
            this.YComboBox.TabIndex = 54;
            this.YComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // XComboBox
            // 
            this.XComboBox.FormattingEnabled = true;
            this.XComboBox.Location = new System.Drawing.Point(1266, 1091);
            this.XComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.XComboBox.Name = "XComboBox";
            this.XComboBox.Size = new System.Drawing.Size(180, 28);
            this.XComboBox.TabIndex = 53;
            this.XComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1231, 1184);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Z:";
            // 
            // TimeToComboBox
            // 
            this.TimeToComboBox.FormattingEnabled = true;
            this.TimeToComboBox.Location = new System.Drawing.Point(1232, 336);
            this.TimeToComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimeToComboBox.Name = "TimeToComboBox";
            this.TimeToComboBox.Size = new System.Drawing.Size(248, 28);
            this.TimeToComboBox.TabIndex = 52;
            this.TimeToComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // TimeFromComboBox
            // 
            this.TimeFromComboBox.FormattingEnabled = true;
            this.TimeFromComboBox.Location = new System.Drawing.Point(1232, 266);
            this.TimeFromComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimeFromComboBox.Name = "TimeFromComboBox";
            this.TimeFromComboBox.Size = new System.Drawing.Size(248, 28);
            this.TimeFromComboBox.TabIndex = 51;
            this.TimeFromComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // NodesComboBox
            // 
            this.NodesComboBox.FormattingEnabled = true;
            this.NodesComboBox.Location = new System.Drawing.Point(1232, 195);
            this.NodesComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NodesComboBox.Name = "NodesComboBox";
            this.NodesComboBox.Size = new System.Drawing.Size(248, 28);
            this.NodesComboBox.TabIndex = 50;
            this.NodesComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1227, 308);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Time end";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1231, 1141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1227, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Time start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1227, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Data collection system";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1231, 1100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "X:";
            // 
            // picture_but
            // 
            this.picture_but.BackColor = System.Drawing.Color.White;
            this.picture_but.Location = new System.Drawing.Point(1232, 90);
            this.picture_but.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picture_but.Name = "picture_but";
            this.picture_but.Size = new System.Drawing.Size(256, 52);
            this.picture_but.TabIndex = 38;
            this.picture_but.Text = "Take picture";
            this.picture_but.UseVisualStyleBackColor = false;
            this.picture_but.Click += new System.EventHandler(this.GetScreenshotButton_Click);
            // 
            // Open_but
            // 
            this.Open_but.BackColor = System.Drawing.Color.White;
            this.Open_but.Location = new System.Drawing.Point(1232, 28);
            this.Open_but.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Open_but.Name = "Open_but";
            this.Open_but.Size = new System.Drawing.Size(256, 52);
            this.Open_but.TabIndex = 37;
            this.Open_but.Text = "Open file";
            this.Open_but.UseVisualStyleBackColor = false;
            this.Open_but.Click += new System.EventHandler(this.LoadCANFileButton_Click);
            // 
            // HideBottomPlaneCheckBox
            // 
            this.HideBottomPlaneCheckBox.AutoSize = true;
            this.HideBottomPlaneCheckBox.BackColor = System.Drawing.Color.White;
            this.HideBottomPlaneCheckBox.Location = new System.Drawing.Point(1300, 474);
            this.HideBottomPlaneCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HideBottomPlaneCheckBox.Name = "HideBottomPlaneCheckBox";
            this.HideBottomPlaneCheckBox.Size = new System.Drawing.Size(154, 24);
            this.HideBottomPlaneCheckBox.TabIndex = 34;
            this.HideBottomPlaneCheckBox.Text = "The Bottom edge";
            this.HideBottomPlaneCheckBox.UseVisualStyleBackColor = false;
            this.HideBottomPlaneCheckBox.Click += new System.EventHandler(this.HideLeftPlaneCheckBox_Click);
            // 
            // HideFrontPlaneCheckBox
            // 
            this.HideFrontPlaneCheckBox.AutoSize = true;
            this.HideFrontPlaneCheckBox.BackColor = System.Drawing.Color.White;
            this.HideFrontPlaneCheckBox.Location = new System.Drawing.Point(1298, 529);
            this.HideFrontPlaneCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HideFrontPlaneCheckBox.Name = "HideFrontPlaneCheckBox";
            this.HideFrontPlaneCheckBox.Size = new System.Drawing.Size(109, 24);
            this.HideFrontPlaneCheckBox.TabIndex = 30;
            this.HideFrontPlaneCheckBox.Text = "Front edge";
            this.HideFrontPlaneCheckBox.UseVisualStyleBackColor = false;
            this.HideFrontPlaneCheckBox.Click += new System.EventHandler(this.HideLeftPlaneCheckBox_Click);
            // 
            // HideTopPlaneCheckBox
            // 
            this.HideTopPlaneCheckBox.AutoSize = true;
            this.HideTopPlaneCheckBox.BackColor = System.Drawing.Color.White;
            this.HideTopPlaneCheckBox.Checked = true;
            this.HideTopPlaneCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HideTopPlaneCheckBox.Location = new System.Drawing.Point(1300, 439);
            this.HideTopPlaneCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HideTopPlaneCheckBox.Name = "HideTopPlaneCheckBox";
            this.HideTopPlaneCheckBox.Size = new System.Drawing.Size(146, 24);
            this.HideTopPlaneCheckBox.TabIndex = 29;
            this.HideTopPlaneCheckBox.Text = "The Upper edge";
            this.HideTopPlaneCheckBox.UseVisualStyleBackColor = false;
            this.HideTopPlaneCheckBox.Click += new System.EventHandler(this.HideLeftPlaneCheckBox_Click);
            // 
            // HideRightPlaneCheckBox
            // 
            this.HideRightPlaneCheckBox.AutoSize = true;
            this.HideRightPlaneCheckBox.BackColor = System.Drawing.Color.White;
            this.HideRightPlaneCheckBox.Location = new System.Drawing.Point(1298, 620);
            this.HideRightPlaneCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HideRightPlaneCheckBox.Name = "HideRightPlaneCheckBox";
            this.HideRightPlaneCheckBox.Size = new System.Drawing.Size(109, 24);
            this.HideRightPlaneCheckBox.TabIndex = 28;
            this.HideRightPlaneCheckBox.Text = "Right edge";
            this.HideRightPlaneCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HideRightPlaneCheckBox.UseVisualStyleBackColor = false;
            this.HideRightPlaneCheckBox.Click += new System.EventHandler(this.HideLeftPlaneCheckBox_Click);
            // 
            // HideCubeCheckBox
            // 
            this.HideCubeCheckBox.AutoSize = true;
            this.HideCubeCheckBox.BackColor = System.Drawing.Color.White;
            this.HideCubeCheckBox.Checked = true;
            this.HideCubeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HideCubeCheckBox.Location = new System.Drawing.Point(1300, 385);
            this.HideCubeCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HideCubeCheckBox.Name = "HideCubeCheckBox";
            this.HideCubeCheckBox.Size = new System.Drawing.Size(69, 24);
            this.HideCubeCheckBox.TabIndex = 27;
            this.HideCubeCheckBox.Text = "Cube";
            this.HideCubeCheckBox.UseVisualStyleBackColor = false;
            this.HideCubeCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckChanged);
            // 
            // CANDataGrid
            // 
            this.CANDataGrid.AllowUserToAddRows = false;
            this.CANDataGrid.AllowUserToDeleteRows = false;
            this.CANDataGrid.AllowUserToResizeColumns = false;
            this.CANDataGrid.AllowUserToResizeRows = false;
            this.CANDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CANDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CANDataGrid.Location = new System.Drawing.Point(1515, 20);
            this.CANDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CANDataGrid.MultiSelect = false;
            this.CANDataGrid.Name = "CANDataGrid";
            this.CANDataGrid.RowHeadersVisible = false;
            this.CANDataGrid.RowHeadersWidth = 51;
            this.CANDataGrid.Size = new System.Drawing.Size(541, 1268);
            this.CANDataGrid.TabIndex = 39;
            // 
            // HideLeftPlaneCheckBox
            // 
            this.HideLeftPlaneCheckBox.AutoSize = true;
            this.HideLeftPlaneCheckBox.BackColor = System.Drawing.Color.White;
            this.HideLeftPlaneCheckBox.Location = new System.Drawing.Point(1298, 655);
            this.HideLeftPlaneCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HideLeftPlaneCheckBox.Name = "HideLeftPlaneCheckBox";
            this.HideLeftPlaneCheckBox.Size = new System.Drawing.Size(99, 24);
            this.HideLeftPlaneCheckBox.TabIndex = 35;
            this.HideLeftPlaneCheckBox.Text = "Left edge";
            this.HideLeftPlaneCheckBox.UseVisualStyleBackColor = false;
            this.HideLeftPlaneCheckBox.Click += new System.EventHandler(this.HideLeftPlaneCheckBox_Click);
            // 
            // HideBackPlaneCheckBox
            // 
            this.HideBackPlaneCheckBox.AutoSize = true;
            this.HideBackPlaneCheckBox.BackColor = System.Drawing.Color.White;
            this.HideBackPlaneCheckBox.Location = new System.Drawing.Point(1299, 564);
            this.HideBackPlaneCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HideBackPlaneCheckBox.Name = "HideBackPlaneCheckBox";
            this.HideBackPlaneCheckBox.Size = new System.Drawing.Size(107, 24);
            this.HideBackPlaneCheckBox.TabIndex = 36;
            this.HideBackPlaneCheckBox.Text = "Back edge";
            this.HideBackPlaneCheckBox.UseVisualStyleBackColor = false;
            this.HideBackPlaneCheckBox.Click += new System.EventHandler(this.HideLeftPlaneCheckBox_Click);
            // 
            // DataControl
            // 
            this.DataControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataControl.DrawFPS = false;
            this.DataControl.Location = new System.Drawing.Point(16, 20);
            this.DataControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DataControl.Name = "DataControl";
            this.DataControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.DataControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.DataControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.DataControl.Size = new System.Drawing.Size(1125, 1250);
            this.DataControl.TabIndex = 25;
            this.DataControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataControl_MouseDown);
            this.DataControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DataControl_MouseMove);
            this.DataControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DataControl_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1208, 956);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Sliding window";
            // 
            // angleY_bar
            // 
            this.angleY_bar.Location = new System.Drawing.Point(1151, 20);
            this.angleY_bar.Maximum = 180;
            this.angleY_bar.Name = "angleY_bar";
            this.angleY_bar.Size = new System.Drawing.Size(21, 1250);
            this.angleY_bar.TabIndex = 56;
            this.angleY_bar.Value = 90;
            this.angleY_bar.ValueChanged += new System.EventHandler(this.angleY_bar_ValueChanged);
            // 
            // angleX_bar
            // 
            this.angleX_bar.Location = new System.Drawing.Point(16, 1281);
            this.angleX_bar.Maximum = 180;
            this.angleX_bar.Minimum = -180;
            this.angleX_bar.Name = "angleX_bar";
            this.angleX_bar.Size = new System.Drawing.Size(1125, 21);
            this.angleX_bar.TabIndex = 57;
            this.angleX_bar.ValueChanged += new System.EventHandler(this.angleX_bar_ValueChanged);
            // 
            // sliding
            // 
            this.sliding.Location = new System.Drawing.Point(1212, 991);
            this.sliding.Name = "sliding";
            this.sliding.Size = new System.Drawing.Size(269, 21);
            this.sliding.TabIndex = 58;
            this.sliding.ValueChanged += new System.EventHandler(this.sliding_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "DAMP | *.dmp";
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(1174, 1295);
            this.debug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(882, 26);
            this.debug.TabIndex = 59;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.sliding);
            this.Controls.Add(this.angleX_bar);
            this.Controls.Add(this.angleY_bar);
            this.Controls.Add(this.HideLeftPlaneCheckBox);
            this.Controls.Add(this.HideCubeCheckBox);
            this.Controls.Add(this.HideBackPlaneCheckBox);
            this.Controls.Add(this.HideRightPlaneCheckBox);
            this.Controls.Add(this.ZComboBox);
            this.Controls.Add(this.HideTopPlaneCheckBox);
            this.Controls.Add(this.HideFrontPlaneCheckBox);
            this.Controls.Add(this.YComboBox);
            this.Controls.Add(this.HideBottomPlaneCheckBox);
            this.Controls.Add(this.XComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TimeToComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimeFromComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NodesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picture_but);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Open_but);
            this.Controls.Add(this.DataControl);
            this.Controls.Add(this.CANDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Lab_4";
            ((System.ComponentModel.ISupportInitialize)(this.CANDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ZComboBox;
        private System.Windows.Forms.ComboBox YComboBox;
        private System.Windows.Forms.ComboBox XComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TimeToComboBox;
        private System.Windows.Forms.ComboBox TimeFromComboBox;
        private System.Windows.Forms.ComboBox NodesComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button picture_but;
        private System.Windows.Forms.Button Open_but;
        private System.Windows.Forms.CheckBox HideBottomPlaneCheckBox;
        private System.Windows.Forms.CheckBox HideFrontPlaneCheckBox;
        private System.Windows.Forms.CheckBox HideTopPlaneCheckBox;
        private System.Windows.Forms.CheckBox HideRightPlaneCheckBox;
        private System.Windows.Forms.CheckBox HideCubeCheckBox;
        private System.Windows.Forms.DataGridView CANDataGrid;
        private SharpGL.OpenGLControl DataControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox HideLeftPlaneCheckBox;
        private System.Windows.Forms.CheckBox HideBackPlaneCheckBox;
        private System.Windows.Forms.VScrollBar angleY_bar;
        private System.Windows.Forms.HScrollBar angleX_bar;
        private System.Windows.Forms.HScrollBar sliding;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox debug;
    }
}