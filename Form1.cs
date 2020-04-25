using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ness
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e) { ProjectLanguageData.SelectedIndex = 0; }
        //Drag fix
        Point lastPoint;
        private void ControlBar_MouseDown(object sender, MouseEventArgs e) {lastPoint = new Point(e.X, e.Y);}
        private void ControlBar_MouseMove(object sender, MouseEventArgs e) {if (e.Button == MouseButtons.Left){ this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y;}}

        //ControlBar Buttons
        private void Exit_Click(object sender, EventArgs e) {Application.Exit();}
        private void Hide_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized;}
        private void HelpButton_Click(object sender, EventArgs e) { MessageBox.Show("Ness is a Programming project README generator. Have some feedback? contact me @jan.andersson.ie@gmail.com", "About Ness", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        private void ProjectInstallationDataRequired_CheckedChanged(object sender, EventArgs e)
        {
            if (ProjectInstallationDataRequired.Checked)
            {ProjectInstallationData.Enabled = true;}
            else
            {ProjectInstallationData.Enabled = false;
             ProjectInstallationData.Clear();
             ProjectInstallationData.Text = "N/A";}
        }

        private void ProjectUsageDataRequired_CheckedChanged(object sender, EventArgs e)
        {
            if (ProjectUsageDataRequired.Checked)
            {ProjectUsageData.Clear();
             ProjectUsageData.Enabled = true;}
            else
            {ProjectUsageData.Clear();
             ProjectUsageData.Text = "N/A";
             ProjectUsageData.Enabled = false;}
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            //String Construct
            string headline = "<h1 align='center'>Welcome to " + ProjectNameData.Text + "👋</h1>";
            string version = "## " + "Version";
            string author = "👤 **" + AuthorNameData.Text + "**";
            string description = "> " + ProjectDescriptionData.Text;
            Object selectedItem = ProjectLanguageData.SelectedItem;
            string language = selectedItem.ToString();
            //Generator
            string[] lines = {headline,"", description,"","This project was made with " + language +"💻", "",version,ProjectVersionData.Text,"","## Install", "```sh",ProjectInstallationData.Text , "```", "", "## Usage", "```sh", ProjectUsageData.Text, "```", "", "## Author","", author, "", "## Show your support", "", "Give a ⭐️ if this project helped you!", "", "Readme created with ❤️ using [NESS](https://github.com/GreenVortex/NESS)" };
            File.WriteAllLines("Readme.md", lines);
        }

        private void Preview_Click(object sender, EventArgs e)
        {
            PreviewForm preview = new PreviewForm();
            preview.ShowDialog();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ProjectNameData.Clear();
            ProjectVersionData.Clear();
            AuthorNameData.Clear();
            ProjectLanguageData.ResetText();
            ProjectInstallationData.Clear();
            ProjectUsageData.Clear();
            ProjectDescriptionData.Clear();
        }
    }
}
