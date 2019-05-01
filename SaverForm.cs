using Microsoft.Win32;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScreenSaver
{

    public partial class SaverForm : Form
    {
        Graph graph;
        Polygone p;

        public SaverForm()
        {
            InitializeComponent();
        }

        public SaverForm(Rectangle Bounds)
            :this()
        {
            CreatePictureBox(Bounds);
            InitFigure();
        }
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        public SaverForm (string number)
            : this()
        {
            try
            {
                IntPtr preview = new IntPtr(long.Parse(number));
                SetParent(this.Handle, preview);
                SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));
                Rectangle ParentRect;
                GetClientRect(preview, out ParentRect);
                Size = ParentRect.Size;
                Location = new Point(0, 0);
                CreatePictureBox(ParentRect);
                InitFigure();
            }
            catch
            {
                Application.Exit();
            }
        }

        private void CreatePictureBox(Rectangle Bounds)
        {
            this.ClientSize = new System.Drawing.Size(Bounds.Width, Bounds.Height);
            this.Location = new Point(Bounds.Left, Bounds.Top);
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(Bounds.Width, Bounds.Height);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.Picture_Click);
            this.Controls.Add(this.picture);
        }

        private void InitFigure()
        {
            graph = new Graph(
                picture.Width, picture.Height,
                Color.FromArgb(MyRegistry.LoadValue("background", Color.Black.ToArgb())),
                Color.FromArgb(MyRegistry.LoadValue("foreground", Color.White.ToArgb())));

            Figure.InitMinMax(0,0, graph.bmp.Width, graph.bmp.Height);
            int points = MyRegistry.LoadValue("points", 4);          
            p = new Polygone();
            for (int j = 0; j < points; j++)
                p.AddFigure(Figure.RandomFigure());
            timer.Enabled = true;
            TopMost = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            graph.Erase(p);
            p.Move();
            graph.Draw(p);
            picture.Image = graph.bmp;
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
