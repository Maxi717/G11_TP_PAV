using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace G11_TP_PAV.Clases
{
    class ComboBoxHeredada : ComboBox
    {

        public string Pp_Pk { get; set; }
        public string Pp_descripcion { get; set; }
        public string Pp_tabla_origen { get; set; }

        public string Pp_combinada01 { get; set; }
        public string Pp_combinada02 { get; set; }
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void CargarCombo(string sql)
        {
            ///string sql = "SELECT " + Pp_Pk + ", " + Pp_descripcion + " FROM " + Pp_tabla_origen;
            this.DisplayMember = Pp_descripcion;
            this.ValueMember = Pp_Pk;
            this.DataSource = _BD.Consulta(sql);
        }

        //public void CargarDobleCombo(string sql, int edificio)
        //{
        //    //formato sql = "SELECT "+ Pp_Pk +", " + Pp_combinada01 + ", " + Pp_combinada02 " FROM " + Pp_tabla_origen
        //    this.DisplayMember = Pp_combinada01 + ", " + Pp_combinada02;
        //    this.ValueMember = edificio;
        //    this.DataSource = _BD.Consulta(sql);
        //}
    }
}
