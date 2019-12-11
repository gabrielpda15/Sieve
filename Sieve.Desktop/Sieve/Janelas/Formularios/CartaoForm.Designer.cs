namespace Sieve.Janelas.Formularios
{
    partial class CartaoForm
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
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            // 
            // svHeader
            // 
            this.svHeader.Logo = global::Sieve.Properties.Resources.icon;
            // 
            // CartaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Name = "CartaoForm";
            this.Text = "CartaoForm";
            this.ResumeLayout(false);

        }

        #endregion
    }
}