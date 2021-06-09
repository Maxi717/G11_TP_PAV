using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G11_TP_PAV.Clases
{
    public class ComboBoxHeredadaG: ComboBox
    {
        public string Pp_Pk { get; set; }
        public string Pp_descripcion { get; set; }
        public string Pp_Tabla { get; set; }

        /// <summary>
        /// Nombre de la tabla en la que actuará el dato ante un comando de insert
        /// </summary>
        public string Pp_NombreTabla { get; set; }
        /// <summary>
        /// Nombre del campo en el actuará el dato dentro de la tabla
        /// </summary>
        public string Pp_campo { get; set; }

        public bool Pp_Conseleccion { get; set; }
        public bool Pp_Validable { get; set; }
        public string Pp_MensajeError { get; set; }

        public string Pp_combinada01 { get; set; }
        public string Pp_combinada02 { get; set; }
        public string Pp_valorSelec { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void CargarCombo()
        {
            string sql = "SELECT " + Pp_Pk + ", " + Pp_descripcion + " FROM " + Pp_Tabla;
            this.DisplayMember = Pp_descripcion;
            this.ValueMember = Pp_Pk;
            this.DataSource = _BD.Consulta(sql);
            if (this.Pp_Conseleccion == true)
            {
                this.SelectedIndex = 0;
            }
            else
            {
                this.SelectedIndex = -1;
            }
        }

        public void CargarDobleCombo(string id)
        {
            string sql = "SELECT " + Pp_Pk + ", " + Pp_combinada01 + ", " + Pp_combinada02 + " FROM " + Pp_Tabla + " WHERE " + id + "=" + Pp_valorSelec;
            this.DisplayMember = "depto";
            this.ValueMember = Pp_Pk;
            DataTable tabla = _BD.Consulta(sql);
            tabla.Columns.Add("depto", typeof(string), "piso + ' ' + denominacion");
            this.DataSource = tabla;
        }

        public void CargarComboFecha(string id)
        {
            string sql = "SELECT " + Pp_Pk + ", " + Pp_combinada01 + ", " + Pp_combinada02 + " FROM " + Pp_Tabla + " r JOIN expensas e ON r.numero_expensa=e.numero_expensa WHERE e." + id + "=" + Pp_valorSelec;
            this.DisplayMember = "fecha";
            this.ValueMember = Pp_Pk;
            DataTable tabla = _BD.Consulta(sql);
            tabla.Columns.Add("fecha", typeof(string), "mes + ' ' + anio");
            this.DataSource = tabla;
        }
    }
}
