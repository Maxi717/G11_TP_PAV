using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G11_TP_PAV.Negocio;

namespace G11_TP_PAV.Formularios.CompraVenta
{
    public partial class Frm_BuscarPropiedad : Form
    {

        public string design_catastral { get; set; }

        public Frm_BuscarPropiedad()
        {
            InitializeComponent();
        }

        private void Frm_BuscarPropiedad_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            NE_Propiedades propiedad = new NE_Propiedades();

            DataTable tabla = new DataTable();
            tabla = propiedad.RecuperarTodos();
            CargarGrilla(tabla);
        }



        private void CargarGrilla(DataTable tabla)
        {
            gdr_Propiedades.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                gdr_Propiedades.Rows.Add();
                gdr_Propiedades.Rows[i].Cells["Design_Catastral"].Value = tabla.Rows[i]["designacion_catastral"].ToString();
                gdr_Propiedades.Rows[i].Cells["Tipo"].Value = tabla.Rows[i]["tipo"].ToString();
                gdr_Propiedades.Rows[i].Cells["Barrio"].Value = tabla.Rows[i]["barrio"].ToString();
                gdr_Propiedades.Rows[i].Cells["Calle"].Value = tabla.Rows[i]["calle"].ToString();
                gdr_Propiedades.Rows[i].Cells["Numero"].Value = tabla.Rows[i]["numero"].ToString();
            }
        }


        private void gdr_Propiedades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            design_catastral = gdr_Propiedades.CurrentRow.Cells["Design_Catastral"].Value.ToString();

            this.Close();


        }
    }
}
