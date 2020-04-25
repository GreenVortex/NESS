namespace Ness
{
    partial class PreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
            this.ControlBar = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.GenDisplay = new System.Windows.Forms.RichTextBox();
            this.Hide = new System.Windows.Forms.Button();
            this.ControlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlBar
            // 
            this.ControlBar.BackColor = System.Drawing.Color.LightGray;
            this.ControlBar.Controls.Add(this.Hide);
            this.ControlBar.Controls.Add(this.Exit);
            this.ControlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlBar.Location = new System.Drawing.Point(0, 0);
            this.ControlBar.Name = "ControlBar";
            this.ControlBar.Size = new System.Drawing.Size(395, 26);
            this.ControlBar.TabIndex = 2;
            this.ControlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlBar_MouseDown);
            this.ControlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlBar_MouseMove);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.OrangeRed;
            this.Exit.Location = new System.Drawing.Point(363, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(20, 20);
            this.Exit.TabIndex = 0;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // GenDisplay
            // 
            this.GenDisplay.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GenDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GenDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenDisplay.ForeColor = System.Drawing.SystemColors.Window;
            this.GenDisplay.Location = new System.Drawing.Point(0, 26);
            this.GenDisplay.Name = "GenDisplay";
            this.GenDisplay.ReadOnly = true;
            this.GenDisplay.Size = new System.Drawing.Size(395, 281);
            this.GenDisplay.TabIndex = 3;
            this.GenDisplay.Text = "";
            // 
            // Hide
            // 
            this.Hide.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Hide.Location = new System.Drawing.Point(337, 3);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(20, 20);
            this.Hide.TabIndex = 3;
            this.Hide.UseVisualStyleBackColor = false;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 307);
            this.Controls.Add(this.GenDisplay);
            this.Controls.Add(this.ControlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreviewForm";
            this.Text = "Preview";
            this.Load += new System.EventHandler(this.PreviewForm_Load);
            this.ControlBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlBar;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RichTextBox GenDisplay;
        private System.Windows.Forms.Button Hide;
    }
}