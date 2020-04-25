using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ness
{
    public partial class PreviewForm : Form
    {
        public PreviewForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void ControlBar_MouseDown(object sender, MouseEventArgs e) { lastPoint = new Point(e.X, e.Y); }
        private void ControlBar_MouseMove(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; } }

        private void Hide_Click(object sender, EventArgs e) {this.WindowState = FormWindowState.Minimized;}

        private void PreviewForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("Readme.md"))
            {
                GenDisplay.Text = File.ReadAllText("Readme.md");
            }
            else
            {
                GenDisplay.Text = "No ReadMe generated";
            }
        }
    }
}
