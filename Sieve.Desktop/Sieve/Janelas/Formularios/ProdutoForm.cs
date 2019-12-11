using MetroFramework;
using Sieve.Controles;
using Sieve.Models.Storage;
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

namespace Sieve.Janelas.Formularios
{
    public partial class ProdutoForm : SvForm<Product>
    {

        public ProdutoForm(string submitText, string title, Product product = null) : base(submitText, title, product)
        {
            InitializeComponent();

            this.btnSetImage.Click += BtnSetImage_Click;
        }

        private void BtnSetImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var img = new Bitmap(openFileDialog.FileName);
                    pictureBox.Image = img;
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
