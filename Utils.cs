using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nomina
{
    using CustomControls.RJControls;
    using System;
    using System.Windows.Forms;

    public class Utils
    {
        public static void SoloNumeros ( RJTextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    MessageBox.Show("Por favor, ingrese solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                }
            };
        }
    }

}
