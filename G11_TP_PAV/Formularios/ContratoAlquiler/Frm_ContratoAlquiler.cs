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
using G11_TP_PAV.Negocio;

namespace G11_TP_PAV
{
    public partial class Frm_ContratoAlquiler : Form
    {
        public Frm_ContratoAlquiler()
        {
            InitializeComponent();
        }

        private void Frm_ContratoAlquiler_Load(object sender, EventArgs e)
        {
            cmb_tipoMoneda.CargarCombo();
            cmb_cliente.CargarCombo();
            cmb_Propiedad.CargarCombo2();
            cmb_escribano.CargarCombo2();

        }
        NE_ContratoAlquiler contrato = new NE_ContratoAlquiler();


        public void button1_Click(object sender, EventArgs e)
        {


            contrato.Pp_fechaInicio = DT_inicio.Value.Date.ToShortDateString();
            contrato.Pp_duracionContrato = DT_duracion.Value.Date.ToShortDateString();
            contrato.Pp_monto = txt_monto.Text;
            contrato.Pp_porcentaje = cmb_tipoMoneda.SelectedValue.ToString();
            contrato.Pp_propiedad = cmb_Propiedad.SelectedValue.ToString();
            contrato.Pp_cliente = cmb_cliente.SelectedValue.ToString();
            contrato.Pp_escribano = cmb_escribano.SelectedValue.ToString();

                contrato.InsertarContratoAlquiler();
                contrato.InsertarFactura();



        }

        public void DT_inicio1_ValueChanged(object sender, EventArgs e)
        {
            string fecha_inicio = DT_inicio.Value.Date.ToShortDateString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            DataTable tabla = new DataTable();
            tabla = contrato.RecuperarDatos();
            CargarGrilla(tabla);
        }
        private void CargarGrilla(DataTable tabla)
        {
            if (tabla.Rows.Count == 0)
            {
                DataGrid.Rows.Clear();

            }
            else
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataGrid.Rows.Add();
                    DataGrid.Rows[i].Cells[0].Value = tabla.Rows[i]["nro_factura"].ToString();
                    DataGrid.Rows[i].Cells[1].Value = tabla.Rows[i]["propiedad"].ToString();
                    DataGrid.Rows[i].Cells[2].Value = tabla.Rows[i]["documento"].ToString();
                    DataGrid.Rows[i].Cells[3].Value = tabla.Rows[i]["id_tipo_moneda"].ToString();
                    DataGrid.Rows[i].Cells[4].Value = tabla.Rows[i]["monto"].ToString();
                    DataGrid.Rows[i].Cells[5].Value = tabla.Rows[i]["fecha_inicio"].ToString();



                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_monto.Clear();
            cmb_tipoMoneda.SelectedIndex = -1;
            cmb_Propiedad.SelectedIndex = -1;
            cmb_cliente.SelectedIndex = -1;
            cmb_escribano.SelectedIndex = -1;
        }
    }
}
