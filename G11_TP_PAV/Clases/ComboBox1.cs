using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G11_TP_PAV.Clases;
using System.Data;


namespace G11_TP_PAV.Clases
{
    class ComboBox1:ComboBox
    {
        public string Pp_Pk { get; set; }
        public string Pp_descripcion { get; set; }
        public string Pp_tabla { get; set; }
        public bool Pp_Conseleccion { get; set; }
        BE_Edificios _BD = new BE_Edificios();

        public void CargarCombo()
        {
            string sql = "SELECT " + Pp_Pk + " , " + Pp_descripcion + " FROM " + Pp_tabla;
	        this.DisplayMember = Pp_descripcion;
	        this.ValueMember = Pp_Pk;
            this.DataSource = _BD.Ejecutar_Select(sql);

        }


    }
}
