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
    public class Header : Panel
    {
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

        public Header() : base()
        {
            InitializeComponent();
        }


        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnClose = new Button();
            this.btnMinimize = new Button();
            this.logo = new PictureBox();
            this.title = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
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
            this.btnClose.Location = new Point(770, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(27, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
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
            this.btnMinimize.Location = new Point(741, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new Size(27, 27);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(27, 27);
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // title
            // 
            this.title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.title.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.title.Location = new Point(36, 3);
            this.title.Name = "title";
            this.title.Size = new Size(699, 27);
            this.title.TabIndex = 5;
            this.title.TextAlign = ContentAlignment.MiddleLeft;


            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
        }

        private Button btnClose;
        private Button btnMinimize;
        private PictureBox logo;
        private Label title;
    }
}
