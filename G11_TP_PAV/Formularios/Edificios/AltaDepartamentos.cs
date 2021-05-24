using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G11_TP_PAV.Formularios;
using G11_TP_PAV.Clases;
using G11_TP_PAV.Negocio;
using G11_TP_PAV;

namespace G11_TP_PAV.Formularios
{
    public partial class AltaDepartamentos : Form
    {
        public AltaDepartamentos()
        {
            InitializeComponent();
        }

        private void AltaDepartamentos_Load_1(object sender, EventArgs e)
        {
            cmb_duenio.CargarCombo();
            cmbAlta_Barrio.CargarCombo();
            cmbAlta_Edificio.CargarCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.ok)
            {
                NE_departamentos departamento = new NE_departamentos();
                departamento.Pp_piso = txt_piso.Text;
                departamento.Pp_denominacion = txt_denominacion.Text;
                departamento.Pp_superficie = txt_su.Text;
                departamento.Pp_porcentaje = txt_po.Text;
                departamento.Pp_id_barrio = cmbAlta_Barrio.SelectedValue.ToString();
                departamento.Pp_id = cmbAlta_Edificio.SelectedValue.ToString();
                departamento.Pp_numero_documento = cmb_duenio.SelectedValue.ToString();


                departamento.Insertar();
                MessageBox.Show("Se realizo el alta correctamente.");
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
