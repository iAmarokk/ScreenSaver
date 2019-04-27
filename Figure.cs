using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSaver
{
    public struct Pixel
    {
        public int x;
        public int y;
        public Pixel(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Figure
    {
        protected Pixel pixel;
        protected Pixel step;
        protected Pixel depth;

        static Pixel min;
        static Pixel max;

        public Pixel GetPixel()
        {
            return pixel;
        }

        public Pixel GetStep()
        {
            return step;
        }

        public Pixel GetDepth()
        {
            return depth;
        }

        public static void InitMinMax(int minx, int miny, int maxx, int maxy)
        {
            min = new Pixel(minx, miny);
            max = new Pixel(maxx, maxy);
        }
        public static void InitMinMax(Pixel _min, Pixel _max)
        {
            min = _min;
            max = _max;
        }
        public Figure(int x, int y)
        {
            pixel = new Pixel(x, y);
            step = new Pixel(0, 0);
        }

        public Figure(int x, int y, int sx, int sy)
            : this (x,y)
        {
            step = new Pixel(sx, sy);
        }

        public Figure(Pixel pixel)
        {
            this.pixel = pixel;
            this.step = new Pixel(0,0);
        }

        public Figure(Pixel pixel, Pixel step)
            : this (pixel)
        {
            this.step = step;
        }

        public void SetDepth(int dx, int dy)
        {
            depth = new Pixel(dx, dy);
        }
        public void SetDepth(Pixel depth)
        {
            this.depth = depth;
        }

        public void Move()
        {
            int maxdx = max.x - depth.x;
            int maxdy = max.y - depth.y;
            pixel.x += step.x;
            pixel.y += step.y;
            if (pixel.x < min.x)
            {
                step.x = -step.x;
                pixel.x = min.x - (pixel.x - min.x);
            }
            if (pixel.x > maxdx)
            {
                step.x = -step.x;
                pixel.x = (maxdx - (pixel.x - maxdx));
            }
            if (pixel.y < min.y)
            {
                step.y = -step.y;
                pixel.y = min.y - (pixel.y - min.y);
            }
            if (pixel.y > maxdy)
            {
                step.y = -step.y;
                pixel.y = maxdy - (pixel.y - maxdy);
            }
        }
    }
}
