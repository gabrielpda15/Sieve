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
        private string Token { get; set; }
        private EntityValidator<User> Validator { get; }

        public Login()
        {
            InitializeComponent();

            this.Validator = new EntityValidator<User>();

            this.btnLogin.Click += BtnLogin_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }

        public DialogResult ShowDialog(out Identity user, out string token)
        {
            var result = this.ShowDialog();

            user = Program.ApiManager.GetAsync<Identity>("identity/getidentity", this.Token).GetAwaiter().GetResult();
            token = Token;

            return result;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Result = null;
        }

        public class LoginResponse
        {
            public bool Authenticated { get; set; } = false;
            public string Token { get; set; } = null;
            public DateTime? Expiration { get; set; } = null;
            public string Error { get; set; } = null;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Result = new User
            {
                Username = this.txtUsername.Value,
                Password = this.txtPassword.Value
            };

            if (!this.Validator.Validate(this.Result, out var erros))
            {
                lbError.Text = erros.FirstOrDefault().Value.FirstOrDefault().Value;
                return;
            }

            var response = Program.ApiManager.PostAsync<LoginResponse, User>("login", this.Result, expectSuccess: false).GetAwaiter().GetResult();

            if (response == null)
            {
                lbError.Text = "Erro desconhecido!";
                return;
            }

            if (!response.Authenticated)
            {
                lbError.Text = response.Error;
                return;
            }

            this.Token = response.Token;

            this.DialogResult = DialogResult.OK;
        }
    }
}
