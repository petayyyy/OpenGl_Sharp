namespace test
{
    public partial class Kholodilov_2 : Form
    {
        Random random = new Random();
        bool is_start_work = false;
        bool is_noise_change = false;
        bool is_generate_task = false;
        float[,] generated_point;
        int count_point;
        int axis_line_size = 4;
        int point_size = 5;
        int picture_size = 1100;
        private _3d_transform_point tr_3D = new _3d_transform_point();

        public Kholodilov_2()
        {
            InitializeComponent();
            timer1.Enabled = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 3;
            int size_grid = 60;
            dataGridView1.Columns[0].Width = size_grid;
            dataGridView1.Columns[1].Width = size_grid;
            dataGridView1.Columns[2].Width = size_grid;
            dataGridView1.Width = size_grid * dataGridView1.ColumnCount + 20;
            Main_box.Image = new Bitmap(picture_size, picture_size);
        }

        public void draw_main_img()
        {
            // Draw axis
            Bitmap bmp = new Bitmap(picture_size, picture_size);
            Graphics g = Graphics.FromImage(bmp);
            g.TranslateTransform(picture_size / 2, picture_size / 2);

            float[,,,] Axis =  { { {{0f}, {0f}, {0f}}, {{0.75f}, {0.5f}, {0f}}  }, // X: start, end
                                 { {{0f}, {0f}, {0f}}, {{-0.75f}, {0.5f}, {0f}} }, // Y: start, end
                                 { {{0f}, {0f}, {0f}}, {{0f}, {-1f}, {0f}}      }  // Z: start, end
            };

            float[,] XAxe0Vector = { { 0f }, { 0f }, { 0f } };
            float[,] XAxeEndVector = { { 0.75f }, { 0.5f }, { 0f } };

            float[,] YAxe0Vector = { { 0f }, { 0f }, { 0 } };
            float[,] YAxeEndVector = { { -0.75f }, { 0.5f }, { 0 } };

            float[,] ZAxe0Vector = { { 0 }, { 0 }, { 0 } };
            float[,] ZAxeEndVector = { { 0 }, { -1f }, { 0 } };

            int[] XAxe0Point = tr_3D.Project(XAxe0Vector);
            int[] XAxeEndPoint = tr_3D.Project(XAxeEndVector);
            int[] YAxe0Point = tr_3D.Project(YAxe0Vector);
            int[] YAxeEndPoint = tr_3D.Project(YAxeEndVector);
            int[] ZAxe0Point = tr_3D.Project(ZAxe0Vector);
            int[] ZAxeEndPoint = tr_3D.Project(ZAxeEndVector);
            g.DrawLine(new Pen(Color.Red, axis_line_size), XAxe0Point[0], XAxe0Point[1], XAxeEndPoint[0], XAxeEndPoint[1]);
            g.DrawLine(new Pen(Color.Green, axis_line_size), YAxe0Point[0], YAxe0Point[1], YAxeEndPoint[0], YAxeEndPoint[1]);
            g.DrawLine(new Pen(Color.Blue, axis_line_size), ZAxe0Point[0], ZAxe0Point[1], ZAxeEndPoint[0], ZAxeEndPoint[1]);

            g.DrawString("X", new Font("Aria", 20, FontStyle.Bold), Brushes.Red, XAxeEndPoint[0], XAxeEndPoint[1]);
            g.DrawString("Y", new Font("Aria", 20, FontStyle.Bold), Brushes.Green, YAxeEndPoint[0], YAxeEndPoint[1]);
            g.DrawString("Z", new Font("Aria", 20, FontStyle.Bold), Brushes.Blue, ZAxeEndPoint[0], ZAxeEndPoint[1]);

            //Draw points
            if (is_start_work)
            {
                for (int i = 0; i < count_point; i++)
                {
                    int[] Projected = tr_3D.Project(new float[,] { { generated_point[i, 0] }, { generated_point[i, 1] }, { generated_point[i, 2] } });
                    g.FillEllipse(new SolidBrush(Color.Black), Projected[0] - point_size, Projected[1] - point_size, point_size * 2, point_size * 2);
                }
            }
            Main_box.Image = bmp;

        }
        public void view_datagreed()
        {
            if (Int32.Parse(num_point.Text) > 0)
            {
                dataGridView1.RowCount = 1;
                for (int i = 0; i < Int32.Parse(num_point.Text); i++)
                {
                    dataGridView1.RowCount += 1;
                    dataGridView1.Rows[i].Cells[0].Value = Math.Round(generated_point[i, 0], 2);
                    dataGridView1.Rows[i].Cells[1].Value = Math.Round(generated_point[i, 1], 2);
                    dataGridView1.Rows[i].Cells[2].Value = Math.Round(generated_point[i, 2], 2);
                }
            }
        }
        public void generate_points(bool is_task = false, bool is_noise = false)
        {
            generated_point = new float[count_point, 3];
            for (int i = 0; i < count_point; i++)
            {
                if (!is_task) for (int j = 0; j < 3; j++) generated_point[i, j] = (float)Math.Round((double)random.Next(-100, 100) / 100, 2) + noise_for_points(is_noise);
                else
                {
                    //x = 0.7 * cos(6 * pi * (i / count_point))
                    generated_point[i, 0] = (float)(0.7f * Math.Cos(6d * Math.PI * (((double)i / count_point)))) + noise_for_points(is_noise);
                    //y = 0.5 * sin(4 * pi * (i / count_point))
                    generated_point[i, 1] = (float)(0.5f * Math.Sin(4d * Math.PI * ((double)i / count_point))) + noise_for_points(is_noise);
                    //z = -1 + 2 * i / N
                    generated_point[i, 2] = (float)(-1f + 2f * (float)i / count_point) + noise_for_points(is_noise);
                }
            }
        }
        private float noise_for_points(bool is_noise = false)
        {
            if (!is_noise) return 0.0f;
            double u1 = 1.0f - (float)random.NextDouble();
            double u2 = 1.0f - (float)random.NextDouble();
            float randStdNormal = (float)(Math.Sqrt(-2.0d * Math.Log(u1)) * Math.Sin(2.0d * Math.PI * u2));
            float randNormal = (float)((float)(noise.Value / 100) * randStdNormal);
            return randNormal;
        }
        public void start_work(bool is_task = false)
        {
            count_point = Int32.Parse(num_point.Text);
            generate_points(is_task, is_noise_change);
            is_start_work = true;
            view_datagreed();
            draw_main_img();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            draw_main_img();
        }

        private void Start_but_Click_1(object sender, EventArgs e)
        {
            if (Int32.Parse(num_point.Text) > 0)
            {
                is_generate_task = false;
                start_work();
                timer1.Start();
            }
        }

        private void generate_var_but_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(num_point.Text) > 0)
            {
                is_generate_task = true;
                start_work(true);
                timer1.Start();
            }
        }

        private void noise_ValueChanged(object sender, EventArgs e)
        {
            is_noise_change = true;
        }

        private void Refr_but_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            is_start_work = false;
            draw_main_img();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (is_start_work && is_noise_change)
            {
                generate_points(is_generate_task, is_noise_change);
                view_datagreed();
                draw_main_img();
                is_noise_change = false;
            }
        }
    }
}