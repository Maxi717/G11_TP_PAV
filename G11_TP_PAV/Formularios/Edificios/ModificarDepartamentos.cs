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
using G11_TP_PAV.Clases;

namespace G11_TP_PAV.Formularios
{
    public partial class ModificarDepartamentos : Form
    {
        public string id { get; set; }
        public ModificarDepartamentos()
        {
            InitializeComponent();
        }
        NE_departamentos departamento = new NE_departamentos();
        private void ModificarDepartamentos_Load(object sender, EventArgs e)
        {
            BE_Edificios _BD = new BE_Edificios();
            DataTable tabla = new DataTable();
            cmb_Barrio.CargarCombo();
            cmb_duenio.CargarCombo();
            cmb_Edificio.CargarCombo();

            MostrarDatos(departamento.RecuperarID(id));
        }

        private void MostrarDatos(DataTable tabla)
        {

            txt_piso.Text = tabla.Rows[0]["Piso"].ToString();
            txt_denom.Text = tabla.Rows[0]["Denominacion"].ToString();
            txt_sup.Text = tabla.Rows[0]["Superficie"].ToString();
            txt_porc.Text = tabla.Rows[0]["Porcentaje"].ToString();
            cmb_Barrio.SelectedValue = tabla.Rows[0]["Barrio"].ToString();
            cmb_Edificio.SelectedValue = tabla.Rows[0]["Domicilio"].ToString();
            cmb_duenio.SelectedValue = tabla.Rows[0]["Duenio"].ToString();


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

                departamento.Pp_id_departamento = id;
                departamento.Pp_piso = txt_piso.Text;
                departamento.Pp_denominacion = txt_denom.Text;
                departamento.Pp_superficie = txt_sup.Text;
                departamento.Pp_porcentaje = txt_porc.Text;
                departamento.Pp_id_barrio = cmb_Barrio.SelectedValue.ToString();
                departamento.Pp_id = cmb_Edificio.SelectedValue.ToString();
                departamento.Pp_numero_documento = cmb_duenio.SelectedValue.ToString();


                departamento.Modificar();
                MessageBox.Show("Se realizaron las modificaciones correspondientes.");
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
