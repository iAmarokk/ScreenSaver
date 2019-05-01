using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }


        private void TrackBarCount_Scroll(object sender, EventArgs e)
        {
            labelCount.Text = trackBarCount.Value.ToString();
        }

        private void LabelBackColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = labelBackColor.BackColor;
            DialogResult dr = colorDialog.ShowDialog();
            if (dr == DialogResult.Cancel)
                return;
            labelBackColor.BackColor = colorDialog.Color;
        }

        private void LabelForeColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = labelForeColor.BackColor;
            DialogResult dr = colorDialog.ShowDialog();
            if (dr == DialogResult.Cancel)
                return;
            labelForeColor.BackColor = colorDialog.Color;

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            MyRegistry.SaveValue("background", GetBackColor().ToArgb());
            MyRegistry.SaveValue("foreground", GetForeColor().ToArgb());
            MyRegistry.SaveValue("points", GetPoints());
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public Color GetBackColor()
        {
            return labelBackColor.BackColor;
        }

        public Color GetForeColor()
        {
            return labelForeColor.BackColor;
        }

        public int GetPoints()
        {
            return trackBarCount.Value;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            labelBackColor.BackColor = Color.FromArgb(MyRegistry.LoadValue("background", Color.Black.ToArgb()));
            labelForeColor.BackColor = Color.FromArgb(MyRegistry.LoadValue("foreground", Color.White.ToArgb()));
            int points = MyRegistry.LoadValue("points", 4);
            try
            {
                trackBarCount.Value = points;
            }
            catch
            {
                trackBarCount.Value = trackBarCount.Minimum;
            }
            labelCount.Text = trackBarCount.Value.ToString();

        }
    }
}
