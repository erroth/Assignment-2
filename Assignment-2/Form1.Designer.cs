namespace Assignment_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Cpyr_label = new System.Windows.Forms.Label();
            this.Hrchl_menu = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Gnre_lst_bx = new System.Windows.Forms.ListBox();
            this.Genre_title = new System.Windows.Forms.TextBox();
            this.Now_Plying_box = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.Ply_lst_box = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Hrchl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cpyr_label
            // 
            this.Cpyr_label.AutoSize = true;
            this.Cpyr_label.Enabled = false;
            this.Cpyr_label.Location = new System.Drawing.Point(188, -2);
            this.Cpyr_label.Name = "Cpyr_label";
            this.Cpyr_label.Size = new System.Drawing.Size(176, 13);
            this.Cpyr_label.TabIndex = 0;
            this.Cpyr_label.Text = "Copyright © 2018. Thomas Handley";
            this.Cpyr_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Hrchl_menu
            // 
            this.Hrchl_menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Hrchl_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.Hrchl_menu.Location = new System.Drawing.Point(0, 487);
            this.Hrchl_menu.Name = "Hrchl_menu";
            this.Hrchl_menu.Size = new System.Drawing.Size(364, 24);
            this.Hrchl_menu.TabIndex = 1;
            this.Hrchl_menu.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Gnre_lst_bx
            // 
            this.Gnre_lst_bx.FormattingEnabled = true;
            this.Gnre_lst_bx.Location = new System.Drawing.Point(109, 170);
            this.Gnre_lst_bx.Name = "Gnre_lst_bx";
            this.Gnre_lst_bx.Size = new System.Drawing.Size(159, 69);
            this.Gnre_lst_bx.TabIndex = 2;
            this.Gnre_lst_bx.SelectedIndexChanged += new System.EventHandler(this.Gnre_lst_bx_SelectedIndexChanged);
            // 
            // Genre_title
            // 
            this.Genre_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Genre_title.Location = new System.Drawing.Point(109, 144);
            this.Genre_title.Name = "Genre_title";
            this.Genre_title.ReadOnly = true;
            this.Genre_title.Size = new System.Drawing.Size(159, 20);
            this.Genre_title.TabIndex = 3;
            this.Genre_title.Text = "General";
            // 
            // Now_Plying_box
            // 
            this.Now_Plying_box.BackColor = System.Drawing.Color.Lime;
            this.Now_Plying_box.Location = new System.Drawing.Point(109, 246);
            this.Now_Plying_box.Name = "Now_Plying_box";
            this.Now_Plying_box.ReadOnly = true;
            this.Now_Plying_box.Size = new System.Drawing.Size(159, 20);
            this.Now_Plying_box.TabIndex = 4;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(109, 222);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(159, 17);
            this.hScrollBar1.TabIndex = 5;
            // 
            // Ply_lst_box
            // 
            this.Ply_lst_box.BackColor = System.Drawing.SystemColors.Info;
            this.Ply_lst_box.FormattingEnabled = true;
            this.Ply_lst_box.Location = new System.Drawing.Point(124, 289);
            this.Ply_lst_box.Name = "Ply_lst_box";
            this.Ply_lst_box.Size = new System.Drawing.Size(120, 95);
            this.Ply_lst_box.TabIndex = 6;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(75, 51);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(219, 46);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(364, 511);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.Ply_lst_box);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.Now_Plying_box);
            this.Controls.Add(this.Genre_title);
            this.Controls.Add(this.Gnre_lst_bx);
            this.Controls.Add(this.Cpyr_label);
            this.Controls.Add(this.Hrchl_menu);
            this.MainMenuStrip = this.Hrchl_menu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Show_form);
            this.Hrchl_menu.ResumeLayout(false);
            this.Hrchl_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cpyr_label;
        private System.Windows.Forms.MenuStrip Hrchl_menu;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox Gnre_lst_bx;
        private System.Windows.Forms.TextBox Genre_title;
        private System.Windows.Forms.TextBox Now_Plying_box;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ListBox Ply_lst_box;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

