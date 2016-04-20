namespace CGMath
{
    public class Vector2D
    {
        public float X, Y, W;

        public Vector2D():this(0f, 0f) { }

        public Vector2D(float x, float y, float w = 1f)
        {
            X = x;
            Y = y;
            W = w;
        }

        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X + v2.X, v1.Y + v2.Y, 1f);
        }

        public static Vector2D operator -(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X - v2.X, v1.Y - v2.Y, 1f);
        }
    }
}

