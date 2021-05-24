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
    public partial class Frm_Altas_Gastos : Form
    {
        public Frm_Altas_Gastos()
        {
            InitializeComponent();
        }

        private void Frm_Altas_Gastos_Load(object sender, EventArgs e)
        {
            cmb_edificio.CargarCombo();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratEsp tratamiento = new TratEsp();
            if (tratamiento.Validar(this.Controls) == TratEsp.Resultado.correcto)
            {
                NE_Gastos gastos = new NE_Gastos();

                gastos.InsertarGastos(this.Controls);
            }
            else
            {
                return;
            }
        }
    }
}
