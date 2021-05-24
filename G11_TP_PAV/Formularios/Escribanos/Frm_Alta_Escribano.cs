using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G11_TP_PAV.Clases;
using G11_TP_PAV.Negocio;

namespace G11_TP_PAV.Formularios.Escribanos
{
    public partial class Frm_Alta_Escribano : Form
    {
        public Frm_Alta_Escribano()
        {
            InitializeComponent();
        }

        private void Frm_Alta_Escribano_Load(object sender, EventArgs e)
        {
            cmb_TipoDoc.CargarCombo();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratEspeciales Tratamiento = new TratEspeciales();

            if (Tratamiento.Validar(this.groupBox1.Controls) == TratEspeciales.Resultado.correcto)
            {
                NE_Escribanos escribano = new NE_Escribanos();

                escribano.Insertar(this.groupBox1.Controls);

                MessageBox.Show("El Escribano se registro con Exito");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
