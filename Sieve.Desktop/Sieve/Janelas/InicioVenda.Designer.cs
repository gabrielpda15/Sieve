namespace Sieve.Janelas
{
    partial class InicioVenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxNotaCPF = new System.Windows.Forms.CheckBox();
            this.svTxtCPF = new Sieve.Controles.SvTextBox();
            this.btnOk = new Sieve.Controles.SvButton();
            this.svHeader1 = new Sieve.Controles.SvHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPF";
            // 
            // checkBoxNotaCPF
            // 
            this.checkBoxNotaCPF.AutoSize = true;
            this.checkBoxNotaCPF.Location = new System.Drawing.Point(71, 98);
            this.checkBoxNotaCPF.Name = "checkBoxNotaCPF";
            this.checkBoxNotaCPF.Size = new System.Drawing.Size(87, 17);
            this.checkBoxNotaCPF.TabIndex = 1;
            this.checkBoxNotaCPF.Text = "CPF na Nota";
            this.checkBoxNotaCPF.UseVisualStyleBackColor = true;
            // 
            // svTxtCPF
            // 
            this.svTxtCPF.ForeColor = System.Drawing.Color.Gray;
            this.svTxtCPF.Location = new System.Drawing.Point(57, 65);
            this.svTxtCPF.Name = "svTxtCPF";
            this.svTxtCPF.Placeholder = "";
            this.svTxtCPF.Size = new System.Drawing.Size(194, 20);
            this.svTxtCPF.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(230)))), ((int)(((byte)(217)))));
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(94, 136);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 31);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // svHeader1
            // 
            this.svHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.svHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.svHeader1.Location = new System.Drawing.Point(0, 0);
            this.svHeader1.Logo = global::Sieve.Properties.Resources.icon;
            this.svHeader1.Margin = new System.Windows.Forms.Padding(4);
            this.svHeader1.Name = "svHeader1";
            this.svHeader1.Size = new System.Drawing.Size(301, 41);
            this.svHeader1.TabIndex = 2;
            this.svHeader1.Title = "Início da Venda";
            // 
            // InicioVenda
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(301, 185);
            this.ControlBox = false;
            this.Controls.Add(this.svHeader1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.svTxtCPF);
            this.Controls.Add(this.checkBoxNotaCPF);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioVenda";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioVenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxNotaCPF;
        private Controles.SvTextBox svTxtCPF;
        private Controles.SvButton btnOk;
        private Controles.SvHeader svHeader1;
    }
}