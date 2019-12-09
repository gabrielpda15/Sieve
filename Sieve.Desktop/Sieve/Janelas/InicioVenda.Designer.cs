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
            this.txtCpf = new Sieve.Controles.SvTextBox();
            this.btnOk = new Sieve.Controles.SvButton();
            this.svHeader1 = new Sieve.Controles.SvHeader();
            this.btnCancel = new Sieve.Controles.SvButton();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPF:";
            // 
            // checkBoxNotaCPF
            // 
            this.checkBoxNotaCPF.AutoSize = true;
            this.checkBoxNotaCPF.Location = new System.Drawing.Point(243, 76);
            this.checkBoxNotaCPF.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxNotaCPF.Name = "checkBoxNotaCPF";
            this.checkBoxNotaCPF.Size = new System.Drawing.Size(110, 21);
            this.checkBoxNotaCPF.TabIndex = 1;
            this.checkBoxNotaCPF.Text = "CPF na Nota";
            this.checkBoxNotaCPF.UseVisualStyleBackColor = true;
            // 
            // txtCpf
            // 
            this.txtCpf.DecimalDigits = 0;
            this.txtCpf.ForeColor = System.Drawing.Color.Gray;
            this.txtCpf.Location = new System.Drawing.Point(80, 77);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.Mask = Sieve.Controles.StringExtension.MaskType.CPF;
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Placeholder = "000.000.000-00";
            this.txtCpf.Size = new System.Drawing.Size(120, 22);
            this.txtCpf.TabIndex = 0;
            this.txtCpf.Text = "000.000.000-00";
            this.txtCpf.Type = Sieve.Controles.SvTextBox.TextType.Numeric;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(230)))), ((int)(((byte)(217)))));
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(214, 144);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(139, 38);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // svHeader1
            // 
            this.svHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.svHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.svHeader1.Location = new System.Drawing.Point(0, 0);
            this.svHeader1.Logo = global::Sieve.Properties.Resources.icon;
            this.svHeader1.Margin = new System.Windows.Forms.Padding(5);
            this.svHeader1.Name = "svHeader1";
            this.svHeader1.Size = new System.Drawing.Size(401, 50);
            this.svHeader1.TabIndex = 2;
            this.svHeader1.Title = "Início da Venda";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(230)))), ((int)(((byte)(217)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(41, 144);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lbError
            // 
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbError.Location = new System.Drawing.Point(44, 111);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(307, 17);
            this.lbError.TabIndex = 10;
            this.lbError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InicioVenda
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(401, 207);
            this.ControlBox = false;
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.svHeader1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.checkBoxNotaCPF);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private Controles.SvTextBox txtCpf;
        private Controles.SvButton btnOk;
        private Controles.SvHeader svHeader1;
        private Controles.SvButton btnCancel;
        private System.Windows.Forms.Label lbError;
    }
}