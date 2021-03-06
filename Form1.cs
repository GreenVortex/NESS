﻿using System;
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
        private void HelpButton_Click(object sender, EventArgs e) { MessageBox.Show("Ness is a Programming project README generator. Have some feedback? contact me @Admin@zefir.codes", "About Ness", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        //Sees if checkbox is selected and enables Project installation field
        private void ProjectInstallationDataRequired_CheckedChanged(object sender, EventArgs e)
        {
            if (ProjectInstallationDataRequired.Checked)
            {
             ProjectInstallationData.Clear();
             ProjectInstallationData.Enabled = true;}
            else
            {ProjectInstallationData.Enabled = false;
             ProjectInstallationData.Clear();
             ProjectInstallationData.Text = "Project does not require an installation";}
        }
        //Sees if checkbox is selected and enables Project usage field
        private void ProjectUsageDataRequired_CheckedChanged(object sender, EventArgs e)
        {
            if (ProjectUsageDataRequired.Checked)
            {ProjectUsageData.Clear();
             ProjectUsageData.Enabled = true;}
            else
            {ProjectUsageData.Clear();
             ProjectUsageData.Text = "No usage documentation required";
             ProjectUsageData.Enabled = false;}
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
            //String Construction for the readme generator
            string headline = "<h1 align='center'>Welcome to " + ProjectNameData.Text + "👋</h1>";
            string version = "## " + "Version";
            string author = "👤 **" + AuthorNameData.Text + "**";
            string description = "> " + ProjectDescriptionData.Text;
            Object selectedItem = ProjectLanguageData.SelectedItem;
            string language = selectedItem.ToString();
            //Readme file generator
                string[] lines = { headline, "", description, "", "This project was made with " + language + "💻", "", version, ProjectVersionData.Text, "", "## Install", "```sh", ProjectInstallationData.Text, "```", "", "## Usage", "```sh", ProjectUsageData.Text, "```", "", "## Author", "", author, "", "## Show your support", "", "Give a ⭐️ if this project helped you!", "", "Readme created with ❤️ using [NESS](https://github.com/GreenVortex/NESS)" };
                File.WriteAllLines("Readme.md", lines);
            }
            //Error handler for when the incorrect index is selected for programming languages
            catch (NullReferenceException)
            {
                MessageBox.Show("Programming language selector filled with undefined charachters, please select pre-defined options", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                ProjectLanguageData.SelectedIndex = 0;
            }
        }
        //Launches readme preview form
        private void Preview_Click(object sender, EventArgs e)
        {
            PreviewForm preview = new PreviewForm();
            preview.ShowDialog();
        }
        //Clear button clears all fields 
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
