using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sieve.Controles
{
    public class SvButton : Button
    {

        public SvButton() : base()
        {
            this.BackColor = Color.FromArgb(129, 230, 217);
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(79, 209, 197);
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 245, 234);
            this.FlatStyle = FlatStyle.Flat;
            this.Size = new Size(135, 35);
            this.UseVisualStyleBackColor = false;
        }

    }
}
