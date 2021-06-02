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

namespace G11_TP_PAV.Formularios
{
    public partial class Frm_Borrar_Propiedades : Form
    {
        public string designacionCatastral { get; set; }

        NE_Propiedades propiedad = new NE_Propiedades();

        public Frm_Borrar_Propiedades()
        {
            InitializeComponent();
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_designacion.Text = tabla.Rows[0]["designacion_catastral"].ToString();
            txt_calle.Text = tabla.Rows[0]["calle"].ToString();
            txt_numero.Text = tabla.Rows[0]["numero"].ToString();
            txt_piso.Text = tabla.Rows[0]["piso"].ToString();
            txt_departamento.Text = tabla.Rows[0]["departamento"].ToString();
            txt_barrio.Text = tabla.Rows[0]["barrio"].ToString();
            txt_tipo.Text = tabla.Rows[0]["tipo"].ToString();
        }

        private void CargarGrillaAsociaciones(DataTable tabla)
        {
            DataTable tablaDuenio = new DataTable();
            NE_duenios duenio = new NE_duenios();

            grid_duenios.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                tablaDuenio = duenio.RecuperarDocumento(tabla.Rows[i]["documento"].ToString(), tabla.Rows[i]["tipo_documento"].ToString());
                grid_duenios.Rows.Add();
                grid_duenios.Rows[i].Cells[0].Value = tablaDuenio.Rows[0]["numero_documento"].ToString();
                grid_duenios.Rows[i].Cells[1].Value = tablaDuenio.Rows[0]["id_tipo_documento"].ToString();
                grid_duenios.Rows[i].Cells[2].Value = tablaDuenio.Rows[0]["tipo_documento_nombre"].ToString();
                grid_duenios.Rows[i].Cells[3].Value = tablaDuenio.Rows[0]["nombre"].ToString();
                grid_duenios.Rows[i].Cells[4].Value = tablaDuenio.Rows[0]["telefono"].ToString();
                grid_duenios.Rows[i].Cells[5].Value = tablaDuenio.Rows[0]["domicilio"].ToString();
            }
        }

        private void Frm_Borrar_Propiedades_Load(object sender, EventArgs e)
        {
            MostrarDatos(propiedad.RecuperarDesignacion(designacionCatastral));
            CargarGrillaAsociaciones(propiedad.recuperarAsociaciones(designacionCatastral));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                propiedad.borrar(designacionCatastral);
                propiedad.borrar_asociacion(designacionCatastral);
                MessageBox.Show("Se borró correctamente la propiedad.");
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
