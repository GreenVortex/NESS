namespace Ness
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SideBar = new System.Windows.Forms.Panel();
            this.Clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ProjectLanguageData = new System.Windows.Forms.ComboBox();
            this.Preview = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ProjectNameData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProjectVersionData = new System.Windows.Forms.TextBox();
            this.AuthorNameData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ControlBar = new System.Windows.Forms.Panel();
            this.HelpButton = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ProjectInstallationData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProjectUsageData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProjectInstallationDataRequired = new System.Windows.Forms.CheckBox();
            this.ProjectUsageDataRequired = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProjectDescriptionData = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ControlBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SideBar.Controls.Add(this.Clear);
            this.SideBar.Controls.Add(this.label7);
            this.SideBar.Controls.Add(this.ProjectLanguageData);
            this.SideBar.Controls.Add(this.Preview);
            this.SideBar.Controls.Add(this.GenerateButton);
            this.SideBar.Controls.Add(this.panel1);
            this.SideBar.Controls.Add(this.ProjectNameData);
            this.SideBar.Controls.Add(this.label1);
            this.SideBar.Controls.Add(this.label5);
            this.SideBar.Controls.Add(this.ProjectVersionData);
            this.SideBar.Controls.Add(this.AuthorNameData);
            this.SideBar.Controls.Add(this.label2);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(223, 463);
            this.SideBar.TabIndex = 0;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Brown;
            this.Clear.CausesValidation = false;
            this.Clear.ForeColor = System.Drawing.SystemColors.Control;
            this.Clear.Location = new System.Drawing.Point(12, 416);
            this.Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(188, 32);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(59, 303);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Programming langage";
            // 
            // ProjectLanguageData
            // 
            this.ProjectLanguageData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ProjectLanguageData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectLanguageData.ForeColor = System.Drawing.SystemColors.Window;
            this.ProjectLanguageData.FormattingEnabled = true;
            this.ProjectLanguageData.Items.AddRange(new object[] {
            "Java",
            "C#",
            "Python",
            "Ruby",
            "Javascript"});
            this.ProjectLanguageData.Location = new System.Drawing.Point(17, 273);
            this.ProjectLanguageData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectLanguageData.Name = "ProjectLanguageData";
            this.ProjectLanguageData.Size = new System.Drawing.Size(187, 24);
            this.ProjectLanguageData.TabIndex = 18;
            // 
            // Preview
            // 
            this.Preview.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Preview.ForeColor = System.Drawing.SystemColors.Control;
            this.Preview.Location = new System.Drawing.Point(12, 388);
            this.Preview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(188, 27);
            this.Preview.TabIndex = 17;
            this.Preview.Text = "Preview";
            this.Preview.UseVisualStyleBackColor = false;
            this.Preview.Click += new System.EventHandler(this.Preview_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GenerateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.GenerateButton.Location = new System.Drawing.Point(12, 342);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(188, 39);
            this.GenerateButton.TabIndex = 16;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 91);
            this.panel1.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Lato Hairline", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(-48, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 72);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "NESS";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProjectNameData
            // 
            this.ProjectNameData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ProjectNameData.ForeColor = System.Drawing.SystemColors.Window;
            this.ProjectNameData.Location = new System.Drawing.Point(16, 105);
            this.ProjectNameData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectNameData.Name = "ProjectNameData";
            this.ProjectNameData.Size = new System.Drawing.Size(183, 22);
            this.ProjectNameData.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(59, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Project Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(81, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Author";
            // 
            // ProjectVersionData
            // 
            this.ProjectVersionData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ProjectVersionData.ForeColor = System.Drawing.SystemColors.Window;
            this.ProjectVersionData.Location = new System.Drawing.Point(16, 160);
            this.ProjectVersionData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectVersionData.Name = "ProjectVersionData";
            this.ProjectVersionData.Size = new System.Drawing.Size(183, 22);
            this.ProjectVersionData.TabIndex = 5;
            // 
            // AuthorNameData
            // 
            this.AuthorNameData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AuthorNameData.ForeColor = System.Drawing.SystemColors.Window;
            this.AuthorNameData.Location = new System.Drawing.Point(17, 218);
            this.AuthorNameData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AuthorNameData.Name = "AuthorNameData";
            this.AuthorNameData.Size = new System.Drawing.Size(187, 22);
            this.AuthorNameData.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(59, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Project Version";
            // 
            // ControlBar
            // 
            this.ControlBar.BackColor = System.Drawing.Color.LightGray;
            this.ControlBar.Controls.Add(this.HelpButton);
            this.ControlBar.Controls.Add(this.Hide);
            this.ControlBar.Controls.Add(this.Exit);
            this.ControlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlBar.Location = new System.Drawing.Point(223, 0);
            this.ControlBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ControlBar.Name = "ControlBar";
            this.ControlBar.Size = new System.Drawing.Size(472, 32);
            this.ControlBar.TabIndex = 1;
            this.ControlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlBar_MouseDown);
            this.ControlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlBar_MouseMove);
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.Orange;
            this.HelpButton.ForeColor = System.Drawing.SystemColors.Control;
            this.HelpButton.Location = new System.Drawing.Point(367, 4);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(27, 25);
            this.HelpButton.TabIndex = 3;
            this.HelpButton.Text = "?";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // Hide
            // 
            this.Hide.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Hide.Location = new System.Drawing.Point(401, 4);
            this.Hide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(27, 25);
            this.Hide.TabIndex = 2;
            this.Hide.UseVisualStyleBackColor = false;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.OrangeRed;
            this.Exit.Location = new System.Drawing.Point(436, 4);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 25);
            this.Exit.TabIndex = 0;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ProjectInstallationData
            // 
            this.ProjectInstallationData.AcceptsReturn = true;
            this.ProjectInstallationData.AcceptsTab = true;
            this.ProjectInstallationData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ProjectInstallationData.ForeColor = System.Drawing.SystemColors.Window;
            this.ProjectInstallationData.Location = new System.Drawing.Point(252, 52);
            this.ProjectInstallationData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectInstallationData.Multiline = true;
            this.ProjectInstallationData.Name = "ProjectInstallationData";
            this.ProjectInstallationData.Size = new System.Drawing.Size(411, 77);
            this.ProjectInstallationData.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(379, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Project Installation";
            // 
            // ProjectUsageData
            // 
            this.ProjectUsageData.AcceptsReturn = true;
            this.ProjectUsageData.AcceptsTab = true;
            this.ProjectUsageData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ProjectUsageData.ForeColor = System.Drawing.SystemColors.Window;
            this.ProjectUsageData.Location = new System.Drawing.Point(255, 160);
            this.ProjectUsageData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectUsageData.Multiline = true;
            this.ProjectUsageData.Name = "ProjectUsageData";
            this.ProjectUsageData.Size = new System.Drawing.Size(411, 77);
            this.ProjectUsageData.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(379, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Project Usage";
            // 
            // ProjectInstallationDataRequired
            // 
            this.ProjectInstallationDataRequired.AutoSize = true;
            this.ProjectInstallationDataRequired.Checked = true;
            this.ProjectInstallationDataRequired.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProjectInstallationDataRequired.ForeColor = System.Drawing.SystemColors.Control;
            this.ProjectInstallationDataRequired.Location = new System.Drawing.Point(520, 132);
            this.ProjectInstallationDataRequired.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectInstallationDataRequired.Name = "ProjectInstallationDataRequired";
            this.ProjectInstallationDataRequired.Size = new System.Drawing.Size(88, 21);
            this.ProjectInstallationDataRequired.TabIndex = 11;
            this.ProjectInstallationDataRequired.Text = "Required";
            this.ProjectInstallationDataRequired.UseVisualStyleBackColor = true;
            this.ProjectInstallationDataRequired.CheckedChanged += new System.EventHandler(this.ProjectInstallationDataRequired_CheckedChanged);
            // 
            // ProjectUsageDataRequired
            // 
            this.ProjectUsageDataRequired.AutoSize = true;
            this.ProjectUsageDataRequired.Checked = true;
            this.ProjectUsageDataRequired.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProjectUsageDataRequired.ForeColor = System.Drawing.SystemColors.Control;
            this.ProjectUsageDataRequired.Location = new System.Drawing.Point(520, 245);
            this.ProjectUsageDataRequired.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectUsageDataRequired.Name = "ProjectUsageDataRequired";
            this.ProjectUsageDataRequired.Size = new System.Drawing.Size(88, 21);
            this.ProjectUsageDataRequired.TabIndex = 12;
            this.ProjectUsageDataRequired.Text = "Required";
            this.ProjectUsageDataRequired.UseVisualStyleBackColor = true;
            this.ProjectUsageDataRequired.CheckedChanged += new System.EventHandler(this.ProjectUsageDataRequired_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(423, 354);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Description";
            // 
            // ProjectDescriptionData
            // 
            this.ProjectDescriptionData.AcceptsReturn = true;
            this.ProjectDescriptionData.AcceptsTab = true;
            this.ProjectDescriptionData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ProjectDescriptionData.ForeColor = System.Drawing.SystemColors.Window;
            this.ProjectDescriptionData.Location = new System.Drawing.Point(255, 273);
            this.ProjectDescriptionData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectDescriptionData.Multiline = true;
            this.ProjectDescriptionData.Name = "ProjectDescriptionData";
            this.ProjectDescriptionData.Size = new System.Drawing.Size(411, 77);
            this.ProjectDescriptionData.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(223, 431);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 32);
            this.panel2.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox2.Location = new System.Drawing.Point(352, 4);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 23);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Version 1.1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(695, 463);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProjectDescriptionData);
            this.Controls.Add(this.ProjectUsageDataRequired);
            this.Controls.Add(this.ProjectInstallationDataRequired);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProjectUsageData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProjectInstallationData);
            this.Controls.Add(this.ControlBar);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "NESS";
            this.Load += new System.EventHandler(this.Main_Load);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ControlBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel ControlBar;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.TextBox ProjectNameData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProjectVersionData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProjectInstallationData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProjectUsageData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ProjectInstallationDataRequired;
        private System.Windows.Forms.CheckBox ProjectUsageDataRequired;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AuthorNameData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProjectDescriptionData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Preview;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ProjectLanguageData;
        private System.Windows.Forms.Button Clear;
    }
}

