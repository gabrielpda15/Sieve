using Sieve.Controles;
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
    public partial class ClienteForm : SvForm<Client>
    {
        public Client Result { get; private set; }

        public ClienteForm() : base()
        {
            InitializeComponent();
        }

        public ClienteForm(string submitText, string title, Client client = null) : base(submitText, title, client)
        {
            InitializeComponent();
            this.endereco.InitializeData();
        }

        protected override void OnSubmit(object sender, EventArgs e)
        {
            var client = GetEntity();

            if (!this.Validator.Validate(client, out var errors))
            {
                MessageBox.Show(errors.FirstOrDefault().Value.FirstOrDefault().Value,
                    errors.FirstOrDefault().Value.FirstOrDefault().Key,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Result = client;
            this.DialogResult = DialogResult.OK;
        }

        protected override void OnCancel(object sender, EventArgs e)
        {
            Result = null;
            base.OnCancel(sender, e);
        }

        protected override void SetEntity(Client entity)
        {
            txtNome.SetValue(entity.FirstName);
            txtSobrenome.SetValue(entity.LastName);
            txtCPF.SetValue(entity.CPF);
            txtEmail.SetValue(entity.Email);
            txtTelefone.SetValue(entity.PhoneNumber);
            endereco.CEP = entity.AddressObj.PostalCode;
            endereco.Endereco = entity.AddressObj.Street;
            endereco.Numero = entity.AddressObj.Number;
            endereco.Bairro = entity.AddressObj.Neighborhood;
            endereco.Complemento = entity.AddressObj.Complement;
            endereco.Pais = entity.AddressObj.Country;
            endereco.Estado = entity.AddressObj.Region;
            endereco.Cidade = entity.AddressObj.City;
        }

        protected override Client GetEntity()
        {
            return new Client
            {
                FirstName = txtNome.Value,
                LastName = txtSobrenome.Value,
                CPF = txtCPF.Value,
                Email = txtEmail.Value,
                PhoneNumber = txtTelefone.Value,
                AddressObj = new Address
                {
                    PostalCode = endereco.CEP,
                    Street = endereco.Endereco,
                    Number = endereco.Numero,
                    Neighborhood = endereco.Bairro,
                    City = endereco.Cidade,
                    Region = endereco.Estado,
                    Country = endereco.Pais,
                    Complement = endereco.Complemento,
                }
            };
        }
    }
}
