using Sieve.Controles;

namespace Sieve.Janelas.Formularios
{
    partial class ClienteForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtCPF = new Sieve.Controles.SvTextBox();
            this.txtEmail = new Sieve.Controles.SvTextBox();
            this.txtTelefone = new Sieve.Controles.SvTextBox();
            this.txtSobrenome = new Sieve.Controles.SvTextBox();
            this.txtNome = new Sieve.Controles.SvTextBox();
            this.endereco = new Sieve.Controles.SvEndereco();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSubmit.Location = new System.Drawing.Point(476, 435);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnCancel.Location = new System.Drawing.Point(13, 435);
            // 
            // svHeader
            // 
            this.svHeader.Logo = global::Sieve.Properties.Resources.icon;
            this.svHeader.Size = new System.Drawing.Size(669, 41);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dataNascimento);
            this.groupBox2.Controls.Add(this.txtCPF);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtTelefone);
            this.groupBox2.Controls.Add(this.txtSobrenome);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Location = new System.Drawing.Point(16, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(640, 176);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(228, 114);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Data de Nascimento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 114);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Telefone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(228, 66);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "CPF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(227, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Sobrenome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nome";
            // 
            // dataNascimento
            // 
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(230, 134);
            this.dataNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(398, 22);
            this.dataNascimento.TabIndex = 15;
            // 
            // txtCPF
            // 
            this.txtCPF.DecimalDigits = 0;
            this.txtCPF.ForeColor = System.Drawing.Color.Gray;
            this.txtCPF.Location = new System.Drawing.Point(16, 86);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Mask = Sieve.Controles.StringExtension.MaskType.CPF;
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Placeholder = "CPF";
            this.txtCPF.Size = new System.Drawing.Size(203, 22);
            this.txtCPF.TabIndex = 14;
            this.txtCPF.Text = "CPF";
            this.txtCPF.Type = Sieve.Controles.SvTextBox.TextType.Numeric;
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(228, 86);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Placeholder = "Email";
            this.txtEmail.Size = new System.Drawing.Size(400, 22);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "Email";
            // 
            // txtTelefone
            // 
            this.txtTelefone.DecimalDigits = 0;
            this.txtTelefone.ForeColor = System.Drawing.Color.Gray;
            this.txtTelefone.Location = new System.Drawing.Point(16, 134);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Mask = Sieve.Controles.StringExtension.MaskType.Phone;
            this.txtTelefone.MaxLength = 11;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Placeholder = "Telefone";
            this.txtTelefone.Size = new System.Drawing.Size(203, 22);
            this.txtTelefone.TabIndex = 12;
            this.txtTelefone.Text = "Telefone";
            this.txtTelefone.Type = Sieve.Controles.SvTextBox.TextType.Numeric;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.ForeColor = System.Drawing.Color.Gray;
            this.txtSobrenome.Location = new System.Drawing.Point(228, 39);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(4);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Placeholder = "Sobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(400, 22);
            this.txtSobrenome.TabIndex = 11;
            this.txtSobrenome.Text = "Sobrenome";
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.Color.Gray;
            this.txtNome.Location = new System.Drawing.Point(16, 39);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Placeholder = "Nome";
            this.txtNome.Size = new System.Drawing.Size(203, 22);
            this.txtNome.TabIndex = 10;
            this.txtNome.Text = "Nome";
            // 
            // endereco
            // 
            this.endereco.BackColor = System.Drawing.Color.Transparent;
            this.endereco.Location = new System.Drawing.Point(13, 241);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(647, 183);
            this.endereco.TabIndex = 17;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(669, 491);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClienteForm";
            this.Text = "Cliente";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.svHeader, 0);
            this.Controls.SetChildIndex(this.endereco, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private SvTextBox txtCPF;
        private SvTextBox txtEmail;
        private SvTextBox txtTelefone;
        private SvTextBox txtSobrenome;
        private SvTextBox txtNome;
        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private SvEndereco endereco;
    }
}