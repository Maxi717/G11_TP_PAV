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

namespace G11_TP_PAV.Formularios.Tipo_Moneda
{
    public partial class Frm_Alta_TipoMoneda : Form
    {
        public Frm_Alta_TipoMoneda()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratEspeciales Tratamiento = new TratEspeciales();


            if (Tratamiento.Validar(this.grp_TipoMoneda.Controls) == TratEspeciales.Resultado.correcto && ValidarPorcentaje() == true )
            {

                NE_Tipo_Moneda moneda = new NE_Tipo_Moneda();

                moneda.Insertar(this.grp_TipoMoneda.Controls);

                MessageBox.Show("El Tipo de moneda se registro con Exito");
                this.Close();
            }
            else
            {
                return;
            }

        }

        private bool ValidarPorcentaje()
        {
            float porcentaje = float.Parse(txt_Porcentaje.Text);
            
            if (porcentaje <= 10000 && porcentaje >= 00000)
            {
                return true;
            }

            MessageBox.Show("El porcentaje debe estar entre el 0% y el 100%");
            return false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
