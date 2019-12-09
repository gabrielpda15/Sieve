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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.txtComplemento = new Sieve.Controles.SvTextBox();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.txtBairro = new Sieve.Controles.SvTextBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.txtCep = new Sieve.Controles.SvTextBox();
            this.txtEndereco = new Sieve.Controles.SvTextBox();
            this.txtNumero = new Sieve.Controles.SvTextBox();
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
            this.svHeader1 = new Sieve.Controles.SvHeader();
            this.btnVoltar = new Sieve.Controles.SvButton();
            this.btnEnviar = new Sieve.Controles.SvButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxPais);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.comboBoxCidade);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.comboBoxEstado);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Location = new System.Drawing.Point(16, 242);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(640, 191);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Complemento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "País";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Bairro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nº";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "CEP";
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Location = new System.Drawing.Point(97, 140);
            this.comboBoxPais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(353, 24);
            this.comboBoxPais.TabIndex = 17;
            // 
            // txtComplemento
            // 
            this.txtComplemento.ForeColor = System.Drawing.Color.Gray;
            this.txtComplemento.Location = new System.Drawing.Point(460, 140);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Placeholder = "Complemento";
            this.txtComplemento.Size = new System.Drawing.Size(161, 22);
            this.txtComplemento.TabIndex = 16;
            this.txtComplemento.Text = "Complemento";
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.Location = new System.Drawing.Point(267, 92);
            this.comboBoxCidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(355, 24);
            this.comboBoxCidade.TabIndex = 15;
            // 
            // txtBairro
            // 
            this.txtBairro.ForeColor = System.Drawing.Color.Gray;
            this.txtBairro.Location = new System.Drawing.Point(12, 92);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Placeholder = "Bairro";
            this.txtBairro.Size = new System.Drawing.Size(245, 22);
            this.txtBairro.TabIndex = 14;
            this.txtBairro.Text = "Bairro";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(12, 140);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(76, 24);
            this.comboBoxEstado.TabIndex = 13;
            // 
            // txtCep
            // 
            this.txtCep.ForeColor = System.Drawing.Color.Gray;
            this.txtCep.Location = new System.Drawing.Point(12, 44);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCep.Name = "txtCep";
            this.txtCep.Placeholder = "CEP";
            this.txtCep.Size = new System.Drawing.Size(136, 22);
            this.txtCep.TabIndex = 12;
            this.txtCep.Text = "CEP";
            // 
            // txtEndereco
            // 
            this.txtEndereco.ForeColor = System.Drawing.Color.Gray;
            this.txtEndereco.Location = new System.Drawing.Point(157, 44);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Placeholder = "Endereço";
            this.txtEndereco.Size = new System.Drawing.Size(379, 22);
            this.txtEndereco.TabIndex = 11;
            this.txtEndereco.Text = "Endereço";
            // 
            // txtNumero
            // 
            this.txtNumero.ForeColor = System.Drawing.Color.Gray;
            this.txtNumero.Location = new System.Drawing.Point(545, 44);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Placeholder = "Nº";
            this.txtNumero.Size = new System.Drawing.Size(76, 22);
            this.txtNumero.TabIndex = 10;
            this.txtNumero.Text = "Nº";
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
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataNascimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(398, 22);
            this.dataNascimento.TabIndex = 15;
            // 
            // txtCPF
            // 
            this.txtCPF.DecimalDigits = 0;
            this.txtCPF.ForeColor = System.Drawing.Color.Gray;
            this.txtCPF.Location = new System.Drawing.Point(16, 86);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Placeholder = "Nome";
            this.txtNome.Size = new System.Drawing.Size(203, 22);
            this.txtNome.TabIndex = 10;
            this.txtNome.Text = "Nome";
            // 
            // svHeader1
            // 
            this.svHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.svHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.svHeader1.Location = new System.Drawing.Point(0, 0);
            this.svHeader1.Logo = global::Sieve.Properties.Resources.icon;
            this.svHeader1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.svHeader1.Name = "svHeader1";
            this.svHeader1.Size = new System.Drawing.Size(669, 50);
            this.svHeader1.TabIndex = 2;
            this.svHeader1.Title = "Cliente";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(230)))), ((int)(((byte)(217)))));
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(16, 458);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(180, 43);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(230)))), ((int)(((byte)(217)))));
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Location = new System.Drawing.Point(476, 458);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(180, 43);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // ClienteForm
            // 
            this.AcceptButton = this.btnEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.CancelButton = this.btnVoltar;
            this.ClientSize = new System.Drawing.Size(669, 516);
            this.ControlBox = false;
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.svHeader1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClienteForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private SvTextBox txtComplemento;
        private System.Windows.Forms.ComboBox comboBoxCidade;
        private SvTextBox txtBairro;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private SvTextBox txtCep;
        private SvTextBox txtEndereco;
        private SvTextBox txtNumero;
        private System.Windows.Forms.GroupBox groupBox2;
        private SvTextBox txtCPF;
        private SvTextBox txtEmail;
        private SvTextBox txtTelefone;
        private SvTextBox txtSobrenome;
        private SvTextBox txtNome;
        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private SvHeader svHeader1;
        private SvButton btnVoltar;
        private SvButton btnEnviar;
    }
}