using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sieve.Controles
{
    public class SvHeader : Panel
    {
        protected Button btnClose;
        protected Button btnMinimize;
        protected PictureBox logo;
        protected Label title;

        [Browsable(true)]
        public string Title
        {
            get => this?.title?.Text;
            set { if (this?.title != null) this.title.Text = value; }
        }

        [Browsable(true)]
        public Image Logo
        {
            get => this?.logo?.Image;
            set { if (this?.logo != null) this.logo.Image = value; }
        }

        public SvHeader() : base()
        {
            InitializeComponent();
        }


        protected IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected virtual void BtnMinimize_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent).WindowState = FormWindowState.Minimized;
        }

        protected virtual void BtnClose_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent).Close();
        }

        private void InitializeComponent()
        {
            this.btnClose = new Button();
            this.btnMinimize = new Button();
            this.logo = new PictureBox();
            this.title = new Label();

            ((ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();

            // 
            // btnClose
            // 
            this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnClose.BackColor = Color.FromArgb(220, 80, 80);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 0, 0);
            this.btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 120, 120);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnClose.Location = new Point(1027, 4);
            this.btnClose.Margin = new Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(36, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new EventHandler(this.BtnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnMinimize.BackColor = Color.FromArgb(200, 200, 200);
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 180, 180);
            this.btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            this.btnMinimize.FlatStyle = FlatStyle.Flat;
            this.btnMinimize.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnMinimize.Location = new Point(988, 4);
            this.btnMinimize.Margin = new Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new Size(36, 33);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new EventHandler(this.BtnMinimize_Click);
            // 
            // logo
            // 
            this.logo.Location = new Point(4, 4);
            this.logo.Margin = new Padding(4, 4, 4, 4);
            this.logo.Name = "logo";
            this.logo.Size = new Size(36, 33);
            this.logo.SizeMode = PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            this.logo.MouseDown += Header_MouseDown;
            this.logo.MouseUp += Header_MouseUp;
            this.logo.MouseMove += Header_MouseMove;
            this.logo.MouseDoubleClick += Header_MouseDoubleClick;
            // 
            // title
            // 
            this.title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.title.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.title.Location = new Point(48, 4);
            this.title.Margin = new Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new Size(932, 33);
            this.title.TabIndex = 5;
            this.title.Text = "";
            this.title.TextAlign = ContentAlignment.MiddleLeft;
            this.title.MouseDown += Header_MouseDown;
            this.title.MouseUp += Header_MouseUp;
            this.title.MouseMove += Header_MouseMove;
            this.title.MouseDoubleClick += Header_MouseDoubleClick;

            // 
            // header
            // 
            this.BackColor = Color.FromArgb(220, 220, 255);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnMinimize);
            this.Dock = DockStyle.Top;
            this.Location = new Point(0, 0);
            this.Margin = new Padding(4, 4, 4, 4);
            this.Size = new Size(1067, 41);
            this.TabIndex = 2;

            this.MouseDown += Header_MouseDown;
            this.MouseUp += Header_MouseUp;
            this.MouseMove += Header_MouseMove;
            this.MouseDoubleClick += Header_MouseDoubleClick;

            ((ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
        }

        private void Header_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (((Form)this.Parent).WindowState == FormWindowState.Normal)
                    ((Form)this.Parent).WindowState = FormWindowState.Maximized;
                else
                    ((Form)this.Parent).WindowState = FormWindowState.Normal;
            }
        }

        protected bool isMouseDown;
        protected Point lastLocation;

        protected virtual void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Parent.Location = new Point(
                        (this.Parent.Location.X - lastLocation.X) + e.X, 
                        (this.Parent.Location.Y - lastLocation.Y) + e.Y
                    );
                this.Parent.Update();
            }
        }

        protected virtual void Header_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        protected virtual void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                lastLocation = e.Location;
            }
        }
    }
}
