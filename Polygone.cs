using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSaver
{
    public class Polygone
    {
        public List<Figure> list { get; private set; }

        public Polygone()
        {
            list = new List<Figure>();
        }

        public Polygone(Figure f1, Figure f2)
            : this()
        {
            AddFigure(f1);
            AddFigure(f2);
        }

        public void Move()
        {
            foreach (Figure f in list)
                f.Move();
        }

        public void AddFigure(Figure f)
        {
            list.Add(f);
        }
    }
}
