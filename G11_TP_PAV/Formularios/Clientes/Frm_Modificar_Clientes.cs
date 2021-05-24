using G11_TP_PAV.Clases;
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
    public partial class Frm_Modificar_Clientes : Form
    {
        public string numero_documento { get; set; }

        public Frm_Modificar_Clientes()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Clientes_Load(object sender, EventArgs e)
        {
            cmb_tipo_dni.CargarCombo();
            NE_Clientes clientes = new NE_Clientes();
            MostrarDatos(clientes.RecuperarDni(numero_documento));
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarDatos(DataTable tabla)
        {
            cmb_tipo_dni.SelectedValue = int.Parse(tabla.Rows[0]["id_tipo_documento"].ToString());
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
            num_dni.Value = int.Parse(tabla.Rows[0]["numero_documento"].ToString());
            num_tel.Value = int.Parse(tabla.Rows[0]["telefono"].ToString());
            txt_dir.Text = tabla.Rows[0]["direccion"].ToString();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratEsp tratamiento = new TratEsp();
            if (tratamiento.Validar(this.Controls) == TratEsp.Resultado.correcto)
            {
                NE_Clientes clientes = new NE_Clientes();

                clientes.ModificarClientes(this.Controls, num_dni.Value.ToString());
            }
            else
            {
                return;
            }
        }
    }
}
