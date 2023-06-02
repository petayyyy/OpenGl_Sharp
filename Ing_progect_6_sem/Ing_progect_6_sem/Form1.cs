using System;
using System.Windows.Forms;
using System.Drawing;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.Aruco;
using Size = OpenCvSharp.Size;
using SharpGL;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using SharpGL.Enumerations;
using System.Runtime.InteropServices;

namespace Ing_progect_6_sem
{
    public partial class Form1 : Form
    {
        OpenGL opengl1;
        private _3d_transform_point tr_3D = new _3d_transform_point();
        private VideoCapture _capture;
        private Mat _image;
        float lenght_marker = 0.071f;
        //float lenght_marker = 0.105f;

        Mat objPoints;
        double distance_z = 0.5d;
        double distance_x = 0d;
        double distance_y = 0d;

        float x_pose_drone = 0f;
        float y_pose_drone = 0f;
        float z_pose_drone = 0f;

        bool is_video = false;
        bool is_cam = false;
        bool is_picture = false;
        Bitmap bmcube = new Bitmap(640, 480, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
        ////Mat cam;
        //Mat cam_matrix = new Mat(3, 3, MatType.CV_32FC1, new float[,] { { 526.20408999f, 0.0f, 322.86735703f }, { 0.0f, 700.59290589f, 251.29673666f }, { 0.0f, 0.0f, 1.0f } });
        //// Dist coef
        //Mat dis_coef = new Mat(14, 1, MatType.CV_32FC1, new float[] { 4.02650246e-01f, -2.54183201e+00f, 1.08918704e-03f, 1.31942157e-03f, 5.01528391e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f });
        ////Mat dis_coef = new Mat(5, 1, MatType.CV_32FC1, new float[] { 4.02650246e-01f, -2.54183201e+00f, 1.08918704e-03f, 1.31942157e-03f, 5.01528391e+00f});
        //Mat cam;
        Mat cam_matrix = new Mat(3, 3, MatType.CV_32FC1, new float[,] { { 1.35662728e+03f, 0.0f, 2.91998600e+02f }, { 0.0f, 1.37532524e+03f, 2.25387379e+02f }, { 0.0f, 0.0f, 1.0f } });
        // Dist coef
        Mat dis_coef = new Mat(14, 1, MatType.CV_32FC1, new float[] { -1.32575155e+00f, -7.35188200e+00f, 4.29782934e-02f, 7.66436446e-02f, 5.18928027e+01f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f });
        public Form1()
        {
            InitializeComponent();
            Main_picture.Image = new Bitmap(640, 480);
            Load += Form1_Load;
            Closed += Form1_Closed;
            opengl1 = openGLControl1.OpenGL;
            objPoints = new Mat(4, 1, MatType.CV_32FC3, new float[,] { { -(float)lenght_marker / 2, -(float)lenght_marker / 2, 0 }, { (float)lenght_marker / 2, -(float)lenght_marker / 2, 0 }, { (float)lenght_marker / 2, (float)lenght_marker / 2, 0 }, { -(float)lenght_marker / 2, (float)lenght_marker / 2, 0 } });
        }
        private void Form1_Closed(object sender, EventArgs e)
        {
            try
            {
                if (is_video || is_cam)  _capture.Release();
                timer1.Stop();
            }
            catch { }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _image = new Mat();
            timer1.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    if (openFileDialog1.FileName.Contains(".mp4") || openFileDialog1.FileName.Contains(".avi"))
                    {
                        _capture = new VideoCapture(openFileDialog1.FileName);
                        //_capture = new VideoCapture(_videoFile);
                        is_video = true;
                    }
                    else
                    {
                        _image = new Mat(openFileDialog1.FileName);
                        Main_picture.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(_image);
                        is_picture = true;  
                    }
                }
                else MessageBox.Show("Error, you don't take any file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error, your file have incorrect type. You must take .png, .jpg or .bmp.");
            }
        }
        public Mat convert_array(Point2f[] fff)
        {
            float[,] point = new float[,] { { fff[0].X, fff[0].Y }, { fff[1].X, fff[1].Y }, { fff[2].X, fff[2].Y }, { fff[3].X, fff[3].Y } };
            Mat point_pix = new Mat(4, 2, MatType.CV_32F, point);
            return point_pix;
        }
        public void draw_point_correct(float x, float y, float z, float xx, float yy, float zz)
        {
            float[] ff = tr_3D.Transform_point(new float[,] { { x }, { y }, { z } });
            opengl1.Vertex(ff[0] + xx, ff[1] + yy, ff[2] + zz);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (is_video)
                {
                    _capture.Read(_image);
                    if (_image.Empty())
                    {
                        Restart_but.Text = "Restart video";
                        is_video = false;
                    }
                }
                else if (is_cam && _capture.IsOpened())
                {
                    _capture.Read(_image);
                }
            }
            catch
            {
                if (is_video)
                {
                    Restart_but.Text = "Restart video";
                    is_video = false;
                }
                else if (is_cam)
                {
                    Start_cam_but.Text = "Restart camera";
                    is_cam = false;
                }
            }
            if (is_picture || is_video || is_cam)
            {
                bool is_work = false;
                // Start working with image here => 
                Mat rr = _image.Resize(new Size(640, 480));
                //Mat work_flow = new Mat();
                //Cv2.Undistort(rr, work_flow, cam_matrix, dis_coef, cam_matrix);
                Mat work_flow = rr.Clone();
                Mat out_flow = work_flow.Clone();

                // BGR to GRAY
                Cv2.CvtColor(work_flow, work_flow, ColorConversionCodes.BGR2GRAY);

                // blur
                Cv2.GaussianBlur(work_flow, work_flow, new OpenCvSharp.Size(11, 11), 0);

                // Parameters foe Aruco
                Dictionary ff = CvAruco.GetPredefinedDictionary(PredefinedDictionaryName.Dict6X6_1000);
                var detectorParameters = DetectorParameters.Create();
                detectorParameters.CornerRefinementMethod = CornerRefineMethod.Subpix;
                //detectorParameters.CornerRefinementMethod = CornerRefineMethod.None;
                detectorParameters.CornerRefinementWinSize = 9;

                // Detect Aruco and draw it
                CvAruco.DetectMarkers(work_flow, ff, out Point2f[][] corners_markers, out int[] id_markers, detectorParameters, out Point2f[][] ref_markers);
                CvAruco.DrawDetectedMarkers(out_flow, corners_markers, id_markers, Scalar.Crimson);

                if (id_markers.Length > 0)
                {
                    for (int i = 0; i < id_markers.Length; i++)
                    {
                        if (id_markers[i] == 100)
                        {
                            is_work = true;
                            Mat rvec = new Mat();
                            Mat tvec = new Mat();
                            Cv2.SolvePnP(objPoints, convert_array(corners_markers[i]), cam_matrix, dis_coef, rvec, tvec);
                            //Cv2.DrawFrameAxes(out_flow, cam_matrix, dis_coef, rvec, tvec, 0.3f);
                            distance_z = tvec.Get<double>(2);
                            distance_x = tvec.Get<double>(0);
                            distance_y = -tvec.Get<double>(1);
                            tr_3D.angle_x = (float)rvec.Get<double>(0);
                            tr_3D.angle_y = (float)rvec.Get<double>(1);
                            tr_3D.angle_z = (float)-rvec.Get<double>(2);
                            debug_1.Text = "Marker pose is x: " + Math.Round(tvec.Get<double>(0), 3).ToString() + "; y: " + Math.Round(tvec.Get<double>(1), 3).ToString() + "; z: " + Math.Round(tvec.Get<double>(2), 3).ToString() + "; roll: " + Math.Round((180 / Math.PI) * rvec.Get<double>(0), 3).ToString() + "; pitch: " + Math.Round((180 / Math.PI) * rvec.Get<double>(1), 3).ToString() + "; yaw: " + Math.Round((180 / Math.PI) * rvec.Get<double>(2), 3).ToString();

                            // Draw opengl
                            Mat rre = out_flow.Resize(new Size(480, 390));
                            Bitmap bmcam = BitmapConverter.ToBitmap(rre);
                            opengl1.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
                            opengl1.MatrixMode(OpenGL.GL_PROJECTION);
                            opengl1.LoadIdentity();
                            //opengl1.Perspective(50f, (double)bmcam.Width / (double)bmcam.Height, 0.01, 100.0);
                            opengl1.Perspective(60f, (double)(640d / 480d), 0.01, 100.0);
                            //opengl1.Scale(1, 1, 1);
                            opengl1.LookAt(0, 0, distance_z / 2d, 0, 0, 0, 0, 1, 0);
                            opengl1.MatrixMode(OpenGL.GL_MODELVIEW);
                            opengl1.Begin(OpenGL.GL_QUADS);

                            float x_c = (float)distance_x + x_pose_drone;
                            float y_c = (float)distance_y + y_pose_drone;
                            float z_c = z_pose_drone;
                            float size = lenght_marker / 2f;
                            float size_2 = size / 3f;

                            // Front
                            //opengl1.Color(1f, 1f, 1f);
                            opengl1.Color(1f, 0, 0);
                            draw_point_correct(-size, size, size_2, x_c, y_c, z_c);
                            draw_point_correct(size, size, size_2, x_c, y_c, z_c);
                            draw_point_correct(size, -size, size_2, x_c, y_c, z_c);
                            draw_point_correct(-size, -size, size_2, x_c, y_c, z_c);

                            // Backford
                            //opengl1.Color(1f / 4f, 1f / 4f, 1f / 4f);
                            opengl1.Color(1f / 4f, 0f, 0f);
                            draw_point_correct(-size, size, -size_2, x_c, y_c, z_c);
                            draw_point_correct(size, size, -size_2, x_c, y_c, z_c);
                            draw_point_correct(size, -size, -size_2, x_c, y_c, z_c);
                            draw_point_correct(-size, -size, -size_2, x_c, y_c, z_c);

                            // Right
                            //opengl1.Color(1f / 3f, 1f / 3f, 1f / 3f);
                            opengl1.Color(1f / 3f, 0f, 0f);
                            draw_point_correct(size, size, size_2, x_c, y_c, z_c);
                            draw_point_correct(size, size, -size_2, x_c, y_c, z_c);
                            draw_point_correct(size, -size, -size_2, x_c, y_c, z_c);
                            draw_point_correct(size, -size, size_2, x_c, y_c, z_c);

                            // Left
                            //opengl1.Color(1f / 3f, 1f / 3f, 1f / 3f);
                            opengl1.Color(1f / 3f, 0f, 0f);
                            draw_point_correct(-size, size, size_2, x_c, y_c, z_c);
                            draw_point_correct(-size, size, -size_2, x_c, y_c, z_c);
                            draw_point_correct(-size, -size, -size_2, x_c, y_c, z_c);
                            draw_point_correct(-size, -size, size_2, x_c, y_c, z_c);

                            // Up
                            //opengl1.Color(1f / 2f, 1f / 2f, 1f / 2f);
                            opengl1.Color(1f / 2f, 0f, 0f);
                            draw_point_correct(-size, size, size_2, x_c, y_c, z_c);
                            draw_point_correct(size, size, size_2, x_c, y_c, z_c);
                            draw_point_correct(size, size, -size_2, x_c, y_c, z_c);
                            draw_point_correct(-size, size, -size_2, x_c, y_c, z_c);

                            // Down
                            //opengl1.Color(1f / 2f, 1f / 2f, 1f / 2f);
                            opengl1.Color(1f / 2f, 0f, 0f);
                            draw_point_correct(-size, -size, size_2, x_c, y_c, z_c);
                            draw_point_correct(size, -size, size_2, x_c, y_c, z_c);
                            draw_point_correct(size, -size, -size_2, x_c, y_c, z_c);
                            draw_point_correct(-size, -size, -size_2, x_c, y_c, z_c);

                            opengl1.End();
                            opengl1.Flush();
                            
                            Rectangle rec = new Rectangle(0, 0, 480, 390);
                            openGLControl1.DrawToBitmap(bmcube, rec);
                            bmcube.MakeTransparent(Color.Black);
                            var graphics = Graphics.FromImage(bmcam);
                            graphics.CompositingMode = CompositingMode.SourceOver;
                            if (bmcube != null)
                            {
                                bmcube.MakeTransparent(Color.Black);
                                graphics.DrawImage(bmcube, 0, 0);
                            }
                            Main_picture.Image = bmcam;
                            Main_picture.Refresh();
                            //debug_2.Text = opengl1.RenderContextProvider.Width.ToString() + opengl1.RenderContextProvider.Height.ToString();
                            debug_2.Text = "Drone pose is x: " + Math.Round(x_c, 3).ToString() + "; y: " + Math.Round(y_c, 3).ToString() + "; z: " + Math.Round(z_c, 3).ToString() + "; yaw: " + Math.Round(tr_3D.add_yaw, 3).ToString();
                        }
                    }
                }

                if (!is_work)
                {
                    //// Draw image on picturebox
                    Mat rre = out_flow.Resize(new Size(480, 390));
                    Main_picture.Image = BitmapConverter.ToBitmap(rre);
                    Main_picture.Refresh();
                }
            }
            else return;
        }
        private void Restart_but_Click(object sender, EventArgs e)
        {
            if (Restart_but.Text == "Restart video")
            {
                _capture = new VideoCapture(openFileDialog1.FileName);
                Restart_but.Text = "Refresh";
            }
            else
            {
                is_cam = false;
                is_video = false;
                is_picture = false; 
                Start_cam_but.Enabled = true;
                Open_but.Enabled = true;
                z_pose_drone = 0f;
                x_pose_drone = 0f;
                y_pose_drone = 0f;
                distance_z = 0f;
                distance_y = 0f;
                distance_z = 0.5f;
                takeoff.Text = "TakeOFF";
                Graphics graphics = Graphics.FromImage(Main_picture.Image);
                graphics.FillRectangle(Brushes.White, new Rectangle(0, 0, Main_picture.Image.Width, Main_picture.Image.Height));
                Main_picture.Refresh();
                try
                {
                    _capture.Release();
                }
                catch { }
            }
        }
        private void Start_cam_but_Click(object sender, EventArgs e)
        {
            is_cam = true;
            Open_but.Enabled = false;
            _capture = new VideoCapture(1);
            _capture.Open(1);
            //_capture = new VideoCapture(0);
            //_capture.Open(0);
        }
        private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (takeoff.Text == "Land") 
            { 
                takeoff.Text = "TakeOFF";
                z_pose_drone = 0f;
            }
            else
            {
                takeoff.Text = "Land";
                z_pose_drone = (float)altitude.Value / 100f;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            x_pose_drone -= (float)step_flight.Value / 100f;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            x_pose_drone += (float)step_flight.Value / 100f;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            y_pose_drone += (float)step_flight.Value / 100f;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            y_pose_drone -= (float)step_flight.Value / 100f;
        }
        private void altitude_ValueChanged(object sender, EventArgs e)
        {
            if (z_pose_drone > 0f) z_pose_drone = (float)altitude.Value / 100f;
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            tr_3D.add_yaw -= (float)(Math.PI * (double)angle.Value) / 180.0f;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            tr_3D.add_yaw += (float)(Math.PI * (double)angle.Value) / 180.0f;
        }
    }
}

