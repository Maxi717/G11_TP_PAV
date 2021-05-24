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

    public partial class BajaDepartamentos : Form
    {
        public string id { get; set; }
        public BajaDepartamentos()
        {
            InitializeComponent();
        }
        NE_departamentos departamento= new NE_departamentos();

        private void BajaDepartamentos_Load(object sender, EventArgs e)
        {
            BE_Edificios _BD = new BE_Edificios();
            DataTable tabla = new DataTable();
            cmb_barrio.CargarCombo();
            cmb_duenio.CargarCombo();
            cmb_edificio.CargarCombo();

            MostrarDatos(departamento.RecuperarID(id));

        }
        private void MostrarDatos(DataTable tabla)
        {

            txt_piso.Text = tabla.Rows[0]["Piso"].ToString();
            txt_denom.Text = tabla.Rows[0]["Denominacion"].ToString();
            txt_sup.Text = tabla.Rows[0]["Superficie"].ToString();
            txt_porc.Text = tabla.Rows[0]["Porcentaje"].ToString();
            cmb_barrio.SelectedValue = tabla.Rows[0]["Barrio"].ToString();
            cmb_edificio.SelectedValue = tabla.Rows[0]["Domicilio"].ToString();
            cmb_duenio.SelectedValue = tabla.Rows[0]["Duenio"].ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            departamento.Pp_id_departamento = id;


            departamento.Borrar();
            MessageBox.Show("Eliminado correctamente.");
            this.Close();
        }
    }
}
