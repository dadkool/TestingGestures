using System.Drawing;

namespace Screen
{
    public class Axis
    {
        int width;
        int height;

        public Axis(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Green, 2f);

            g.DrawLine(p, 0, height/2, width, height/2);
            g.DrawLine(p, width/2, 0, width/2, height);
            g.DrawLine(p, 700, height / 2, width + 700, height / 2);
            g.DrawLine(p, (width / 2) + 700, 0, (width / 2) + 700, height);
        }
    }
}