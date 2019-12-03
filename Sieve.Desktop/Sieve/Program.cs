using Sieve.Janelas;
using Sieve.Janelas.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sieve
{
    static class Program
    {
        private static IDictionary<string, string[]> Permissions { get; } = new Dictionary<string, string[]>();
        private static IDictionary<string, Form> Screens { get; } = new Dictionary<string, Form>();

        private static void InitData()
        {
            Permissions.Add("--vendas", new string[] { "Vendas", "VendasAdm" });
            Permissions.Add("--estoque", new string[] { "Estoque", "EstoqueAdm" });

            Screens.Add("--vendas", new Vendas());
            Screens.Add("--estoque", new Estoque());
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

            if (args.Length == 0)
            {
                MessageBox.Show("Inicie o programa com um parametro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            else if (args.Length > 1)
            {
                MessageBox.Show("A inicialização do programa apenas requer um parametro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var login = new Login())
            {
                if (login.ShowDialog(out var user) == DialogResult.OK)
                {
                    if (Permissions.ContainsKey(args.Single()))
                    {
                        if (user.Roles.Select(x => x.Role.Description).Any(x => Permissions[args.Single()].Contains(x)))
                        {
                            Application.Run(Screens[args.Single()]);
                        }
                    }
                }
            }            
        }
    }
}
