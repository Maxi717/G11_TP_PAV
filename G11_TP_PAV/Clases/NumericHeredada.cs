using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G11_TP_PAV.Clases
{
    class NumericHeredada: NumericUpDown
    {
        public string Pp_tabla { get; set; }
        public string Pp_campo { get; set; }
        public bool Pp_Validable { get; set; }
        public string Pp_MensajeError { get; set; }
    }
}
