using System.Drawing;

namespace Screen
{
    public class Grid
    {
        int width;
        int height;
        int spacing;

        public Grid(int width, int height, int spacing = 10)
        {
            this.width = width;
            this.height = height;
            this.spacing = spacing;
        }

        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Gray, 1f);

            for (int i = 0; i <= height; i += spacing)
            {
                g.DrawLine(p, 0, i, width, i);
                g.DrawLine(p, 700, i, width + 700, i);
                //g.DrawString((i-(height/2)).ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), 5, i);
            } 
            for (int i = 0; i <= width; i += spacing)
            {
                g.DrawLine(p, i, 0, i, height);
                g.DrawLine(p, i + 700, 0, i + 700, height);
            }
        }
    }
}