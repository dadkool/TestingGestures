using System;

namespace CGMath
{
    public class Matrix
    {
        public float [,] Mat = new float[3,3];

        public Matrix() : this(1f, 0f, 0f,
                               0f, 1f, 0f,
                               0f, 0f, 1f)
        { }

        public Matrix(float m11, float m12, float m13,
                      float m21, float m22, float m23,
                      float m31, float m32, float m33)
        {
            Mat[0, 0] = m11; Mat[0, 1] = m12; Mat[0, 2] = m13;
            Mat[1, 0] = m21; Mat[1, 1] = m22; Mat[1, 2] = m23;
            Mat[2, 0] = m31; Mat[2, 1] = m32; Mat[2, 2] = m33;
        }

        public static Vector2D operator *(Matrix m, Vector2D v)
        {
            return new Vector2D((m.Mat[0, 0] * v.X) + (m.Mat[0, 1] * v.Y) + (m.Mat[0, 2] * v.W),
                                (m.Mat[1, 0] * v.X) + (m.Mat[1, 1] * v.Y) + (m.Mat[1, 2] * v.W),
                                1f);
        }
        public static Vector2D operator *(Vector2D v, Matrix m)
        {
            return m*v;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            Matrix res = new Matrix();
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    float sum = 0f;
                    for (int i = 0; i < 3; i++)
                    {
                        sum += m1.Mat[row, i]*m2.Mat[i, col];
                    }
                    res.Mat[row, col] = sum;
                }
            }
            return res;
        }

        public static Vector2D Scale(float scale, Vector2D v)
        {
            return new Matrix(scale,    0,      0,
                              0,        scale,  0,
                              0,        0,      1) * v;
        }

        public static Vector2D NonLinearScale(float scaleX, float scaleY, Vector2D v)
        {
            return new Matrix(scaleX,   0,      0,
                              0,        scaleY, 0,
                              0,        0,      1) * v;
        }

        public static Vector2D Translate(float x, float y, Vector2D v)
        {
            return new Matrix(1, 0,  x,
                              0, 1, -y,
                              0, 0,  1) * v;
        }

        public static Vector2D RotateRadian(float angle, Vector2D v)
        {
            return new Matrix((float)Math.Cos(angle),   (float)-Math.Sin(angle),    0,
                              (float)Math.Sin(angle),   (float) Math.Cos(angle),     0,
                              0,                        0,                          1) * v;
        }
        public static Vector2D RotateDegrees(float angle, Vector2D v)
        {
            return RotateRadian(DegreesToRadians(angle), v);
        }

        private static float RadianToDegree(float angle)
        {
            return angle * (180.0f / (float)Math.PI);
        }
        private static float DegreesToRadians(float angle)
        {
            return ((float)Math.PI / 180) * angle;
        }
    }
}
