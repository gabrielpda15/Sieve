using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sieve.Controles
{
    public partial class SvForm<TEntity> : Form where TEntity : class
    {
        public delegate void InitializeHandler();

        protected SvButton btnSubmit;
        protected SvButton btnCancel;
        protected SvHeader svHeader;

        protected EntityValidator<TEntity> Validator { get; }

        public SvForm() : this("Ok", typeof(TEntity).Name, null) { }

        public SvForm(string submitText, string title, TEntity entity)
        {
            InitializeComponent();

            this.Validator = new EntityValidator<TEntity>();

            this.svHeader.Title = title;

            this.btnSubmit.Text = submitText;
            if (submitText == null) this.btnSubmit.Visible = false;

            if (entity != null) this.SetEntity(entity);

            this.btnCancel.Click += OnCancel;
            this.btnSubmit.Click += OnSubmit;
        }

        protected virtual void OnSubmit(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        protected virtual TEntity GetEntity()
        {
            return null;
        }

        protected virtual void SetEntity(TEntity entity)
        {

        }

        protected virtual void OnCancel(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void InitializeComponent()
        {
            this.btnSubmit = new SvButton();
            this.btnCancel = new SvButton();
            this.svHeader = new SvHeader();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnSubmit.BackColor = Color.FromArgb(129, 230, 217);
            this.btnSubmit.FlatAppearance.MouseDownBackColor = Color.FromArgb(79, 209, 197);
            this.btnSubmit.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 245, 234);
            this.btnSubmit.FlatStyle = FlatStyle.Flat;
            this.btnSubmit.Location = new Point(307, 394);
            this.btnSubmit.Margin = new Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new Size(180, 43);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.btnCancel.BackColor = Color.FromArgb(129, 230, 217);
            this.btnCancel.DialogResult = DialogResult.Cancel;
            this.btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(79, 209, 197);
            this.btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 245, 234);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Location = new Point(13, 394);
            this.btnCancel.Margin = new Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(180, 43);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Voltar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // svHeader1
            // 
            this.svHeader.BackColor = Color.FromArgb(220, 220, 255);
            this.svHeader.Dock = DockStyle.Top;
            this.svHeader.Location = new Point(0, 0);
            this.svHeader.Margin = new Padding(4);
            this.svHeader.Name = "svHeader1";
            this.svHeader.Size = new Size(500, 41);
            this.svHeader.TabIndex = 2;
            this.svHeader.Title = "";
            // 
            // SvForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(230, 255, 250);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.ControlBox = false;
            this.Controls.Add(this.svHeader);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SvForm";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SvForm";
            this.ResumeLayout(false);
        }
    }
}
