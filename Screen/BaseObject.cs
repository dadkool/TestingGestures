using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using CGMath;
using System.IO;
using System.Globalization;

namespace Screen
{
    public class BaseObject
    {
        int Width;
        int Height;
        int Offset;
        int number = 0;
        public List<List<Vector2D>> figures = new List<List<Vector2D>>();

        public BaseObject(int width, int height, string path, int off = 0)
        {
            Width = width;
            Height = height;
            Offset = off;

            using (StreamReader reader = new StreamReader(path))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    List<Vector2D> temp = new List<Vector2D>();
                    string[] words = line.Split(';');
                    for (int i = 1; i < words.Length; i++)
                    {
                        string[] vec = words[i].Split(',');
                        temp.Add(new Vector2D(float.Parse(vec[0], CultureInfo.InvariantCulture), float.Parse(vec[1], CultureInfo.InvariantCulture)));
                    }
                    temp = ViewportTransformation(temp);
                    figures.Add(temp);
                }
            }
        }

        public void Draw(Graphics g)
        {
            List<Vector2D> trans = figures[number];

            Pen p = new Pen(Color.Black, 2f);
            //for (int i = 1; i < trans.Count; i++)
            //{
            //    g.DrawLine(p, trans[i - 1].X, trans[i - 1].Y, trans[i].X, trans[i].Y);
            //}

            for (int i = 0; i < trans.Count; i++)
            {
                g.FillEllipse(new SolidBrush(Color.Red), trans[i].X, trans[i].Y, 5, 5);
            }

            p = new Pen(Color.Red, 2f);
            g.FillEllipse(new SolidBrush(Color.Red), trans[0].X, trans[0].Y, 10, 10);
            float cx = (Width / 2) + Offset;
            float cy = Height / 2;
            g.DrawLine(p, -250 + cx, -250 + cy, 250 + cx, -250 + cy);
            g.DrawLine(p, 250 + cx, -250 + cy, 250 + cx, 250 + cy);
            g.DrawLine(p, 250 + cx, 250 + cy, -250 + cx, 250 + cy);
            g.DrawLine(p, -250 + cx, 250 + cy, -250 + cx, -250 + cy);
        }

        public List<Vector2D> ViewportTransformation(List<Vector2D> data)
        {
            List<Vector2D> res = new List<Vector2D>();

            float cx = (Width / 2) + Offset;
            float cy = Height / 2;

            foreach (Vector2D v in data)
            {
                res.Add(new Vector2D(v.X + cx, v.Y + cy));
            }

            return res;
        }

        public void next()
        {
            if(number < figures.Count - 1)
                number++;
        }

        public void previous()
        {
            if(number > 0)
                number--;
        }
    }
}