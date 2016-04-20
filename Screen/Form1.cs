using System;
using System.Drawing;
using System.Windows.Forms;

namespace Screen
{
    public sealed partial class Screen : Form
    {
        private const int width = 1400;
        private const int height = 700;

        Axis axis = new Axis(650, 650);
        Grid grid = new Grid(650, 650, 50);

        BaseObject p = new BaseObject(650, 650, "C:/Users/Daddy Kool/Desktop/School/Jaar 3/Project Games programming/SoLongAndThanksForAllTheFish/Wizards/Assets/Resources/Gestures128.txt");

        public Screen()
        {
            InitializeComponent();
            Width = width;
            Height = height;

            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            grid.Draw(g);

            axis.Draw(g);

            p.Draw(g);
        }

        private void scaleUp_Click(object sender, EventArgs e)
        {
            p.next();
            Refresh();
        }

        private void scaleDown_Click(object sender, EventArgs e)
        {
            p.previous();
            Refresh();
        }
    }
}
