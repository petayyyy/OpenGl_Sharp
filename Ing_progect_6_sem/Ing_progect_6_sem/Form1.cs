using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Aruco;

namespace Ing_progect_6_sem
{
    public partial class Form1 : Form
    {
        VideoCapture video_capture;
        Mat input_flow = new Mat();
        Mat out_flow = new Mat();
        //Mat cam;
        Mat cam_matrix = new Mat(3, 3, MatType.CV_32FC1, new float[,] { { 1.35662728e+03f, 0.0f, 2.91998600e+02f }, { 0.0f, 1.37532524e+03f, 2.25387379e+02f }, { 0.0f, 0.0f, 1.0f } });
        // Dist coef
        Mat dis_coef = new Mat(14, 1, MatType.CV_32FC1, new float[] { -1.32575155e+00f, -7.35188200e+00f, 4.29782934e-02f, 7.66436446e-02f, 5.18928027e+01f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f, 0.00000000e+00f });
        bool is_video = false;
        bool is_cam = false;
        public Form1()
        {
            InitializeComponent();
            Main_picture.Image = new Bitmap(640, 480);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (video_capture.IsOpened() && (is_cam || is_video))
                    {
                        video_capture.Read(input_flow);
                    }
                }
                catch
                {
                    if (is_video)
                    {
                        Restart_but.Text = "Restart video";
                    }
                }
                Mat work_flow = new Mat();
                out_flow = input_flow.Clone();
                work_flow = input_flow.Resize(new OpenCvSharp.Size(640, 480));
               
                // BGR to GRAY
                Cv2.CvtColor(work_flow, work_flow, ColorConversionCodes.BGR2GRAY);
                //Cv2.CvtColor(input_flow, work_flow, ColorConversionCodes.BGR2GRAY);

                // blur
                Cv2.GaussianBlur(work_flow, work_flow, new OpenCvSharp.Size(33, 33), 0);

                // Parameters foe Aruco
                Dictionary ff = CvAruco.GetPredefinedDictionary(PredefinedDictionaryName.Dict6X6_1000);
                var detectorParameters = new DetectorParameters();
                detectorParameters.CornerRefinementMethod = CornerRefineMethod.Subpix;
                detectorParameters.CornerRefinementWinSize = 9;
                
                // Detect Aruco and draw it
                CvAruco.DetectMarkers(work_flow, ff, out Point2f[][] corners_markers, out int[] id_markers, detectorParameters, out Point2f[][] ref_markers);
                //CvAruco.DrawDetectedMarkers(out_flow, corners_markers, id_markers, Scalar.Crimson);

                if (id_markers.Length > 0)
                {
                    Mat rvecs = new Mat(), tvecs = new Mat(), objPoints = new Mat();
                    // Calculate postion and rotation marker 
                    CvAruco.EstimatePoseSingleMarkers(corners_markers, 0.10f, cam_matrix, dis_coef, rvecs, tvecs, objPoints);
                    for( int i = 0; i < id_markers.Length; i++)
                    {
                        Point2f[] pp = corners_markers[i]; 
                        int x_center = (int)(pp[0].X + pp[1].X + pp[2].X + pp[3].X) / 4;
                        int y_center = (int)(pp[0].Y + pp[1].Y + pp[2].Y + pp[3].Y) / 4;
                        //Cv2.PutText(out_flow, rvecs.ToString(), new OpenCvSharp.Point(x_center, y_center), HersheyFonts.HersheySimplex, 1d, Scalar.Crimson);

                        debug.Text = rvecs.ToString();
                        //MessageBox.Show("");
                    }
                }

                Main_picture.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(out_flow);
                Main_picture.Refresh();
        }
            catch
            {
            }
        }
        private void Open_but_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    if (openFileDialog1.FileName.Contains(".mp4") || openFileDialog1.FileName.Contains(".avi"))
                    {
                        is_video = true;
                        video_capture.Open(openFileDialog1.FileName);
                    }
                    else
                    {
                        is_video = false;
                        input_flow = new Mat(openFileDialog1.FileName);
                        Main_picture.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(input_flow);
                    }
                    timer1.Start();
                    Start_cam_but.Enabled = false;
                }
                else MessageBox.Show("Error, you don't take any file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error, your file have incorrect type. You must take .png, .jpg or .bmp.");
            }
        }
        private void Restart_but_Click(object sender, EventArgs e)
        {
            if (Restart_but.Text == "Restart video")
            {
                video_capture.Open(openFileDialog1.FileName);
                Restart_but.Text = "Refresh";
            }
            else
            {
                timer1.Stop();
                is_cam = false;
                is_video = false;
                Start_cam_but.Enabled = true;
                Open_but.Enabled = true;
                Graphics graphics = Graphics.FromImage(Main_picture.Image);
                graphics.FillRectangle(Brushes.Pink, new Rectangle(0, 0, Main_picture.Image.Width, Main_picture.Image.Height));
                Main_picture.Refresh();
                video_capture.Release();
            }
        }
        private void Start_cam_but_Click(object sender, EventArgs e)
        {
            is_cam = true;
            Open_but.Enabled = false;
            timer1.Start();
            video_capture = new VideoCapture(0);
            video_capture.Open(0);
        }
    }

}



