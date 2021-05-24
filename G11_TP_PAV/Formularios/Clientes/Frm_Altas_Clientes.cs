using G11_TP_PAV.Clases;
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
    public partial class Frm_Altas_Clientes : Form
    {
        public Frm_Altas_Clientes()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratEsp tratamiento = new TratEsp();
            if (tratamiento.Validar(this.Controls) == TratEsp.Resultado.correcto)
            {
                NE_Clientes clientes = new NE_Clientes();

                clientes.InsertarClientes(this.Controls);
            }
            else
            {
                return;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Altas_Clientes_Load(object sender, EventArgs e)
        {
            cmb_tipo_dni.CargarCombo();
        }
    }
}
