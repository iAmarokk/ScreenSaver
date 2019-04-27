using System;
using System.Windows.Forms;

namespace ScreenSaver
{

    public partial class Form1 : Form
    {
        Graph graph;
        Polygone p;

        public Form1()
        {
            InitializeComponent();
            graph = new Graph(picture.Width, picture.Height);
            InitFigure();
            timer.Enabled = true;
        }

        private void InitFigure()
        {
            Figure.InitMinMax(0,0, graph.bmp.Width, graph.bmp.Height);
            p = new Polygone(new Figure(20, 20, 3, 2),
                             new Figure(80, 20, 3, 2));
            p.AddFigure(new Figure(80, 80, 4, 4));
            p.AddFigure(new Figure(20, 80, 4, 4));
            p.AddFigure(new Figure(50, 10, 4, 4));
            p.AddFigure(new Figure(50, 100, 4, 4));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            graph.Erase(p);
            p.Move();
            graph.Draw(p);
            picture.Image = graph.bmp;
        }
    }
}
