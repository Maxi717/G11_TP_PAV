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

namespace PAV3k6.Formularios
{
    public partial class Frm_Alta_Publicidad : Form
    {
        public Frm_Alta_Publicidad()
        {
            InitializeComponent();
        }

        private void btn_borrar_todo_Click(object sender, EventArgs e)
        {
            txt_costo.Text = "";
            txt_precio.Text = "";
            txt_descripcion.Text = "";
            cmb_propiedades.SelectedIndex = -1;
            cmb_secciones.SelectedIndex = -1;
            cmb_propiedades.Text = "Propiedad...(Des. Catastral)";
            cmb_secciones.Text = "(sección...)";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            NE_Publicidades publi = new NE_Publicidades();
            string fecha = publi.ConvertirFecha(date_public.Value);
            MessageBox.Show(fecha);

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void Frm_Alta_Publicidad_Load(object sender, EventArgs e)
        {
            string sqlSec = "SELECT " + cmb_secciones.Pp_Pk + ", " + cmb_secciones.Pp_descripcion + " FROM " + cmb_secciones.Pp_tabla_origen;
            cmb_secciones.CargarCombo(sqlSec);
            cmb_secciones.SelectedIndex = -1;
            cmb_secciones.Text = "(sección...)";

            string sqlProp = "SELECT " + cmb_propiedades.Pp_Pk + ", " + cmb_propiedades.Pp_descripcion + " FROM " + cmb_propiedades.Pp_tabla_origen;
            cmb_propiedades.CargarCombo(sqlProp);
            cmb_propiedades.SelectedIndex = -1;
            cmb_propiedades.Text = "Propiedad...(Des. Catastral)";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Alta_Public_Click(object sender, EventArgs e)
        {
            double costo;
            double precio;
            if (!(txt_costo.Text == "" || txt_descripcion.Text == "" || txt_precio.Text == ""
                || cmb_secciones.SelectedIndex == -1 || cmb_propiedades.SelectedIndex == -1))
            {
                bool resultCos = Double.TryParse(txt_costo.Text, out costo);
                bool resultPre = Double.TryParse(txt_precio.Text, out precio);
                if (resultCos & resultPre)
                {
                    NE_Publicidades publi = new NE_Publicidades();
                    DateTime fechaHora = date_public.Value;

                    string fecha = publi.ConvertirFecha(fechaHora);
                    string descripcion = txt_descripcion.Text;
                    string id_seccion = cmb_secciones.SelectedValue.ToString();
                    string id_designacion_catastral = cmb_propiedades.SelectedValue.ToString();

                    publi.AltaPublicidades(fecha, precio, costo, descripcion, id_seccion, id_designacion_catastral);

                    MessageBox.Show("Publicidad agregada exitosamente");
                    
                }

            }
            else {
                MessageBox.Show("Debe insertar valores en todos los campos");
            }

        }
    }
}
