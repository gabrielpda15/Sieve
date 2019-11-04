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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();

            metroGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            metroGrid.Columns.Add("c1", "Coluna 1");
            metroGrid.Columns.Add("c2", "Coluna 2");
            metroGrid.Columns.Add("c3", "Coluna 3");

            metroGrid.Rows.Add("Teste", "Teste 2", "Teste 3");
            metroGrid.Rows.Add("Teste", "Teste 2", "Teste 3");
            metroGrid.Rows.Add("Teste", "Teste 2", "Teste 3");
            metroGrid.Rows.Add("Teste", "Teste 2", "Teste 3");
            metroGrid.Rows.Add("Teste", "Teste 2", "Teste 3");
            metroGrid.Rows.Add("Teste", "Teste 2", "Teste 3");
            metroGrid.Rows.Add("Teste", "Teste 2", "Teste 3");
            metroGrid.Rows.Add("Teste", "Teste 2", "Teste 3");
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
