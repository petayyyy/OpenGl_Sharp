namespace test
{
    internal class _3d_transform_point
    {
        public float angle_x { get; set; }
        public float angle_y { get; set; }
        public int half_picture_size { get; set; }
        public int[] Transform_point(float[,] vec)
        {
            float[,] rotate;
            rotate = Multiplication(Get_rotation_y(), vec);
            rotate = Multiplication(Get_rotation_x(), rotate);
            rotate = Get_center(rotate);
            int x = (int)(rotate[0, 0] * half_picture_size);
            int y = (int)(rotate[1, 0] * half_picture_size);
            return new int[] { x, y };
        }
        public int Calculate_color(float[,] vector, int min_col = 100, int max_col = 255)
        {
            float d_1 = Get_distance(Get_rotation_x(), vector);
            float d_2 = Get_distance(Get_rotation_y(), vector);
            float max_dist = (float)Math.Sqrt(2) * 1f;
            int color = (int)(((Math.Abs((d_1 + d_2) / 2f) * (max_col - min_col)) / max_dist) + min_col);
            if (color > 255) color = 255;
            return color;
        }
        private float Get_distance (float[,] vec_1, float[,] vec_2)
        {
            //a =     y1 * (z2 - z3) + y2 * (z3 - z1) + y3 * (z1 - z2);
            float a = vec_1[0, 1] * (vec_1[1, 2] - vec_1[2, 2]) + vec_1[1, 1] * (vec_1[2, 2] - vec_1[0, 2]) + vec_1[2, 1] * (vec_1[0, 2] - vec_1[1, 2]);
            //b =     z1 * (x2 - x3) + z2 * (x3 - x1) + z3 * (x1 - x2);
            float b = vec_1[0, 2] * (vec_1[1, 0] - vec_1[2, 0]) + vec_1[1, 2] * (vec_1[2, 0] - vec_1[0, 0]) + vec_1[2, 2] * (vec_1[0, 0] - vec_1[1, 0]);
            //c =     x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
            float c = vec_1[0, 0] * (vec_1[1, 1] - vec_1[2, 1]) + vec_1[1, 0] * (vec_1[2, 1] - vec_1[0, 1]) + vec_1[2, 0] * (vec_1[0, 1] - vec_1[1, 1]);
            //d =     -(x1 * (y2 * z3 - y3 * z2) + x2 * (y3 * z1 - y1 * z3) + x3 * (y1 * z2 - y2 * z1));
            float d = -(vec_1[0, 0] * (vec_1[1, 1] * vec_1[2, 2] - vec_1[2, 1] * vec_1[1, 2]) + vec_1[1, 0] * (vec_1[2, 1] * vec_1[0, 2] - vec_1[0, 1] * vec_1[2, 2]) + vec_1[2, 0] * (vec_1[0, 1] * vec_1[1, 2] - vec_1[1, 1] * vec_1[0, 2]));
            // Distance
            float dist = (float)(Math.Abs(a * vec_2[0, 0] + b * vec_2[1, 0] + c * vec_2[2, 0] + d) / (Math.Sqrt(a*a + b*b + c*c)));
            return dist;
        }
        private float[,] Get_center(float[,] rotation)
        {
            float k = 4f;
            float r = 1f / k;
            float[,] rotation_new = rotation;
            rotation_new[0, 0] = rotation_new[0, 0] / (rotation_new[2, 0] * r + 1f);
            rotation_new[1, 0] = rotation_new[1, 0] / (rotation_new[2, 0] * r + 1f);
            rotation_new[2, 0] = rotation_new[2, 0] / (rotation_new[2, 0] * r + 1f);
            return rotation_new;
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
