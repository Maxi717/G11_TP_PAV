using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using G11_TP_PAV.Formularios;

namespace G11_TP_PAV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Frm_Escritorio());
            Application.Run(new Formularios.TransRecibos.Frm_Transaccion_Recibos());
        }
    }
}
