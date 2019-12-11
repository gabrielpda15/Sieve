using Sieve.Controles;
using Sieve.Models.Person;
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
    public partial class FuncionarioForm : SvForm<Employee>
    {
        public FuncionarioForm()
        {
            InitializeComponent();
        }

        public FuncionarioForm(string submitText, string title, Employee entity) : base(submitText, title, entity)
        {
            InitializeComponent();
        }
    }
}
