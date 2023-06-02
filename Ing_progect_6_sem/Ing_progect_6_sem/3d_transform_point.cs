using System;
using System.Windows.Forms;

namespace Ing_progect_6_sem
{
    internal class _3d_transform_point
    {
        public float angle_x { get; set; }
        public float angle_y { get; set; }
        public float angle_z { get; set; }
        public float add_yaw { get; set; }
        public float[] Transform_point(float[,] vec)
        {
            float[,] rotate_z = Multiplication(Get_rotation_z(), vec);
            float[,] rotate_x = Multiplication(Get_rotation_x(), rotate_z);
            float[,] rotate_y = Multiplication(Get_rotation_y(), rotate_x);
            return new float[] { rotate_y[0, 0], rotate_y[1, 0], rotate_y[2, 0] };
        }
        private float[,] Get_rotation_x() => new float[,]
        {
            { 1f, 0f, 0f },
            { 0f, (float)Math.Cos(angle_x), -(float)Math.Sin(angle_x) },
            { 0f, (float)Math.Sin(angle_x), (float)Math.Cos(angle_x) },
        };
        private float[,] Get_rotation_y() => new float[,]
        {
            { (float)Math.Cos(angle_y), 0f, -(float)Math.Sin(angle_y) },
            { 0f, 1f, 0f },
            { (float)Math.Sin(angle_y), 0f, (float)Math.Cos(angle_y) },
        };
        private float[,] Get_rotation_z() => new float[,]
        {
            { (float)Math.Cos(angle_z + add_yaw), -(float)Math.Sin(angle_z + add_yaw), 0f },
            { (float)Math.Sin(angle_z + add_yaw),  (float)Math.Cos(angle_z + add_yaw), 0f },
            { 0f, 0f,  1f},
        };
        private float[,] Multiplication(float[,] vec_1, float[,] vec_2)
        {
            float[,] Result = new float[vec_1.GetLength(0), vec_2.GetLength(1)];

            for (int i = 0; i < vec_1.GetLength(0); i++)
                for (int j = 0; j < vec_2.GetLength(1); j++)
                    for (int k = 0; k < vec_2.GetLength(0); k++)
                        Result[i, j] += vec_1[i, k] * vec_2[k, j];
            return Result;
        }
    }   
}
