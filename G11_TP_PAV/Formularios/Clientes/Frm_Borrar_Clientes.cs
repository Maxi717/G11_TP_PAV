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
    public partial class Frm_Borrar_Clientes : Form
    {
        public string numero_documento { get; set; }

        public Frm_Borrar_Clientes()
        {
            InitializeComponent();
        }

        private void MostrarDatos(DataTable tabla)
        {
            cmb_tipo_dni.SelectedValue = int.Parse(tabla.Rows[0]["id_tipo_documento"].ToString());
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
            num_dni.Value = int.Parse(tabla.Rows[0]["numero_documento"].ToString());
            num_tel.Value = int.Parse(tabla.Rows[0]["telefono"].ToString());
            txt_dir.Text = tabla.Rows[0]["direccion"].ToString();
        }

        private void Frm_Borrar_Clientes_Load(object sender, EventArgs e)
         {
            cmb_tipo_dni.CargarCombo();
            NE_Clientes clientes = new NE_Clientes();
            MostrarDatos(clientes.RecuperarDni(numero_documento));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_Clientes clientes = new NE_Clientes();
            if (MessageBox.Show("¿Está seguro que desea borrar el elemento?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                clientes.BorradoClientes(numero_documento);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
