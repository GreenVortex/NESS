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
        //close button
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Code for making the controlbar dragable
        Point lastPoint;
        private void ControlBar_MouseDown(object sender, MouseEventArgs e) { lastPoint = new Point(e.X, e.Y); }
        private void ControlBar_MouseMove(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; } }
        //Minimize buttton
        private void Hide_Click(object sender, EventArgs e) {this.WindowState = FormWindowState.Minimized;}
        //Checks if readme exists and displays the content in raw format
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
