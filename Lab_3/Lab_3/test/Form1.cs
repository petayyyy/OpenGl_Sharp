using System;
using System.Linq;
using SharpGL;
namespace test
{
    public partial class Kholodilov_3 : Form
    {
        OpenGL gl;
        Random random = new Random();
        bool is_start_work = false;
        bool is_noise_change = false;
        bool is_generate_task = false;
        bool is_rotate_change = false;
        bool is_rotate_scroll_change = false;
        bool is_n_change = false;
        float[,] generated_point;
        int count_point;
        int axis_line_size = 4;
        int point_size = 5;
        int picture_size = 1100;
        int size_grid = 60;
        int[] start_mouse_pose;

        float angle_x = 0f;
        float angle_y = 0f;
        public Kholodilov_3()
        {
            InitializeComponent();
            timer1.Enabled = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Width = size_grid;
            dataGridView1.Columns[1].Width = size_grid;
            dataGridView1.Columns[2].Width = size_grid;
            dataGridView1.Width = size_grid * dataGridView1.ColumnCount + 20;
            Main_box.Image = new Bitmap(picture_size, picture_size);
            angleY_bar.Enabled = false;
            angleX_bar.Enabled = false;
            Refr_but.Enabled = false;
            Save_but.Enabled = false;
        }
        public void draw_main_img()
        {
            gl = null;
            draw_points_3d();
        }
        public void draw_points_3d()
        { /*
            if (vectors.Length == 0) return;
            gl.Clear(SharpGL.OpenGL.GL_COLOR_BUFFER_BIT | SharpGL.OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.MatrixMode(SharpGL.OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Perspective(60.0f, OpenGL.Width / (double)OpenGL.Height, 0.01, 100.0);


            double CamX = POINTS_CAM_RADIUS * Math.Sin(POINTS_MERIDIAN_ANGLE) * Math.Cos(POINTS_EQUATOR_ANGLE);
            double CamY = POINTS_CAM_RADIUS * Math.Cos(POINTS_MERIDIAN_ANGLE);
            double CamZ = POINTS_CAM_RADIUS * Math.Sin(POINTS_MERIDIAN_ANGLE) * Math.Sin(POINTS_EQUATOR_ANGLE);

            gl.LookAt(CamX, CamY, CamZ, 0, 0, 0, 0, 1, 0);

            gl.MatrixMode(SharpGL.OpenGL.GL_MODELVIEW);

            gl.Begin(SharpGL.OpenGL.GL_POINTS);

            int Gap = 1;

            int GapCount = vectors.Length;

            for (int i = 0; i < GapCount; i++)
                for (int j = 0; j < Gap; j++)
                    if (GAP_NUMS.Contains(j + 1))
                    {
                        gl.Color((byte)255, (byte)255, (byte)10);
                        //gl.Color(ColorFromRGB());
                        gl.Vertex(vectors[i * Gap + j].X, vectors[i * Gap + j].Y, vectors[i * Gap + j].Z);
                    }

            gl.End();


            gl.Begin(SharpGL.OpenGL.GL_LINES);

            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 0.0f, 0.0f);
            gl.Vertex(1.0f, 0.0f, 0.0f);

            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(0.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);

            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(0.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 0.0f, 1.0f);

            gl.End();

            // Описывающий куб
            gl.Begin(SharpGL.OpenGL.GL_LINES);
            gl.Color(1.0f, 1.0f, 1.0f);

            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);

            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Vertex(-1.0f, 1.0f, -1.0f);

            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);

            gl.Vertex(1.0f, 1.0f, 1.0f);
            gl.Vertex(-1.0f, 1.0f, 1.0f);

            gl.Vertex(1.0f, 1.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);

            gl.Vertex(1.0f, 1.0f, 1.0f);
            gl.Vertex(1.0f, 1.0f, -1.0f);

            gl.Vertex(-1.0f, 1.0f, -1.0f);
            gl.Vertex(1.0f, 1.0f, -1.0f);

            gl.Vertex(-1.0f, 1.0f, -1.0f);
            gl.Vertex(-1.0f, 1.0f, 1.0f);

            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);

            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);

            gl.Vertex(1.0f, 1.0f, -1.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);

            gl.Vertex(-1.0f, 1.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);

            gl.End();
            */
        }
        public void view_datagreed()
        {
            if (count_point > 0)
            {
                dataGridView1.RowCount = 1;
                for (int i = 0; i < count_point; i++)
                {
                    dataGridView1.RowCount += 1;
                    dataGridView1.Rows[i].Cells[0].Value = Math.Round(generated_point[i, 0], 2);
                    dataGridView1.Rows[i].Cells[1].Value = Math.Round(generated_point[i, 1], 2);
                    dataGridView1.Rows[i].Cells[2].Value = Math.Round(generated_point[i, 2], 2);
                    if (checkBox_n.Checked) dataGridView1.Rows[i].Cells[3].Value = i+1;
                }
            }
        }
        public void generate_points(bool is_task = false, bool is_noise = false)
        {
            generated_point = new float[count_point, 3];
            float [] sum_generated_point = new float[3];
            for (int i = 0; i < count_point; i++)
            {
                if (!is_task) for (int j = 0; j < 3; j++) generated_point[i, j] = (float)Math.Round((double)random.Next(-100, 100) / 100, 2);
                else
                {
                    //x = 0.7 * cos(6 * pi * (i / count_point))
                    generated_point[i, 0] = check_point((float)(0.7f * Math.Cos(6d * Math.PI * (((double)i / count_point)))));
                    //y = 0.5 * sin(4 * pi * (i / count_point))
                    generated_point[i, 1] = check_point((float)(0.5f * Math.Sin(4d * Math.PI * ((double)i / count_point))));
                    //z = -1 + 2 * i / N
                    generated_point[i, 2] = check_point((float)(-1f + 2f * (float)i / count_point));
                }
                if (is_noise) for (int j = 0; j < 3; j++) sum_generated_point[j] += generated_point[i, j];
            }
            if (is_noise) for (int i = 0; i < count_point; i++) for (int j = 0; j < 3; j++) generated_point[i, j] = normal_distribution(generated_point[i, j], (float)(sum_generated_point[j]/count_point));
        }
        public float check_point(float x)
        {
            if (x < -1f) return -1f;
            else if (x > 1f) return 1f;
            else return (float)Math.Round(x, 2);
        }
        public float normal_distribution(float a, float mean)
        {
            double u = random.NextDouble();
            double v = random.NextDouble();
            float std_normal = (float)(Math.Sqrt(-2.0d * Math.Log(u)) * Math.Sin(2.0d * Math.PI * v));
            float gen_noise = (float)((float)(noise.Value / 1000) * std_normal) + a + mean;
            return gen_noise;
        }
        public void start_work(bool is_task = false)
        {
            count_point = Int32.Parse(num_point.Text);
            generate_points(is_task, is_noise_change);
            is_start_work = true;
            angleY_bar.Enabled = true;
            angleX_bar.Enabled = true;
            view_datagreed();
            draw_main_img();
        }
        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            // Создаем экземпляр
            //OpenGL gl = this.openGLControl1.OpenGL;

