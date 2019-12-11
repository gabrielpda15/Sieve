using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sieve.Models.Location;

namespace Sieve.Controles
{
    public partial class SvEndereco : UserControl
    {
        public string CEP { get => this?.txtCep?.Value; set => this?.txtCep?.SetValue(value); }
        public string Endereco { get => this?.txtEndereco?.Value; set => this?.txtEndereco?.SetValue(value); }
        public string Numero { get => this?.txtNumero?.Value; set => this?.txtNumero?.SetValue(value); }
        public string Bairro { get => this?.txtBairro?.Value; set => this?.txtBairro?.SetValue(value); }
        public string Complemento { get => this?.txtComplemento?.Value; set => this?.txtComplemento?.SetValue(value); }
        public City Cidade { get => ((City)this?.comboBoxCidade?.SelectedItem); set => SetCity(value); }
        public Models.Location.Region Estado { get => ((Models.Location.Region)this?.comboBoxEstado?.SelectedItem); set => SetRegion(value); }
        public Country Pais { get => ((Country)this?.comboBoxPais?.SelectedItem); set => SetCountry(value); }

        public SvEndereco()
        {
            InitializeComponent();

            this.comboBoxPais.SelectedIndexChanged += ComboBoxPais_SelectedIndexChanged;
            this.comboBoxEstado.SelectedIndexChanged += ComboBoxEstado_SelectedIndexChanged;
        }

        private void SetCountry(Country country)
        {
            if (comboBoxPais.Items.Contains(country))
            {
                comboBoxPais.SelectedItem = country;
            }
        }

        private void SetRegion(Models.Location.Region region)
        {
            if (comboBoxEstado.Items.Contains(region))
            {
                comboBoxEstado.SelectedItem = region;
            }
        }

        private void SetCity(City city)
        {
            if (comboBoxCidade.Items.Contains(city))
            {
                comboBoxCidade.SelectedItem = city;
            }
        }

        public void InitializeData()
        {
            var countries = Program.ApiManager.GetAsync<IEnumerable<Country>>("Location/Countries", Program.Data.Token).GetAwaiter().GetResult();
            this.comboBoxPais.Items.AddRange(countries.ToArray());
        }

        private void ComboBoxPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxEstado.Items.Clear();
            var countryId = ((Country)this.comboBoxPais.SelectedItem).Id;
            var regions = Program.ApiManager.GetAsync<IEnumerable<Models.Location.Region>>("Location/Regions/" + countryId, Program.Data.Token).GetAwaiter().GetResult();
            this.comboBoxEstado.Items.AddRange(regions.ToArray());
        }

        private void ComboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxCidade.Items.Clear();
            var regionId = ((Models.Location.Region)this.comboBoxEstado.SelectedItem).Id;
            var cities = Program.ApiManager.GetAsync<IEnumerable<City>>("Location/Cities/" + regionId, Program.Data.Token).GetAwaiter().GetResult();
            this.comboBoxCidade.Items.AddRange(cities.ToArray());
        }
    }
}
