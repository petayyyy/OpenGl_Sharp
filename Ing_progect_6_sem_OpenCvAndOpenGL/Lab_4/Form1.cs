using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SharpGL;
using System.Runtime.InteropServices;
using SharpGL.SceneGraph.Assets;
using System.IO;
using DynamicArrayLibrary;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Threading.Tasks;

using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.Aruco;
using Size = OpenCvSharp.Size;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        private bool ROTATING;
        bool is_rotate_change = false;
        private int START_X;
        private int START_Y;
        private double PREV_EQUATOR;
        private double PREV_MERIDIAN;
        double angleX;
        double angleY = Math.PI * 1.5d;
        double distance_z = 40d;
        int[] start_mouse_pose;
        int half_picture_size = 500;

        private int[,] Z_HEIGHTS;
        private int[,] Z_VALUES;

        private const string RIGHT_PATH = "Right.jpg";
        private const string FRONT_PATH = "Front.jpg";
        private const string TOP_PATH = "Top.jpg";
        private const string BOTTOM_PATH = "Bottom.jpg";
        private const string LEFT_PATH = "Left.jpg";
        private const string BACK_PATH = "Back.jpg";

        OpenGL opengl1;

        private VideoCapture _capture;
        private Mat _image;
        private string _videoFile = @"C:\Users\ilyah\Desktop\test_video\video_1.mp4";
        float lenght_marker = 0.105f;
        Mat objPoints;

        bool is_video = false;
        bool is_cam = false;
        bool is_picture = false;
        //Mat cam;
        Mat cam_matrix = new Mat(3, 3, MatType.CV_32FC1, new float[,] { { 526.20408999f, 0.0f, 322.86735703f }, { 0.0f, 700.59290589f, 251.29673666f }, { 0.0f, 0.0f, 1.0f } });
        // Dist coef
        Mat dis_coef = new Mat(14, 1, MatType.CV_32FC1, new float[] { 4.02650246e-01f, -2.54183201e+00f, 1.08918704e-03f, 1.31942157e-03f, 5.01528391e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f });
        //Mat dis_coef = new Mat(5, 1, MatType.CV_32FC1, new float[] { 4.02650246e-01f, -2.54183201e+00f, 1.08918704e-03f, 1.31942157e-03f, 5.01528391e+00f});


        public Form1()
        {
            InitializeComponent();
            DataControl.MouseWheel += DataControl_MouseWheel;
            opengl1 = DataControl.OpenGL;
            objPoints = new Mat(4, 1, MatType.CV_32FC3, new float[,] { { -(float)lenght_marker / 2, -(float)lenght_marker / 2, 0 }, { (float)lenght_marker / 2, -(float)lenght_marker / 2, 0 }, { (float)lenght_marker / 2, (float)lenght_marker / 2, 0 }, { -(float)lenght_marker / 2, (float)lenght_marker / 2, 0 } });

        }
        private Mat GetScreenshot(OpenGLControl control)
        {
            OpenGL opengl1 = control.OpenGL;

            int h = control.Height;
            int w = control.Width;
            byte[] Pixels = new byte[4 * w * h];
            opengl1.ReadPixels(0, 0, w, h, OpenGL.GL_BGRA, OpenGL.GL_UNSIGNED_BYTE, Pixels);

            Mat Screenshot = new Mat(h, w, MatType.CV_8UC4);
            Marshal.Copy(Pixels, 0, Screenshot.Data, 4 * w * h);
            Cv2.Flip(Screenshot, Screenshot, FlipMode.X);

            return Screenshot;
        }
        private async void DrawEverything()
        {
            /*
            try
            { 
                
                opengl1.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
                opengl1.MatrixMode(OpenGL.GL_PROJECTION);
                opengl1.LoadIdentity();
                opengl1.Perspective(60.0f, DataControl.Width / (double)DataControl.Height, 0.01, 100.0);

                short ScaleX = 1;
                short ScaleY = 1;
                short ScaleZ = 1;
                opengl1.Scale(ScaleX, ScaleY, ScaleZ);

                double CamX = distance_z * Math.Sin(angleY) * Math.Cos(angleX);
                double CamY = distance_z * Math.Cos(angleY);
                double CamZ = distance_z * Math.Sin(angleY) * Math.Sin(angleX);

                opengl1.LookAt(CamX, CamY, CamZ, 0, 0, 0, 0, 1, 0);
                opengl1.MatrixMode(OpenGL.GL_MODELVIEW);

                const float shift = 5.0f;
                const float size = 10.0f;
                float qx = size / -2.0f;
                float qy = size / -2.0f;
                float qz = size / -2.0f;

                opengl1.Color(1.0f, 1.0f, 1.0f);


                // Задание 1
                if (HideCubeCheckBox.Checked)
                {
                    if (PACKAGES == null) return;
                    // Куб
                    await DrawCube(size);

                    // Задание 4
                    await ThreeParamsDependency();
                }

                opengl1.Color(1.0f, 1.0f, 1.0f);
                opengl1.Enable(OpenGL.GL_TEXTURE_2D);

                //------------------------------------------------------------------Правая поверхность
                Texture RightTexture;

                if (File.Exists(RIGHT_PATH))
                {
                    RightTexture = new Texture();
                    RightTexture.Create(opengl1, RIGHT_PATH);
                    RightTexture.Bind(opengl1);
                }

                opengl1.Begin(OpenGL.GL_QUADS);
                if (HideRightPlaneCheckBox.Checked)
                {
                    await DrawRightPanel(qx, qy, qz, size, shift);
                }
                opengl1.End();

                //------------------------------------------------------------------Передняя поверхность
                Texture FrontTexture;

                if (File.Exists(FRONT_PATH))
                {
                    FrontTexture = new Texture();
                    FrontTexture.Create(opengl1, FRONT_PATH);
                    FrontTexture.Bind(opengl1);
                }

                opengl1.Begin(OpenGL.GL_QUADS);
                if (HideFrontPlaneCheckBox.Checked)
                {
                    await DrawFrontPanel(qx, qy, qz, size, shift);
                }
                opengl1.End();

                //------------------------------------------------------------------Верхняя поверхность
                Texture TopTexture;

                if (File.Exists(TOP_PATH))
                {
                    TopTexture = new Texture();
                    TopTexture.Create(opengl1, TOP_PATH);
                    TopTexture.Bind(opengl1);
                }

                opengl1.Begin(OpenGL.GL_QUADS);
                if (HideTopPlaneCheckBox.Checked)
                {
                    await DrawTopPanel(qx, qy, qz, size, shift);
                }
                opengl1.End();
                //------------------------------------------------------------------Левая поверхность
                Texture LeftTexture;

                if (File.Exists(LEFT_PATH))
                {
                    LeftTexture = new Texture();
                    LeftTexture.Create(opengl1, LEFT_PATH);
                    LeftTexture.Bind(opengl1);
                }

                opengl1.Begin(OpenGL.GL_QUADS);
                if (HideLeftPlaneCheckBox.Checked)
                    await DrawLeftPanel(qx, qy, qz, size, shift);

                opengl1.End();

                //------------------------------------------------------------------Задняя поверхность
                Texture BackTexture;

                if (File.Exists(BACK_PATH))
                {
                    BackTexture = new Texture();
                    BackTexture.Create(opengl1, BACK_PATH);
                    BackTexture.Bind(opengl1);
                }

                opengl1.Begin(OpenGL.GL_QUADS);
                if (HideBackPlaneCheckBox.Checked)
                {
                    await DrawBackPanel(qx, qy, qz, size, shift);
                }
                opengl1.End();
                //------------------------------------------------------------------Нижняя поверхность
                Texture BottomTexture;

                if (File.Exists(BOTTOM_PATH))
                {
                    BottomTexture = new Texture();
                    BottomTexture.Create(opengl1, BOTTOM_PATH);
                    BottomTexture.Bind(opengl1);
                }

                opengl1.Begin(OpenGL.GL_QUADS);
                if (HideBottomPlaneCheckBox.Checked)
                {
                    await DrawBottomPanel(qx, qy, qz, size, shift);
                }
                opengl1.End();

                opengl1.Flush();
            }
            catch { }
                */
        }

        private void LoadCANFileButton_Click(object sender, EventArgs e)
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

        private void GetScreenshotButton_Click(object sender, EventArgs e)
        {
            if (opengl1 == null) return;
            DialogResult res = saveFileDialog1.ShowDialog();
            try
            {
                if (res == DialogResult.OK)
                {
                    Mat Screenshot = GetScreenshot(DataControl);
                    Screenshot.SaveImage(saveFileDialog1.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Something wrong with your picture");
            }
        }

        private void DataControl_MouseDown(object sender, MouseEventArgs e)
        {
            is_rotate_change = true;
            start_mouse_pose = new int[] { e.X, e.Y };
        }

        private async void DataControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_rotate_change)
            {
                angleX -= (float)((((double)(start_mouse_pose[0] - e.X)) * (Math.PI / 3)) / half_picture_size);
                angleY -= (float)((((double)(start_mouse_pose[1] - e.Y)) * (Math.PI / 6)) / half_picture_size);

                start_mouse_pose = new int[] { e.X, e.Y };
                try
                {
                    angleX_bar.Value = check_angle((int)((180f / (float)Math.PI) * angleX));
                    angleY_bar.Value = check_angle_y((int)((90f / (float)Math.PI) * angleY));
                }
                catch { }
                //debug.Text = "Y angle is:" + Math.Round(angleY, 2).ToString() + " X angle is:" + Math.Round(angleX, 2).ToString();
                await Task.Delay(1);
                //DrawEverything();
            }
        }
        public int check_angle(int angle)
        {
            if (angle < -180) return -180;
            else if (angle > 180) return 180;
            return angle;
        }
        public int check_angle_y(int angle)
        {
            if (angle < 0) return 0;
            else if (angle > 180) return 180;
            return angle;
        }
        private void DataControl_MouseUp(object sender, MouseEventArgs e)
        {
            is_rotate_change = false;
        }

        private async void DataControl_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
                distance_z++;
            else
                distance_z--;
            await Task.Delay(1);
            //DrawEverything();
        }

        private void CheckBoxes_CheckChanged(object sender, EventArgs e) => DrawEverything();

        private async void ComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DrawEverything();
        }

        private void angleY_bar_ValueChanged(object sender, EventArgs e)
        {
            if (!is_rotate_change)
            {
                angleY = (float)(((float)Math.PI / 180f) * angleY_bar.Value) + Math.PI;
                //DrawEverything();
            }
        }

        private void angleX_bar_ValueChanged(object sender, EventArgs e)
        {
            if (!is_rotate_change)
            {
                angleX = (float)(((float)Math.PI / 180f) * angleX_bar.Value);
                //DrawEverything();
            }
        }

        private void sliding_ValueChanged(object sender, EventArgs e)
        {
            //DrawEverything();
        }

        private void HideLeftPlaneCheckBox_Click(object sender, EventArgs e)
        {
            //DrawEverything();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (is_video)
                    {
                        _capture.Read(_image);
                        if (_image.Empty())
                        {
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
                        is_video = false;
                    }
                    else if (is_cam)
                    {
                        is_cam = false;
                    }
                }
                if (is_picture || is_video || is_cam)
                {
                    // Start working with image here => 

                    Mat rr = _image.Resize(new Size(640, 480));
                    Mat work_flow = new Mat();
                    Cv2.Undistort(rr, work_flow, cam_matrix, dis_coef, cam_matrix);
                    Mat out_flow = work_flow.Clone();

                    // BGR to GRAY
                    Cv2.CvtColor(work_flow, work_flow, ColorConversionCodes.BGR2GRAY);
                    //Cv2.CvtColor(input_flow, work_flow, ColorConversionCodes.BGR2GRAY);

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
                            Mat rvec = new Mat();
                            Mat tvec = new Mat();
                            Cv2.SolvePnP(objPoints, convert_array(corners_markers[i]), cam_matrix, dis_coef, rvec, tvec);
                            Cv2.DrawFrameAxes(out_flow, cam_matrix, dis_coef, rvec, tvec, 0.3f);
                            Point2f[] pp = corners_markers[i];
                            int x_center = (int)(pp[0].X + pp[1].X + pp[2].X + pp[3].X) / 4;
                            int y_center = (int)(pp[0].Y + pp[1].Y + pp[2].Y + pp[3].Y) / 4;
                            //Cv2.PutText(out_flow, "*1", new OpenCvSharp.Point(pp[0].X, pp[0].Y), HersheyFonts.HersheySimplex, 0.5d, Scalar.Red);
                            //Cv2.PutText(out_flow, "*2", new OpenCvSharp.Point(pp[1].X, pp[1].Y), HersheyFonts.HersheySimplex, 0.5d, Scalar.Red);
                            //Cv2.PutText(out_flow, "*3", new OpenCvSharp.Point(pp[2].X, pp[2].Y), HersheyFonts.HersheySimplex, 0.5d, Scalar.Red);
                            //Cv2.PutText(out_flow, "*4", new OpenCvSharp.Point(pp[3].X, pp[3].Y), HersheyFonts.HersheySimplex, 0.5d, Scalar.Red);

                            //Cv2.PutText(out_flow, Math.Round(tvec.Get<double>(0), 3).ToString(), new OpenCvSharp.Point(x_center, y_center), HersheyFonts.HersheySimplex, 0.5d, Scalar.Red);
                            //Cv2.PutText(out_flow, Math.Round(tvec.Get<double>(1), 3).ToString(), new OpenCvSharp.Point(x_center, y_center + 25), HersheyFonts.HersheySimplex, 0.5d, Scalar.Green);
                            //Cv2.PutText(out_flow, Math.Round(tvec.Get<double>(2), 3).ToString(), new OpenCvSharp.Point(x_center, y_center + 50), HersheyFonts.HersheySimplex, 0.5d, Scalar.Blue);
                        }
                    }

                    Main_picture.Image = BitmapConverter.ToBitmap(out_flow);
                    Main_picture.Refresh();
                }
                else return;
            }
            catch
            {
                return;
            }
        }
        public Mat convert_array(Point2f[] fff)
        {
            float[,] point = new float[,] { { fff[0].X, fff[0].Y }, { fff[1].X, fff[1].Y }, { fff[2].X, fff[2].Y }, { fff[3].X, fff[3].Y } };
            Mat point_pix = new Mat(4, 2, MatType.CV_32F, point);
            return point_pix;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
