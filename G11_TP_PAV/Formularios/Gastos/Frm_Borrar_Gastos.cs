using G11_TP_PAV.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G11_TP_PAV.Formularios
{
    public partial class Frm_Borrar_Gastos : Form
    {
        public string dom_edificio { get; set; }

        public Frm_Borrar_Gastos()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void MostrarDatos(DataTable tabla)
        {
            cmb_edificio.SelectedValue = int.Parse(tabla.Rows[0]["id_edificio"].ToString());
            txt_concepto.Text = tabla.Rows[0]["concepto"].ToString();
            num_comprobante.Value = int.Parse(tabla.Rows[0]["numero_comprobante"].ToString());
            num_importe.Value = decimal.Parse(tabla.Rows[0]["importe"].ToString());
            txt_proveedor.Text = tabla.Rows[0]["proveedor"].ToString();
            date_gastos.Value = DateTime.Parse(tabla.Rows[0]["fecha"].ToString());
        }

        private void Frm_Borrar_Gastos_Load(object sender, EventArgs e)
        {
            cmb_edificio.CargarCombo();
            NE_Gastos gastos = new NE_Gastos();
            MostrarDatos(gastos.RecuperarImporte(dom_edificio));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_Gastos gastos = new NE_Gastos();
            if (MessageBox.Show("¿Está seguro que desea borrar el elemento?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
            {
                gastos.BorradoGastos(num_comprobante.Value.ToString());
            }
        }
    }
}
