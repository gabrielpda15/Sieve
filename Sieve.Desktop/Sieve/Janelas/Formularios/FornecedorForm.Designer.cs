using Sieve.Controles;

namespace Sieve.Janelas.Formularios
{
    partial class FornecedorForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtServico = new Sieve.Controles.SvTextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.txtObservacoes = new Sieve.Controles.SvTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new Sieve.Controles.SvTextBox();
            this.txtNomeFantasia = new Sieve.Controles.SvTextBox();
            this.txtCNPJ = new Sieve.Controles.SvTextBox();
            this.txtEmailEmpresa = new Sieve.Controles.SvTextBox();
            this.txtTelefoneEmpresa = new Sieve.Controles.SvTextBox();
            this.comboBoxPessoa = new System.Windows.Forms.ComboBox();
            this.txtNome = new Sieve.Controles.SvTextBox();
            this.txtSobrenome = new Sieve.Controles.SvTextBox();
            this.txtTelefone = new Sieve.Controles.SvTextBox();
            this.txtEmail = new Sieve.Controles.SvTextBox();
            this.txtCPF = new Sieve.Controles.SvTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.svEndereco1 = new Sieve.Controles.SvEndereco();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSubmit.Location = new System.Drawing.Point(476, 866);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnCancel.Location = new System.Drawing.Point(16, 866);
            // 
            // svHeader
            // 
            this.svHeader.Logo = global::Sieve.Properties.Resources.icon;
            this.svHeader.Size = new System.Drawing.Size(669, 41);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtServico);
            this.groupBox3.Controls.Add(this.comboBoxTipo);
            this.groupBox3.Controls.Add(this.txtObservacoes);
            this.groupBox3.Location = new System.Drawing.Point(16, 655);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(640, 203);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outros";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 74);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 17);
            this.label22.TabIndex = 21;
            this.label22.Text = "Observações";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(300, 25);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 17);
            this.label21.TabIndex = 20;
            this.label21.Text = "Serviço";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 25);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 17);
            this.label20.TabIndex = 19;
            this.label20.Text = "Tipo";
            // 
            // txtServico
            // 
            this.txtServico.ForeColor = System.Drawing.Color.Gray;
            this.txtServico.Location = new System.Drawing.Point(304, 44);
            this.txtServico.Margin = new System.Windows.Forms.Padding(4);
            this.txtServico.Name = "txtServico";
            this.txtServico.Placeholder = "Serviço";
            this.txtServico.Size = new System.Drawing.Size(327, 22);
            this.txtServico.TabIndex = 18;
            this.txtServico.Text = "Serviço";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(8, 44);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(287, 24);
            this.comboBoxTipo.TabIndex = 5;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.ForeColor = System.Drawing.Color.Gray;
            this.txtObservacoes.Location = new System.Drawing.Point(8, 94);
            this.txtObservacoes.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Placeholder = "Observações";
            this.txtObservacoes.Size = new System.Drawing.Size(623, 99);
            this.txtObservacoes.TabIndex = 4;
            this.txtObservacoes.Text = "Observações";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtRazaoSocial);
            this.groupBox2.Controls.Add(this.txtNomeFantasia);
            this.groupBox2.Controls.Add(this.txtCNPJ);
            this.groupBox2.Controls.Add(this.txtEmailEmpresa);
            this.groupBox2.Controls.Add(this.txtTelefoneEmpresa);
            this.groupBox2.Location = new System.Drawing.Point(16, 289);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(640, 170);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Empresa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "CNPJ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 68);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Razão Social";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nome da Empresa";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.ForeColor = System.Drawing.Color.Gray;
            this.txtRazaoSocial.Location = new System.Drawing.Point(251, 39);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Placeholder = "Razão Social";
            this.txtRazaoSocial.Size = new System.Drawing.Size(380, 22);
            this.txtRazaoSocial.TabIndex = 18;
            this.txtRazaoSocial.Text = "Razão Social";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.ForeColor = System.Drawing.Color.Gray;
            this.txtNomeFantasia.Location = new System.Drawing.Point(8, 39);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Placeholder = "Nome da Empresa";
            this.txtNomeFantasia.Size = new System.Drawing.Size(233, 22);
            this.txtNomeFantasia.TabIndex = 17;
            this.txtNomeFantasia.Text = "Nome da Empresa";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.ForeColor = System.Drawing.Color.Gray;
            this.txtCNPJ.Location = new System.Drawing.Point(8, 135);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(4);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Placeholder = "CNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(279, 22);
            this.txtCNPJ.TabIndex = 16;
            this.txtCNPJ.Text = "CNPJ";
            // 
            // txtEmailEmpresa
            // 
            this.txtEmailEmpresa.ForeColor = System.Drawing.Color.Gray;
            this.txtEmailEmpresa.Location = new System.Drawing.Point(251, 87);
            this.txtEmailEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailEmpresa.Name = "txtEmailEmpresa";
            this.txtEmailEmpresa.Placeholder = "Email";
            this.txtEmailEmpresa.Size = new System.Drawing.Size(380, 22);
            this.txtEmailEmpresa.TabIndex = 13;
            this.txtEmailEmpresa.Text = "Email";
            // 
            // txtTelefoneEmpresa
            // 
            this.txtTelefoneEmpresa.ForeColor = System.Drawing.Color.Gray;
            this.txtTelefoneEmpresa.Location = new System.Drawing.Point(8, 87);
            this.txtTelefoneEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefoneEmpresa.Name = "txtTelefoneEmpresa";
            this.txtTelefoneEmpresa.Placeholder = "Telefone";
            this.txtTelefoneEmpresa.Size = new System.Drawing.Size(233, 22);
            this.txtTelefoneEmpresa.TabIndex = 12;
            this.txtTelefoneEmpresa.Text = "Telefone";
            // 
            // comboBoxPessoa
            // 
            this.comboBoxPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPessoa.FormattingEnabled = true;
            this.comboBoxPessoa.Items.AddRange(new object[] {
            "Pessoa Física",
            "Pessoa Jurídica"});
            this.comboBoxPessoa.Location = new System.Drawing.Point(16, 62);
            this.comboBoxPessoa.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPessoa.Name = "comboBoxPessoa";
            this.comboBoxPessoa.Size = new System.Drawing.Size(208, 26);
            this.comboBoxPessoa.TabIndex = 18;
            this.comboBoxPessoa.Text = "Pessoa Jurídica";
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.Color.Gray;
            this.txtNome.Location = new System.Drawing.Point(8, 44);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Placeholder = "Nome";
            this.txtNome.Size = new System.Drawing.Size(213, 22);
            this.txtNome.TabIndex = 10;
            this.txtNome.Text = "Nome";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.ForeColor = System.Drawing.Color.Gray;
            this.txtSobrenome.Location = new System.Drawing.Point(228, 44);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(4);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Placeholder = "Sobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(400, 22);
            this.txtSobrenome.TabIndex = 11;
            this.txtSobrenome.Text = "Sobrenome";
            // 
            // txtTelefone
            // 
            this.txtTelefone.ForeColor = System.Drawing.Color.Gray;
            this.txtTelefone.Location = new System.Drawing.Point(8, 142);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Placeholder = "Telefone";
            this.txtTelefone.Size = new System.Drawing.Size(213, 22);
            this.txtTelefone.TabIndex = 12;
            this.txtTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(228, 94);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Placeholder = "Email";
            this.txtEmail.Size = new System.Drawing.Size(403, 22);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "Email";
            // 
            // txtCPF
            // 
            this.txtCPF.ForeColor = System.Drawing.Color.Gray;
            this.txtCPF.Location = new System.Drawing.Point(8, 94);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Placeholder = "CPF";
            this.txtCPF.Size = new System.Drawing.Size(213, 22);
            this.txtCPF.TabIndex = 14;
            this.txtCPF.Text = "CPF";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dataNascimento);
            this.groupBox4.Controls.Add(this.txtCPF);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Controls.Add(this.txtTelefone);
            this.groupBox4.Controls.Add(this.txtSobrenome);
            this.groupBox4.Controls.Add(this.txtNome);
            this.groupBox4.Location = new System.Drawing.Point(16, 97);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(640, 185);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados Pessoais";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Data de Aniversário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sobrenome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome";
            // 
            // dataNascimento
            // 
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(228, 142);
            this.dataNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(403, 22);
            this.dataNascimento.TabIndex = 15;
            // 
            // svEndereco1
            // 
            this.svEndereco1.BackColor = System.Drawing.Color.Transparent;
            this.svEndereco1.Bairro = "";
            this.svEndereco1.CEP = "";
            this.svEndereco1.Complemento = "";
            this.svEndereco1.Endereco = "";
            this.svEndereco1.Location = new System.Drawing.Point(12, 466);
            this.svEndereco1.Name = "svEndereco1";
            this.svEndereco1.Numero = "";
            this.svEndereco1.Pais = null;
            this.svEndereco1.Size = new System.Drawing.Size(647, 183);
            this.svEndereco1.TabIndex = 20;
            // 
            // FornecedorForm
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.CancelButton = null;
            this.ClientSize = new System.Drawing.Size(669, 922);
            this.Controls.Add(this.svEndereco1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.comboBoxPessoa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FornecedorForm";
            this.Text = "FornecedorForm";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.comboBoxPessoa, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.svHeader, 0);
            this.Controls.SetChildIndex(this.svEndereco1, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private SvTextBox txtEmailEmpresa;
        private SvTextBox txtTelefoneEmpresa;
        private SvTextBox txtCNPJ;
        private SvTextBox txtNomeFantasia;
        private SvTextBox txtRazaoSocial;
        private SvTextBox txtObservacoes;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxPessoa;
        private SvTextBox txtServico;
        private SvTextBox txtNome;
        private SvTextBox txtSobrenome;
        private SvTextBox txtTelefone;
        private SvTextBox txtEmail;
        private SvTextBox txtCPF;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private SvEndereco svEndereco1;
    }
}