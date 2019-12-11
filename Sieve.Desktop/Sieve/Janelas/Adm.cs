using MetroFramework.Controls;
using Sieve.Controles;
using Sieve.Janelas.Formularios;
using Sieve.Models.Person;
using Sieve.Models.Sales;
using Sieve.Models.Security;
using Sieve.Models.Storage;
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
    public partial class Adm : Form
    {
        private bool gridLoaded = false;
        private readonly IDictionary<string, Type> forms;
        private string currentType = "";

        public Adm()
        {
            InitializeComponent();

            forms = new Dictionary<string, Type>
            {
                { "client", typeof(ClienteForm) },
                { "supplier", typeof(FornecedorForm) },
                { "employee", typeof(FuncionarioForm) },
                { "product", typeof(ProdutoForm) }
            };

            this.btnLogout.Click += BtnLogout_Click;
            this.clientMenuItem.Click += MenuItem_Click;
            this.cardMenuItem.Click += MenuItem_Click;
            this.orderMenuItem.Click += MenuItem_Click;
            this.supplierMenuItem.Click += MenuItem_Click;
            this.employeeMenuItem.Click += MenuItem_Click;
            this.identityMenuItem.Click += MenuItem_Click;
            this.roleMenuItem.Click += MenuItem_Click;
            this.productMenuItem.Click += MenuItem_Click;
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (!gridLoaded) CreateHud();
            LoadData(((ToolStripMenuItem)sender).Name.Replace("MenuItem", ""));
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void LoadData(string sender)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.Columns.Add("id", "Id");
            currentType = sender;

            switch (sender)
            {
                case "client":
                    var clientData = GetDataAsync<Client>(sender).GetAwaiter().GetResult();
                    
                    grid.Columns.Add(GetColumn("cpf", "CPF"));
                    grid.Columns.Add(GetColumn("name", "Nome"));
                    foreach (var client in clientData)
                    {
                        grid.Rows.Add(client.Id, client.CPF, $"{client.FirstName} {client.LastName}");
                    }
                    break;
                case "card":
                    var cardData = GetDataAsync<Card>(sender).GetAwaiter().GetResult();
                    break;
                case "order":
                    var orderData = GetDataAsync<Order>(sender).GetAwaiter().GetResult();
                    break;
                case "supplier":
                    var supplierData = GetDataAsync<Supplier>(sender).GetAwaiter().GetResult();
                    break;
                case "employee":
                    var employeeData = GetDataAsync<Employee>(sender).GetAwaiter().GetResult();
                    break;
                case "identity":
                    var identityData = GetDataAsync<Identity>(sender).GetAwaiter().GetResult();
                    break;
                case "role":
                    var roleData = GetDataAsync<Role>(sender).GetAwaiter().GetResult();
                    break;
                case "product":
                    var productData = GetDataAsync<Product>(sender).GetAwaiter().GetResult();
                    break;
                default:
                    break;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            Form form = null;

            switch (currentType)
            {
                case "client":
                    var client = GetEntityAsync<Client>(currentType, (string)this.grid.SelectedRows[0].Cells[0].Value)
                        .GetAwaiter().GetResult();
                    form = (Form)Activator.CreateInstance(forms[currentType], "", client);
                    form.ShowDialog();
                    break;
                case "card":
                    
                    break;
                case "order":
                    
                    break;
                case "supplier":
                    
                    break;
                case "employee":
                    
                    break;
                case "identity":
                    
                    break;
                case "role":
                    
                    break;
                case "product":
                    
                    break;
                default:
                    break;
            }
        }

        private DataGridViewColumn GetColumn(string name, string headerText)
        {
            return new DataGridViewTextBoxColumn()
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                HeaderText = headerText,
                Name = name
            };
        }

        private async Task<IEnumerable<TEntity>> GetDataAsync<TEntity>(string sender) where TEntity : class
        {
            return await Program.ApiManager.GetAsync<IEnumerable<TEntity>>(sender, Program.Data.Token).ConfigureAwait(false);
        }

        private async Task<TEntity> GetEntityAsync<TEntity>(string sender, string id) where TEntity : class
        {
            return await Program.ApiManager.GetAsync<TEntity>(sender + "/getbyid/" + id, Program.Data.Token)
                .ConfigureAwait(false);
        }

        #region HUD

        private SvButton btnSearch;
        private SvTextBox txtSearch;
        private SvButton btnAdd;
        private MetroGrid grid;
        private MetroContextMenu gridMenu;
        private ToolStripMenuItem btnDetails;
        private ToolStripMenuItem btnEdit;
        private ToolStripMenuItem btnDelete;

        private void CreateHud()
        {
            this.content.SuspendLayout();
            this.SuspendLayout();

            this.grid = new MetroGrid();
            this.btnAdd = new SvButton();
            this.txtSearch = new SvTextBox();
            this.btnSearch = new SvButton();
            this.gridMenu = new MetroContextMenu(null);
            this.btnEdit = new ToolStripMenuItem();
            this.btnDelete = new ToolStripMenuItem();
            this.btnDetails = new ToolStripMenuItem();

            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.gridMenu.SuspendLayout();

            // 
            // grid
            // 
            var dataGridViewCellStyle1 = new DataGridViewCellStyle();
            var dataGridViewCellStyle2 = new DataGridViewCellStyle();
            var dataGridViewCellStyle3 = new DataGridViewCellStyle();
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.MultiSelect = false;
            this.grid.ReadOnly = true;
            this.grid.ContextMenuStrip = this.gridMenu;
            this.grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.grid.BackgroundColor = Color.FromArgb(255, 255, 255);
            this.grid.BorderStyle = BorderStyle.None;
            this.grid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.Location = new System.Drawing.Point(12, 76);
            this.grid.Name = "grid";
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(776, 329);
            this.grid.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(230)))), ((int)(((byte)(217)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(688, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 22);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Incluir";
            this.btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(12, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Placeholder = "";
            this.txtSearch.Size = new System.Drawing.Size(285, 22);
            this.txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(230)))), ((int)(((byte)(217)))));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(303, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 22);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Procurar";
            this.btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // gridMenu
            // 
            this.gridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDetails,
            this.btnEdit,
            this.btnDelete});
            this.gridMenu.Name = "gridMenu";
            this.gridMenu.Size = new System.Drawing.Size(181, 92);
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 22);
            this.btnEdit.Text = "Editar";
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 22);
            this.btnDelete.Text = "Excluir";
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnDetails
            // 
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(180, 22);
            this.btnDetails.Text = "Ver";
            btnDetails.Click += BtnDetails_Click;


            this.content.Controls.Add(this.btnSearch);
            this.content.Controls.Add(this.txtSearch);
            this.content.Controls.Add(this.btnAdd);
            this.content.Controls.Add(this.grid);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.gridMenu.ResumeLayout(false);


            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

            this.gridLoaded = true;
        }

        #endregion

    }
}
