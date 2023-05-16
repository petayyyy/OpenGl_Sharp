using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class _3d_transform_point
    {
        public float AngleX { get; set; }
        public float AngleY { get; set; }
        public float AngleZ { get; set; }

        public int[] Project(float[,] vector)
        {
            float[,] Rotated = MultiplyVectors(GetRotationMatX(), vector);
            Rotated = MultiplyVectors(GetRotationMatY(), Rotated);
            Rotated = MultiplyVectors(GetRotationMatZ(), Rotated);
            Rotated = ProjectionGetCenter(Rotated);

            int X = (int)(Rotated[0, 0] * 520);
            int Y = (int)(Rotated[1, 0] * 500);
            return new int[] { X, Y };
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

        private float[,] GetProjectionMat() => new float[,]
        {
        { 1f, 0f, 0f },
        { 0f, 1f, 0f }
        };

        private float[,] GetRotationMatX() => new float[,]
        {
        { 1f, 0f, 0f },
        { 0f, (float)Math.Cos(AngleX), (float)-Math.Sin(AngleX) },
        { 0f, (float)Math.Sin(AngleX), (float)Math.Cos(AngleX) },
        };

        private float[,] GetRotationMatY() => new float[,]
        {
        { (float)Math.Cos(AngleY), 0f, (float)-Math.Sin(AngleY) },
        { 0f, 1f, 0f },
        { (float)Math.Sin(AngleY), 0f, (float)Math.Cos(AngleY) },
        };

        private float[,] GetRotationMatZ() => new float[,]
        {
        { (float)Math.Cos(AngleZ), (float)-Math.Sin(AngleZ), 0f },
        { (float)Math.Sin(AngleZ), (float)Math.Cos(AngleZ), 0f },
        { 0f, 0f, 1f }
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
