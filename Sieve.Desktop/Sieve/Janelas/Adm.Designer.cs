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
            this.content = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.manutencaoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identityMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.svHeader1 = new Sieve.Controles.SvHeader();
            this.content.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Controls.Add(this.menuStrip);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 41);
            this.content.Margin = new System.Windows.Forms.Padding(2);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(800, 414);
            this.content.TabIndex = 4;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutencaoMenuItem,
            this.btnLogout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // manutencaoMenuItem
            // 
            this.manutencaoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientMenuItem,
            this.supplierMenuItem,
            this.employeeMenuItem,
            this.productMenuItem});
            this.manutencaoMenuItem.Name = "manutencaoMenuItem";
            this.manutencaoMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutencaoMenuItem.Text = "Manutenção";
            // 
            // clientMenuItem
            // 
            this.clientMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cardMenuItem,
            this.orderMenuItem});
            this.clientMenuItem.Name = "clientMenuItem";
            this.clientMenuItem.Size = new System.Drawing.Size(137, 22);
            this.clientMenuItem.Text = "Cliente";
            // 
            // cardMenuItem
            // 
            this.cardMenuItem.Name = "cardMenuItem";
            this.cardMenuItem.Size = new System.Drawing.Size(111, 22);
            this.cardMenuItem.Text = "Cartão";
            // 
            // orderMenuItem
            // 
            this.orderMenuItem.Name = "orderMenuItem";
            this.orderMenuItem.Size = new System.Drawing.Size(111, 22);
            this.orderMenuItem.Text = "Pedido";
            // 
            // supplierMenuItem
            // 
            this.supplierMenuItem.Name = "supplierMenuItem";
            this.supplierMenuItem.Size = new System.Drawing.Size(137, 22);
            this.supplierMenuItem.Text = "Fornecedor";
            // 
            // employeeMenuItem
            // 
            this.employeeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identityMenuItem,
            this.roleMenuItem});
            this.employeeMenuItem.Name = "employeeMenuItem";
            this.employeeMenuItem.Size = new System.Drawing.Size(137, 22);
            this.employeeMenuItem.Text = "Funcionário";
            // 
            // identityMenuItem
            // 
            this.identityMenuItem.Name = "identityMenuItem";
            this.identityMenuItem.Size = new System.Drawing.Size(133, 22);
            this.identityMenuItem.Text = "Identidade";
            // 
            // roleMenuItem
            // 
            this.roleMenuItem.Name = "roleMenuItem";
            this.roleMenuItem.Size = new System.Drawing.Size(133, 22);
            this.roleMenuItem.Text = "Permissões";
            // 
            // productMenuItem
            // 
            this.productMenuItem.Name = "productMenuItem";
            this.productMenuItem.Size = new System.Drawing.Size(137, 22);
            this.productMenuItem.Text = "Produto";
            // 
            // btnLogout
            // 
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(57, 20);
            this.btnLogout.Text = "Logout";
            // 
            // svHeader1
            // 
            this.svHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.svHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.svHeader1.Location = new System.Drawing.Point(0, 0);
            this.svHeader1.Logo = global::Sieve.Properties.Resources.icon;
            this.svHeader1.Margin = new System.Windows.Forms.Padding(4);
            this.svHeader1.Name = "svHeader1";
            this.svHeader1.Size = new System.Drawing.Size(800, 41);
            this.svHeader1.TabIndex = 2;
            this.svHeader1.Title = "Sieve - Adm";
            // 
            // Adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.ControlBox = false;
            this.Controls.Add(this.content);
            this.Controls.Add(this.svHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Adm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sieve - Adm";
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.SvHeader svHeader1;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem manutencaoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identityMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
    }
}