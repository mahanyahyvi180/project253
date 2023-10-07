using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp125
{
   public class Next: System.Windows.Forms.TextBox
    {

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)(e.KeyChar) != 8)

                e.Handled = true;
            base.OnKeyPress(e);
        }
    }
}
