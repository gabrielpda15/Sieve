using Sieve.Janelas;
using Sieve.Janelas.Formularios;
using Sieve.Models.Person;
using Sieve.Models.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sieve
{
    static class Program
    {
        private static IDictionary<string, string[]> Permissions { get; } = new Dictionary<string, string[]>();
        private static IDictionary<string, Form> Screens { get; } = new Dictionary<string, Form>();

        public static ProgramData Data { get; } = new ProgramData();
        public static ApiManager ApiManager { get; private set; }

        private static void InitData()
        {
            Permissions.Add("--vendas", new string[] { "Vendas", "VendasAdm" });
            Permissions.Add("--estoque", new string[] { "Estoque", "EstoqueAdm" });
            Permissions.Add("--adm", new string[] { "VendasAdm", "EstoqueAdm" });

            Screens.Add("--vendas", new Vendas());
            Screens.Add("--estoque", new Estoque());
            Screens.Add("--adm", new Adm());

            ApiManager = new ApiManager("http://localhost/", "SieveAPI/");            
        }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitData();



            if (!ApiManager.CheckHealth("health").GetAwaiter().GetResult())
            {
                MessageBox.Show("Servidor Offline", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (args.Length == 0)
            {
                MessageBox.Show("Inicie o programa com um parametro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (args.Length > 2)
            {
                MessageBox.Show("A inicialização do programa apenas requer um ou dois parametros!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Data.Fullscreen = args.Contains("--fullscreen");

            using (var login = new Login())
            {
                if (login.ShowDialog(out var user, out string token) == DialogResult.OK)
                {
                    if (Permissions.ContainsKey(args.FirstOrDefault()))
                    {
                        if (user.Roles.Select(x => x.Role.Description).Any(x => Permissions[args.FirstOrDefault()].Contains(x)))
                        {
                            Data.User = user;
                            Data.Token = token;
                            Data.Employee = ApiManager.GetAsync<Employee>("employee/getbyuser/" + user.Id, token).GetAwaiter().GetResult();

                            Application.Run(new ClienteForm("Ok", "Ver Cliente"));
                            Application.Run(Screens[args.FirstOrDefault()]);
                        }
                    }
                }
            }

        }
    }

    public class ProgramData
    {
        public string Token { get; set; }
        public Identity User { get; set; }
        public Employee Employee { get; set; }
        public bool Fullscreen { get; set; }
    }
}
