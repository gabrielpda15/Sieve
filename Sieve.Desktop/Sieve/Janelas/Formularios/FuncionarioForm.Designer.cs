using Sieve.Controles;

namespace Sieve.Janelas.Formularios
{
    partial class FuncionarioForm
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
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtCPF = new Sieve.Controles.SvTextBox();
            this.txtEmail = new Sieve.Controles.SvTextBox();
            this.txTelefone = new Sieve.Controles.SvTextBox();
            this.txtSobrenome = new Sieve.Controles.SvTextBox();
            this.txtNome = new Sieve.Controles.SvTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new Sieve.Controles.SvTextBox();
            this.txtCTPS = new Sieve.Controles.SvTextBox();
            this.txtCargo = new Sieve.Controles.SvTextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.svEndereco1 = new Sieve.Controles.SvEndereco();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSubmit.Location = new System.Drawing.Point(476, 591);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnCancel.Location = new System.Drawing.Point(16, 591);
            // 
            // svHeader
            // 
            this.svHeader.Logo = global::Sieve.Properties.Resources.icon;
            this.svHeader.Size = new System.Drawing.Size(677, 41);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.dataNascimento);
            this.groupBox2.Controls.Add(this.txtCPF);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txTelefone);
            this.groupBox2.Controls.Add(this.txtSobrenome);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Location = new System.Drawing.Point(16, 66);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(640, 178);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(227, 116);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 17);
            this.label18.TabIndex = 30;
            this.label18.Text = "Data de Nascimento";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 116);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "Telefone";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(227, 68);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "Email";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 68);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "CPF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(227, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Sobrenome";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Nome";
            // 
            // dataNascimento
            // 
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(228, 135);
            this.dataNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(400, 22);
            this.dataNascimento.TabIndex = 15;
            // 
            // txtCPF
            // 
            this.txtCPF.ForeColor = System.Drawing.Color.Gray;
            this.txtCPF.Location = new System.Drawing.Point(16, 87);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Placeholder = "CPF";
            this.txtCPF.Size = new System.Drawing.Size(203, 22);
            this.txtCPF.TabIndex = 14;
            this.txtCPF.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(228, 87);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Placeholder = "Email";
            this.txtEmail.Size = new System.Drawing.Size(400, 22);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "Email";
            // 
            // txTelefone
            // 
            this.txTelefone.ForeColor = System.Drawing.Color.Gray;
            this.txTelefone.Location = new System.Drawing.Point(16, 135);
            this.txTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txTelefone.Name = "txTelefone";
            this.txTelefone.Placeholder = "Telefone";
            this.txTelefone.Size = new System.Drawing.Size(203, 22);
            this.txTelefone.TabIndex = 12;
            this.txTelefone.Text = "Telefone";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtSalario);
            this.groupBox3.Controls.Add(this.txtCTPS);
            this.groupBox3.Controls.Add(this.txtCargo);
            this.groupBox3.Controls.Add(this.comboBoxStatus);
            this.groupBox3.Location = new System.Drawing.Point(16, 444);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(640, 132);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Profissionais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "CTPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cargo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status";
            // 
            // txtSalario
            // 
            this.txtSalario.ForeColor = System.Drawing.Color.Gray;
            this.txtSalario.Location = new System.Drawing.Point(304, 94);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Placeholder = "Salário";
            this.txtSalario.Size = new System.Drawing.Size(171, 22);
            this.txtSalario.TabIndex = 3;
            this.txtSalario.Text = "Salário";
            // 
            // txtCTPS
            // 
            this.txtCTPS.ForeColor = System.Drawing.Color.Gray;
            this.txtCTPS.Location = new System.Drawing.Point(8, 94);
            this.txtCTPS.Margin = new System.Windows.Forms.Padding(4);
            this.txtCTPS.Name = "txtCTPS";
            this.txtCTPS.Placeholder = "CTPS";
            this.txtCTPS.Size = new System.Drawing.Size(287, 22);
            this.txtCTPS.TabIndex = 2;
            this.txtCTPS.Text = "CTPS";
            // 
            // txtCargo
            // 
            this.txtCargo.ForeColor = System.Drawing.Color.Gray;
            this.txtCargo.Location = new System.Drawing.Point(231, 46);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Placeholder = "Cargo";
            this.txtCargo.Size = new System.Drawing.Size(397, 22);
            this.txtCargo.TabIndex = 1;
            this.txtCargo.Text = "Cargo";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(8, 44);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(213, 24);
            this.comboBoxStatus.TabIndex = 0;
            // 
            // svEndereco1
            // 
            this.svEndereco1.BackColor = System.Drawing.Color.Transparent;
            this.svEndereco1.Bairro = "";
            this.svEndereco1.CEP = "";
            this.svEndereco1.Complemento = "";
            this.svEndereco1.Endereco = "";
            this.svEndereco1.Location = new System.Drawing.Point(13, 251);
            this.svEndereco1.Name = "svEndereco1";
            this.svEndereco1.Numero = "";
            this.svEndereco1.Pais = null;
            this.svEndereco1.Size = new System.Drawing.Size(647, 183);
            this.svEndereco1.TabIndex = 17;
            // 
            // FuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(677, 647);
            this.Controls.Add(this.svEndereco1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FuncionarioForm";
            this.Text = "FuncionarioForm";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.svEndereco1, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.svHeader, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private SvTextBox txtCPF;
        private SvTextBox txtEmail;
        private SvTextBox txTelefone;
        private SvTextBox txtSobrenome;
        private SvTextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private SvTextBox txtCargo;
        private SvTextBox txtSalario;
        private SvTextBox txtCTPS;
        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SvEndereco svEndereco1;
    }
}