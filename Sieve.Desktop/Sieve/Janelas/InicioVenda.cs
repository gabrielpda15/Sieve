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

namespace Sieve.Janelas
{
    public partial class InicioVenda : Form
    {
        public string CPF { get => this?.txtCpf?.Text; }
        public bool? CPFNaNota { get => this?.checkBoxNotaCPF?.Checked; }

        public InicioVenda()
        {
            InitializeComponent();
            this.TopMost = true;

            this.btnOk.Click += BtnOk_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private class Obj
        {
            [Required]
            [CPF]
            [Display("CPF")]
            public string CPF { get; set; }
        } 

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var obj = new Obj { CPF = txtCpf.Value };
            var validator = new EntityValidator<Obj>();
            if (validator.Property(x => x.CPF).Validate(obj, out var errors))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.lbError.Text = errors.FirstOrDefault().Value;
            }
        }
    }
}
