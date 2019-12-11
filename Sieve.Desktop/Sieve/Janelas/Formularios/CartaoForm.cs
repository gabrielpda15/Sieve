using Sieve.Controles;
using Sieve.Models.Sales;
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
    public partial class CartaoForm : SvForm<Card>
    {
        public CartaoForm() : base() { }

        public CartaoForm(string submitText, string title, Card entity) : base(submitText, title, entity)
        {            
            InitializeComponent();
        }

        protected override void OnSubmit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override Card GetEntity()
        {
            throw new NotImplementedException();
        }        

        protected override void SetEntity(Card entity)
        {
            throw new NotImplementedException();
        }
    }
}
