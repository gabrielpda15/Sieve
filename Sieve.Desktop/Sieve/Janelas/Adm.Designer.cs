namespace Sieve.Janelas
{
    partial class Adm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adm));
            this.svHeader1 = new Sieve.Controles.SvHeader();
            this.content = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // svHeader1
            // 
            this.svHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.svHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.svHeader1.Location = new System.Drawing.Point(0, 0);
            this.svHeader1.Logo = global::Sieve.Properties.Resources.icon;
            this.svHeader1.Margin = new System.Windows.Forms.Padding(4);
            this.svHeader1.Name = "svHeader1";
            this.svHeader1.Size = new System.Drawing.Size(1067, 41);
            this.svHeader1.TabIndex = 2;
            this.svHeader1.Title = "Sieve - Adm";
            // 
            // content
            // 
            this.content.Controls.Add(this.menuStrip);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 41);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1067, 513);
            this.content.TabIndex = 4;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.content);
            this.Controls.Add(this.svHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Adm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sieve - Adm";
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.SvHeader svHeader1;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}