using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class _3d_transform_point
    {
        public float angle_x { get; set; }
        public float angle_y { get; set; }
        public int half_picture_size { get; set; }
        public int[] Project(float[,] vector)
        {
            float[,] Rotated;
            Rotated = MultiplyVectors(GetRotationMatY(), vector);
            Rotated = MultiplyVectors(GetRotationMatX(), Rotated);
            Rotated = ProjectionGetCenter(Rotated);
            int X = (int)(Rotated[0, 0] * half_picture_size);
            int Y = (int)(Rotated[1, 0] * half_picture_size);
            return new int[] { X, Y };
        }
        public int Calculate_color(float[,] vector, int min_col = 100, int max_col = 255)
        {
            float d_1 = Get_distance(GetRotationMatX(), vector);
            float d_2 = Get_distance(GetRotationMatY(), vector);
            float max_dist = (float)Math.Sqrt(2) * 1f;
            int color = (int)(((Math.Abs((d_1 + d_2) / 2f) * (max_col - min_col)) / max_dist) + min_col);
            if (color > 255) color = 255;
            return color;
        }
        private float Get_distance (float[,] vec1, float[,] vec2)
        {
            //a =     y1 * (z2 - z3) + y2 * (z3 - z1) + y3 * (z1 - z2);
            float a = vec1[0, 1] * (vec1[1, 2] - vec1[2, 2]) + vec1[1, 1] * (vec1[2, 2] - vec1[0, 2]) + vec1[2, 1] * (vec1[0, 2] - vec1[1, 2]);
            //b =     z1 * (x2 - x3) + z2 * (x3 - x1) + z3 * (x1 - x2);
            float b = vec1[0, 2] * (vec1[1, 0] - vec1[2, 0]) + vec1[1, 2] * (vec1[2, 0] - vec1[0, 0]) + vec1[2, 2] * (vec1[0, 0] - vec1[1, 0]);
            //c =     x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
            float c = vec1[0, 0] * (vec1[1, 1] - vec1[2, 1]) + vec1[1, 0] * (vec1[2, 1] - vec1[0, 1]) + vec1[2, 0] * (vec1[0, 1] - vec1[1, 1]);
            //d =     -(x1 * (y2 * z3 - y3 * z2) + x2 * (y3 * z1 - y1 * z3) + x3 * (y1 * z2 - y2 * z1));
            float d = -(vec1[0, 0] * (vec1[1, 1] * vec1[2, 2] - vec1[2, 1] * vec1[1, 2]) + vec1[1, 0] * (vec1[2, 1] * vec1[0, 2] - vec1[0, 1] * vec1[2, 2]) + vec1[2, 0] * (vec1[0, 1] * vec1[1, 2] - vec1[1, 1] * vec1[0, 2]));
            // Distance
            float dist = (float)(Math.Abs(a * vec2[0, 0] + b * vec2[1, 0] + c * vec2[2, 0] + d) / (Math.Sqrt(a*a + b*b + c*c)));
            return dist;
        }
        private float[,] ProjectionGetCenter(float[,] rot)
        {
            float k = 4f;
            float r = 1f / k;
            float[,] newRot = rot;
            newRot[0, 0] = newRot[0, 0] / (newRot[2, 0] * r + 1f);
            newRot[1, 0] = newRot[1, 0] / (newRot[2, 0] * r + 1f);
            newRot[2, 0] = newRot[2, 0] / (newRot[2, 0] * r + 1f);
            return newRot;
        }
        private float[,] GetRotationMatX() => new float[,]
        {
        { 1f, 0f, 0f },
        { 0f, (float)Math.Cos(angle_x), -(float)Math.Sin(angle_x) },
        { 0f, (float)Math.Sin(angle_x), (float)Math.Cos(angle_x) },
        };
        private float[,] GetRotationMatY() => new float[,]
        {
        { (float)Math.Cos(angle_y), 0f, -(float)Math.Sin(angle_y) },
        { 0f, 1f, 0f },
        { (float)Math.Sin(angle_y), 0f, (float)Math.Cos(angle_y) },
        };
        private float[,] MultiplyVectors(float[,] vec1, float[,] vec2)
        {
            float[,] Result = new float[vec1.GetLength(0), vec2.GetLength(1)];

            for (int i = 0; i < vec1.GetLength(0); i++)
                for (int j = 0; j < vec2.GetLength(1); j++)
                    for (int k = 0; k < vec2.GetLength(0); k++)
                        Result[i, j] += vec1[i, k] * vec2[k, j];
            return Result;
        }

    }
}
