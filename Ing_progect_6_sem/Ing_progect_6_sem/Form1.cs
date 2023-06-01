﻿using System;
using System.Windows.Forms;
using System.Drawing;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.Aruco;
using Size = OpenCvSharp.Size;
using SharpGL;

namespace Ing_progect_6_sem
{
    public partial class Form1 : Form
    {
        OpenGL opengl1;
        private VideoCapture _capture;
        private Mat _image;
        private string _videoFile = @"C:\Users\ilyah\Desktop\test_video\video_1.mp4";
        float lenght_marker = 0.1f;
        //float lenght_marker = 0.105f;
        Mat objPoints;

        bool is_video = false;
        bool is_cam = false;
        bool is_picture = false;
        ////Mat cam;
        //Mat cam_matrix = new Mat(3, 3, MatType.CV_32FC1, new float[,] { { 526.20408999f, 0.0f, 322.86735703f }, { 0.0f, 700.59290589f, 251.29673666f }, { 0.0f, 0.0f, 1.0f } });
        //// Dist coef
        //Mat dis_coef = new Mat(14, 1, MatType.CV_32FC1, new float[] { 4.02650246e-01f, -2.54183201e+00f, 1.08918704e-03f, 1.31942157e-03f, 5.01528391e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f });
        ////Mat dis_coef = new Mat(5, 1, MatType.CV_32FC1, new float[] { 4.02650246e-01f, -2.54183201e+00f, 1.08918704e-03f, 1.31942157e-03f, 5.01528391e+00f});
        //Mat cam;
        Mat cam_matrix = new Mat(3, 3, MatType.CV_32FC1, new float[,] { { 1.35662728e+03f, 0.0f, 2.91998600e+02f }, { 0.0f, 1.37532524e+03f, 2.25387379e+02f }, { 0.0f, 0.0f, 1.0f } });
        // Dist coef
        Mat dis_coef = new Mat(14, 1, MatType.CV_32FC1, new float[] { -1.32575155e+00f, -7.35188200e+00f, 4.29782934e-02f, 7.66436446e-02f, 5.18928027e+01f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f });

        private delegate void SafeCallDelegate(string text);
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
            _capture.Release();
            timer1.Stop();
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
                            if (id_markers[i] == 100)
                            {
                                Mat rvec = new Mat();
                                Mat tvec = new Mat();
                                Cv2.SolvePnP(objPoints, convert_array(corners_markers[i]), cam_matrix, dis_coef, rvec, tvec);
                                Cv2.DrawFrameAxes(out_flow, cam_matrix, dis_coef, rvec, tvec, 0.3f);
                                debug_1.Text = "x: " + Math.Round(tvec.Get<double>(0), 3).ToString() + "; y: " + Math.Round(tvec.Get<double>(1), 3).ToString() + "; z: " + Math.Round(tvec.Get<double>(2), 3).ToString();
                                //Point2f[] pp = corners_markers[i];
                                //int x_center = (int)(pp[0].X + pp[1].X + pp[2].X + pp[3].X) / 4;
                                //int y_center = (int)(pp[0].Y + pp[1].Y + pp[2].Y + pp[3].Y) / 4;
                                distance_z = tvec.Get<double>(2);
                                distance_x = tvec.Get<double>(0);
                                distance_y = tvec.Get<double>(1);
                                angleX = rvec.Get<double>(0);
                                angleY = rvec.Get<double>(1);
                                angleZ = -rvec.Get<double>(2);
                                debug_2.Text = "x: " + Math.Round((180 / Math.PI) * rvec.Get<double>(0), 3).ToString() + "; y: " + Math.Round((180 / Math.PI) * rvec.Get<double>(1), 3).ToString() + "; z: " + Math.Round((180 / Math.PI) * rvec.Get<double>(2), 3).ToString();
                            }
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

                    // Draw opengl
                    opengl1.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
                    opengl1.MatrixMode(OpenGL.GL_PROJECTION);
                    opengl1.LoadIdentity();
                    opengl1.Perspective(60.0f, openGLControl1.Width / (double)openGLControl1.Height, 0.01, 100.0);

                    short ScaleX = 1;
                    short ScaleY = 1;
                    short ScaleZ = 1;
                    opengl1.Scale(ScaleX, ScaleY, ScaleZ);

                    double CamX = distance_z * Math.Sin(angleY) * Math.Cos(angleX);
                    double CamY = 0; 
                    double CamZ = distance_z * Math.Sin(angleY) * Math.Sin(angleX);

                    //opengl1.LookAt(CamX, CamY, CamZ, 0, 0, 1, 0, 1, 0);
                    opengl1.LookAt(distance_y, distance_x, 0.5f, 0, 0, 0, 0, 0, angleZ);
                    //opengl1.LookAt(distance_y, distance_x, 0.5f, 0, 0, 0, angleX, angleY, angleZ);
                    opengl1.MatrixMode(OpenGL.GL_MODELVIEW);

                    opengl1.Begin(OpenGL.GL_QUADS);
                    opengl1.Color(1f, 1f, 1f);

                    float size = lenght_marker / 2;
                    opengl1.Vertex(-size, size, 0);
                    opengl1.Vertex(size, size, 0);
                    opengl1.Vertex(size, -size, 0);
                    opengl1.Vertex(-size, -size, 0);

                    //opengl1.Vertex(-lenght_marker,  lenght_marker,  lenght_marker);
                    //opengl1.Vertex(lenght_marker,   lenght_marker,  lenght_marker);
                    //opengl1.Vertex(lenght_marker,  -lenght_marker,  lenght_marker);
                    //opengl1.Vertex(-lenght_marker, -lenght_marker,  lenght_marker);

                    //opengl1.Vertex(-lenght_marker,  lenght_marker,  lenght_marker);
                    //opengl1.Vertex(-lenght_marker,  lenght_marker, -lenght_marker);
                    //opengl1.Vertex(-lenght_marker, -lenght_marker,  lenght_marker);
                    //opengl1.Vertex(-lenght_marker, -lenght_marker, -lenght_marker);

                    //opengl1.Vertex(lenght_marker, lenght_marker, lenght_marker);
                    //opengl1.Vertex(lenght_marker, lenght_marker, -lenght_marker);
                    //opengl1.Vertex(lenght_marker, -lenght_marker, lenght_marker);
                    //opengl1.Vertex(lenght_marker, -lenght_marker, -lenght_marker);

                    //opengl1.Vertex(lenght_marker, lenght_marker, lenght_marker);
                    //opengl1.Vertex(lenght_marker, lenght_marker, -lenght_marker);
                    //opengl1.Vertex(-lenght_marker, lenght_marker, lenght_marker);
                    //opengl1.Vertex(-lenght_marker, lenght_marker, -lenght_marker);

                    //opengl1.Vertex(lenght_marker, -lenght_marker, lenght_marker);
                    //opengl1.Vertex(lenght_marker, -lenght_marker, -lenght_marker);
                    //opengl1.Vertex(-lenght_marker, -lenght_marker, lenght_marker);
                    //opengl1.Vertex(-lenght_marker, -lenght_marker, -lenght_marker);

                    opengl1.End();
                }
                else return;
            }
            catch
            {
                return;
            }
        }
        double angleX;
        double angleY;
        double angleZ;
        //double angleY = Math.PI * 1d;
        double distance_z = 2d;
        double distance_x = 0d;
        double distance_y = 0d;
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
            _capture = new VideoCapture(0);
            _capture.Open(0);
        }

        private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {

        }
    }
}

