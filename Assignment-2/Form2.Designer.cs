namespace Assignment_2
{
    partial class Setup
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
            this.Imp_trks = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Imp_trks
            // 
            this.Imp_trks.Location = new System.Drawing.Point(22, 22);
            this.Imp_trks.Name = "Imp_trks";
            this.Imp_trks.Size = new System.Drawing.Size(200, 248);
            this.Imp_trks.TabIndex = 0;
            this.Imp_trks.TabStop = false;
            this.Imp_trks.Text = "Imported Tracks";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 314);
            this.Controls.Add(this.Imp_trks);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Imp_trks;
    }
}