            //// Очистка экрана и буфера глубин
            //gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            //// Сбрасываем модельно-видовую матрицу
            //gl.LoadIdentity();

            //// Двигаем перо вглубь экрана
            //gl.Translate(0.0f, 0.0f, -5.0f);

            //gl.Begin(OpenGL.GL_TRIANGLES);

            //// Указываем цвет вершин
            //gl.Color(1f, 1f, 1f);

            //gl.Vertex(-1f, -1f);
            //gl.Vertex(0f, 1f);
            //gl.Vertex(1f, -1f);

            //// Завершаем работу
            //gl.End();

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
                generate_var_but.Enabled = false;
                Start_but.Enabled = false;
                Refr_but.Enabled = true;
                Open_but.Enabled = false;
                Save_but.Enabled = true;
            }
        }
        private void generate_var_but_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(num_point.Text) > 0)
            {
                is_generate_task = true;
                start_work(true);
                timer1.Start();
                Start_but.Enabled = false;
                generate_var_but.Enabled = false;
                Refr_but.Enabled = true;
                Open_but.Enabled = false;
                Save_but.Enabled = true;
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
            angle_y = 0;
            angle_x = 0;
            angleY_bar.Enabled = false;
            angleX_bar.Enabled = false;
            generate_var_but.Enabled = true;
            Start_but.Enabled = true;
            Open_but.Enabled = true;
            Save_but.Enabled = false;
            noise.Value = 0;
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
            else if (is_start_work && (is_rotate_change || is_rotate_scroll_change))
            {
                draw_main_img();
                is_rotate_scroll_change = false;
            }
            else if (is_start_work && is_n_change)
            {
                view_datagreed();
                draw_main_img();
                is_n_change = false;
            }
        }
        private void picture_but_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog1.ShowDialog();
            try
            {
                if (res == DialogResult.OK) Main_box.Image.Save(saveFileDialog1.FileName);
            }
            catch
            {
                MessageBox.Show("Something wrong with your picture");
            }
        }
        private void Main_box_MouseDown(object sender, MouseEventArgs e)
        {
            is_rotate_change = true;
            start_mouse_pose = new int[]  {e.X, e.Y};
        }
        private void Main_box_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_rotate_change)
            {
                angle_y -= (float)((((double)(start_mouse_pose[0] - e.X)) * (Math.PI / 3)) / picture_size);
                angle_x -= (float)((((double)(start_mouse_pose[1] - e.Y)) * (Math.PI / 3)) / picture_size);
                start_mouse_pose = new int[] { e.X, e.Y };
                angleY_bar.Value = (int)((180f / (float)Math.PI) * angle_x);
                angleX_bar.Value = (int)((180f / (float)Math.PI) * angle_y);
            }
        }
        private void Main_box_MouseUp(object sender, MouseEventArgs e)
        {
            is_rotate_change = false;
        }
        private void checkBox1_Click(object sender, EventArgs e)
        {
            is_n_change = true;
        }
        private void angleY_bar_ValueChanged(object sender, EventArgs e)
        {
            angle_x = (float)(((float)Math.PI / 180f) * angleY_bar.Value);
            is_rotate_scroll_change = true;
        }
        private void angleX_bar_ValueChanged(object sender, EventArgs e)
        {
            angle_y = (float)(((float)Math.PI / 180f) * angleX_bar.Value);
            is_rotate_scroll_change = true;
        }
        private void Save_but_Click(object sender, EventArgs e)
        {
            if (count_point > 0)
            {
                DialogResult res = saveFileDialog1.ShowDialog();
                try
                {
                    if (res == DialogResult.OK) SaveCSV(saveFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Something wrong with your points");
                }
            }
        }
        public void SaveCSV(string csvPath)
        {
            string data = "X;Y;Z\n";
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                data += dataGridView1.Rows[i].Cells[0].Value.ToString() + ";";
                data += dataGridView1.Rows[i].Cells[1].Value.ToString() + ";";
                data += dataGridView1.Rows[i].Cells[2].Value.ToString();
                data += "\n";
            }
            File.WriteAllText(csvPath, data);
        }
        public void OpenCSV(string csvPath)
        {
            string csvContentStr = File.ReadAllText(csvPath);
            string[] vs = csvContentStr.Split('\n');
            string[] vs2;
            count_point = vs.Length - 2;
            num_point.Text = count_point.ToString();
            generated_point = new float[count_point, 3];
            for (int i = 1; i < count_point + 1; i++)
            {
                vs2 = vs[i].Split(';');
                for (int j = 0; j < 3; j++) generated_point[i-1, j] = float.Parse(vs2[j]);
            }
        }
        private void Open_but_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    OpenCSV(openFileDialog1.FileName);
                    is_start_work = true;
                    angleY_bar.Enabled = true;
                    angleX_bar.Enabled = true;
                    draw_main_img();
                    view_datagreed();
                    timer1.Start();
                    generate_var_but.Enabled = false;
                    Save_but.Enabled = true;
                    Refr_but.Enabled = true;
                }
                else MessageBox.Show("Error, you don't take any file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, your file have incorrect type. You must take .csv.");
                MessageBox.Show(ex.Message);
            }
        }

    }
}