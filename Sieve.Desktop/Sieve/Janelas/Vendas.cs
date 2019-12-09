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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();

            this.TopMost = Program.Data.Fullscreen;
            this.WindowState = FormWindowState.Maximized;
            this.timer.Tick += Timer_Tick;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F6))
            {
                var iniVenda = new InicioVenda();
                if (iniVenda.ShowDialog() == DialogResult.OK)
                {
                    this.lbCliente.Text = iniVenda.CPF;
                }
                return true;
            } else if (keyData == (Keys.F7))
            {
                var consulta = new DigitarCodigoProduto();
                consulta.ShowDialog();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            timer.Start();
            lbOperador.Text = Program.Data?.Employee?.FirstName;
        }
    }
}
