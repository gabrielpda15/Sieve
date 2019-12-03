using Sieve.Models.Relations;
using Sieve.Models.Security;
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

namespace Sieve
{
    public partial class Login : Form
    {
        private User Result { get; set; }
        private EntityValidator<User> Validator { get; }

        public Login()
        {
            InitializeComponent();

            this.Validator = new EntityValidator<User>();

            this.btnLogin.Click += BtnLogin_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }

        public DialogResult ShowDialog(out Identity user)
        {
            var result = this.ShowDialog();
            user = new Identity
            {
                Roles = new[]
                {
                    new RIdentityRole { Role = new Role { Description = "EstoqueAdm" } },
                    new RIdentityRole { Role = new Role { Description = "VendasAdm" } }
                }
            };
            return result;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Result = null;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Result = new User
            {
                Username = this.txtUsername.Text,
                Password = this.txtPassword.Text
            };

            if (!this.Validator.Validate(this.Result, out var erros))
            {
                
            }

            this.DialogResult = DialogResult.OK;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
