using System.Drawing;

namespace ScreenSaver
{
    public class Graph
    {
        public Bitmap bmp { get; private set; }
        Graphics graph;
        Color colorBack = Color.White;
        Color colorFore = Color.Blue;
        Pen penFore;
        Pen penBack;

        public Graph(int width, int height)
        {
            bmp = new Bitmap(width, height);
            graph = Graphics.FromImage(bmp);
            InitPens();
        }

        private void InitPens()
        {
            penBack = new Pen(colorBack, (float)2.0);
            penFore = new Pen(colorFore, (float)2.0);
            graph.Clear(colorBack);
        }

        public Graph(int width, int height,
                     Color back, Color fore)
            : this(width,height)
        {
            colorBack = back;
            colorFore = fore;
            InitPens();
        }

        public void DrawCircle(Pixel pixel, Pixel depth)
        {
            graph.DrawEllipse(penFore, pixel.x, pixel.y, depth.x, depth.y);
        }

        public void EraseCircle(Pixel pixel, Pixel depth)
        {
            graph.DrawEllipse(penBack, pixel.x, pixel.y, depth.x, depth.y);
        }

        public void Draw(Figure f)
        {
            DrawCircle(f.GetPixel(), f.GetDepth());
        }

        public void Erase(Figure f)
        {
            EraseCircle(f.GetPixel(), f.GetDepth());
        }

        public void DrawLine(Pen pen, Pixel a, Pixel b)
        {
            graph.DrawLine(pen, a.x, a.y, b.x, b.y);
        }
        public void DrawLine(Pixel a, Pixel b)
        {
            graph.DrawLine(penFore, a.x, a.y, b.x, b.y);
        }

        public void EraseLine(Pixel a, Pixel b)
        {
            graph.DrawEllipse(penBack, a.x, a.y, b.x, b.y);
        }

        public void Draw(Polygone polygone, Pen pen)
        {
            Figure f1 = null;
            foreach (Figure f2 in polygone.list)
            {
                if (f1 != null)
                    DrawLine(pen, f1.GetPixel(), f2.GetPixel());
                f1 = f2;
            }
            if(polygone.list.Count > 2)
            {
                DrawLine(pen,
                    polygone.list[0].GetPixel(),
                    polygone.list[polygone.list.Count - 1].GetPixel());
            }
        }

        public void Draw(Polygone polygone)
        {
            Draw(polygone, penFore);
        }

        public void Erase(Polygone polygone)
        {
            Draw(polygone, penBack);
        }
    }
}
