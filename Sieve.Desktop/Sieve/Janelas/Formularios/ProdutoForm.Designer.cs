namespace Sieve.Janelas.Formularios
{
    partial class ProdutoForm
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.imgMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSetImage = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxSecao = new System.Windows.Forms.ComboBox();
            this.txtNome = new Sieve.Controles.SvTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new Sieve.Controles.SvTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.imgMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSubmit.Location = new System.Drawing.Point(296, 569);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnCancel.Location = new System.Drawing.Point(20, 569);
            // 
            // svHeader
            // 
            this.svHeader.Logo = global::Sieve.Properties.Resources.icon;
            this.svHeader.Size = new System.Drawing.Size(491, 41);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.ContextMenuStrip = this.imgMenuStrip;
            this.pictureBox.Location = new System.Drawing.Point(134, 59);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(230, 230);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // imgMenuStrip
            // 
            this.imgMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.imgMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetImage});
            this.imgMenuStrip.Name = "imgMenuStrip";
            this.imgMenuStrip.Size = new System.Drawing.Size(181, 28);
            // 
            // btnSetImage
            // 
            this.btnSetImage.Name = "btnSetImage";
            this.btnSetImage.Size = new System.Drawing.Size(180, 24);
            this.btnSetImage.Text = "Mudar Imagem";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(21, 367);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(224, 24);
            this.comboBoxCategoria.TabIndex = 5;
            // 
            // comboBoxSecao
            // 
            this.comboBoxSecao.FormattingEnabled = true;
            this.comboBoxSecao.Location = new System.Drawing.Point(255, 367);
            this.comboBoxSecao.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSecao.Name = "comboBoxSecao";
            this.comboBoxSecao.Size = new System.Drawing.Size(224, 24);
            this.comboBoxSecao.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.Color.Gray;
            this.txtNome.Location = new System.Drawing.Point(20, 315);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Placeholder = "Nome";
            this.txtNome.Size = new System.Drawing.Size(457, 22);
            this.txtNome.TabIndex = 7;
            this.txtNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 295);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 343);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seção";
            // 
            // txtDescricao
            // 
            this.txtDescricao.ForeColor = System.Drawing.Color.Gray;
            this.txtDescricao.Location = new System.Drawing.Point(20, 428);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Placeholder = "Descrição";
            this.txtDescricao.Size = new System.Drawing.Size(456, 123);
            this.txtDescricao.TabIndex = 11;
            this.txtDescricao.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 405);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descrição";
            // 
            // openFileDialog
            // 
            this.openFileDialog.AddExtension = false;
            this.openFileDialog.Filter = "Imagens (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.p" +
    "ng|Todos os Arquivos|*.*";
            this.openFileDialog.Title = "Selecionar Imagem";
            // 
            // ProdutoForm
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.CancelButton = null;
            this.ClientSize = new System.Drawing.Size(491, 625);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.comboBoxSecao);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProdutoForm";
            this.Text = "ProdutoForm";
            this.Controls.SetChildIndex(this.pictureBox, 0);
            this.Controls.SetChildIndex(this.comboBoxCategoria, 0);
            this.Controls.SetChildIndex(this.comboBoxSecao, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.svHeader, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.imgMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxSecao;
        private Controles.SvTextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controles.SvTextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip imgMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnSetImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}