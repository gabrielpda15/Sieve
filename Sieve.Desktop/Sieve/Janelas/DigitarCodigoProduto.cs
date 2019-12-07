﻿using System;
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
    public partial class DigitarCodigoProduto : Form
    {
        public DigitarCodigoProduto()
        {
            InitializeComponent();
            this.TopMost = true;

            this.btnPesquisar.Click += BtnPesquisar_Click;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            var result = new ConsultaProduto();
            this.Hide();
            result.ShowDialog();
            this.Show();
        }
    }
}
