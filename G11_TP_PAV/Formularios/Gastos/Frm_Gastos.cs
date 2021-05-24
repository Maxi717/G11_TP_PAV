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
    public partial class Frm_Gastos : Form
    {
        public string dom_edificio { get; set; }

        public Frm_Gastos()
        {
            InitializeComponent();
        }

        private void Frm_Gastos_Load(object sender, EventArgs e)
        {
            cmb_edificio.CargarCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb_edificio.SelectedValue = -1;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarGrilla(DataTable tabla)
        {
            grid_gastos.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_gastos.Rows.Add();
                grid_gastos.Rows[i].Cells[0].Value = tabla.Rows[i]["numero_comprobante"].ToString();
                grid_gastos.Rows[i].Cells[1].Value = tabla.Rows[i]["fecha"].ToString();
                grid_gastos.Rows[i].Cells[2].Value = tabla.Rows[i]["concepto"].ToString();
                grid_gastos.Rows[i].Cells[3].Value = tabla.Rows[i]["proveedor"].ToString();
                grid_gastos.Rows[i].Cells[4].Value = tabla.Rows[i]["importe"].ToString();
                grid_gastos.Rows[i].Cells[5].Value = tabla.Rows[i]["id_edificio"].ToString();
            }
        }

        private void btn_buscar_gastos_Click(object sender, EventArgs e)
        {
            NE_Gastos gastos = new NE_Gastos();
            DataTable tabla = new DataTable();
            if (chk_todos_gastos.Checked == false && txt_proveedor.Text == "" && num_comprobante.Value == 0 && cmb_edificio.SelectedIndex == -1 && num_importe.Value == 0)
            {
                MessageBox.Show("Debe seleccionar alguna opción", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (chk_todos_gastos.Checked)
            {
                tabla = gastos.RecuperarTodos();
                CargarGrilla(tabla);
                return;
            }
            if (num_importe.Value > 0)
            {
                tabla = gastos.RecuperarImporte(num_importe.Value.ToString());
                CargarGrilla(tabla);
                return;
            }
            if (txt_proveedor.Text != "" && num_comprobante.Value > 0 && cmb_edificio.SelectedIndex != -1)
            {
                tabla = gastos.RecuperarTresValores(cmb_edificio.SelectedValue.ToString(), num_comprobante.Value.ToString(), txt_proveedor.Text);
                CargarGrilla(tabla);
                return;
            }
            if (num_comprobante.Value > 0 && cmb_edificio.SelectedIndex != -1)
            {
                tabla = gastos.RecuperarMixto(num_comprobante.Value.ToString(), cmb_edificio.SelectedValue.ToString());
                CargarGrilla(tabla);
                return;
            }
            if (txt_proveedor.Text != "" && num_comprobante.Value > 0)
            {
                tabla = gastos.RecuperarMixto(txt_proveedor.Text, num_comprobante.Value.ToString());
                CargarGrilla(tabla);
                return;
            }
            if (num_comprobante.Value > 0)
            {
                tabla = gastos.RecuperarComprobante(num_comprobante.Value.ToString());
                CargarGrilla(tabla);
                return;
            }
            if (txt_proveedor.Text != "")
            {
                CargarGrilla(gastos.RecuperarProveedor(txt_proveedor.Text));
                return;
            }
            if (cmb_edificio.SelectedIndex != -1)
            {
                CargarGrilla(gastos.RecuperarEdificio(cmb_edificio.SelectedValue.ToString()));
                return;
            }
        }

        private void btn_altas_gastos_Click(object sender, EventArgs e)
        {
            Frm_Altas_Gastos altas = new Frm_Altas_Gastos();
            altas.ShowDialog();
        }

        private void grid_gastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dom_edificio = grid_gastos.CurrentRow.Cells["numero_comprobante"].Value.ToString();
        }

        private void btn_modificar_gastos_Click(object sender, EventArgs e)
        {
            Frm_Modificar_Gastos modificar = new Frm_Modificar_Gastos();
            modificar.dom_edificio = dom_edificio;
            modificar.ShowDialog();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            Frm_Borrar_Gastos borrar = new Frm_Borrar_Gastos();
            borrar.dom_edificio = dom_edificio;
            borrar.ShowDialog();
        }
    }
}
