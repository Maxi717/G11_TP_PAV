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
    public partial class Frm_Clientes : Form
    {

        public string id_documento { get; set; }

        public Frm_Clientes()
        {
            InitializeComponent();
        }
        

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            cmb_tipo_dni.CargarCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb_tipo_dni.SelectedIndex = -1;
        }

        private void btn_buscar_clientes_Click(object sender, EventArgs e)
        {
            NE_Clientes cliente = new NE_Clientes();
            DataTable tabla = new DataTable();
            if (chk_todos_clientes.Checked == false && txt_nombres.Text == "" && num_dni.Value == 0 && cmb_tipo_dni.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar alguna opción", "Importante", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
                return;
            }
            if (chk_todos_clientes.Checked)
            {
                tabla = cliente.RecuperarTodos();
                CargarGrilla(tabla);
                return;
            }
            if (txt_nombres.Text != "" && num_dni.Value > 0 && cmb_tipo_dni.SelectedIndex != -1)
            {
                tabla = cliente.RecuperarTresValores(txt_nombres.Text, num_dni.Value.ToString(), cmb_tipo_dni.SelectedValue.ToString());
                CargarGrilla(tabla);
                return;
            }
            if (num_dni.Value > 0 && cmb_tipo_dni.SelectedIndex != -1)
            {
                tabla = cliente.RecuperarDniMasTipo(num_dni.Value.ToString(), cmb_tipo_dni.SelectedValue.ToString());
                CargarGrilla(tabla);
                return;
            }
            if (txt_nombres.Text != "" && num_dni.Value > 0)
            {
                tabla = cliente.RecuperarMixto(txt_nombres.Text, num_dni.Value.ToString());
                CargarGrilla(tabla);
                return;
            }
            if (num_dni.Value > 0)
            {
                tabla = cliente.RecuperarDni(num_dni.Value.ToString());
                CargarGrilla(tabla);
                return;
            }
            if (txt_nombres.Text != "")
            {
                CargarGrilla(cliente.RecuperarNombre(txt_nombres.Text));
                return;
            }
            if (cmb_tipo_dni.SelectedIndex != -1)
            {
                CargarGrilla(cliente.RecuperarTipoDocumento(cmb_tipo_dni.SelectedValue.ToString()));
                return;
            }
        }

        private void CargarGrilla(DataTable tabla)
        {
            grid_clientes.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_clientes.Rows.Add();
                grid_clientes.Rows[i].Cells[0].Value = tabla.Rows[i]["nombre"].ToString();
                grid_clientes.Rows[i].Cells[1].Value = tabla.Rows[i]["numero_documento"].ToString();
                grid_clientes.Rows[i].Cells[2].Value = tabla.Rows[i]["Nombre_tipo_documento"].ToString();
                grid_clientes.Rows[i].Cells[3].Value = tabla.Rows[i]["telefono"].ToString();
                grid_clientes.Rows[i].Cells[4].Value = tabla.Rows[i]["direccion"].ToString();
                grid_clientes.Rows[i].Cells["id_tipo_documento"].Value = tabla.Rows[i]["id_tipo_documento"].ToString();
            }
        }

        private void btn_altas_clientes_Click(object sender, EventArgs e)
        {
            Frm_Altas_Clientes altas = new Frm_Altas_Clientes();
            altas.ShowDialog();
        }

        private void grid_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_documento = grid_clientes.CurrentRow.Cells["numero_documento"].Value.ToString();
        }

        private void btn_modificar_cliente_Click(object sender, EventArgs e)
        {
            Frm_Modificar_Clientes modificar = new Frm_Modificar_Clientes();
            modificar.numero_documento = id_documento;
            modificar.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            Frm_Borrar_Clientes borrar = new Frm_Borrar_Clientes();
            borrar.numero_documento = id_documento;
            borrar.ShowDialog();
        }
    }
}
 