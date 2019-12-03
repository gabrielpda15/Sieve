using Sieve.Models.Location;
using Sieve.Models.Person;
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
    public partial class ClienteForm : Form
    {
        private EntityValidator<Client> Validator { get; }
        public ClienteForm()
        {
            InitializeComponent();
            this.Validator = new EntityValidator<Client>();
            this.btnEnviar.Click += BtnEnviar_Click;
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            var cliente = new Client
            {
                FirstName = txtNome.Text,
                LastName = txtSobrenome.Text,
                CPF = txtCPF.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtTelefone.Text,
                AddressObj = new Address
                {
                    PostalCode = txtCep.Text,
                    Street = txtEndereco.Text,
                    Number = txtNumero.Text,
                    Neighborhood = txtBairro.Text,
                    City = (City)comboBoxCidade.SelectedItem,
                    Region = (Models.Location.Region)comboBoxEstado.SelectedItem,
                    Country = (Country)comboBoxPais.SelectedItem,
                    Complement = txtComplemento.Text
                }
            };

            if(!this.Validator.Validate(cliente, out var errors))
            {
                MessageBox.Show(errors.FirstOrDefault().Value.FirstOrDefault().Value, 
                    errors.FirstOrDefault().Value.FirstOrDefault().Key,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
