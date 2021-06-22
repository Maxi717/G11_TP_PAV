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
    public partial class Frm_Modificar_Propiedades : Form
    {
        public string designacionCatastral { get; set; }

        NE_Propiedades propiedad = new NE_Propiedades();
        NE_duenios duenio = new NE_duenios();
        DataTable tabla = new DataTable();

        string documento_seleccionado;
        string tipo_documento_seleccionado;
        //List<string> altasAsociaciones = new List<string>();
        //List<string> bajasAspcoaciones = new List<string>();


        public Frm_Modificar_Propiedades()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Propiedades_Load(object sender, EventArgs e)
        {
            cmb_provincia.CargarCombo("SELECT " + cmb_provincia.Pp_Pk + "," + cmb_provincia.Pp_descripcion + " FROM " + cmb_provincia.Pp_tabla_origen);
            cmb_provincia.SelectedIndex = -1;
            cmb_localidad.Enabled = false;
            cmb_barrio.Enabled = false;
            cmb_barrio.CargarCombo("SELECT " + cmb_barrio.Pp_Pk + ", " + cmb_barrio.Pp_descripcion + " FROM " + cmb_barrio.Pp_tabla_origen);
            cmb_tipo_propiedad.CargarCombo("SELECT " + cmb_tipo_propiedad.Pp_Pk + ", " + cmb_tipo_propiedad.Pp_descripcion + " FROM " + cmb_tipo_propiedad.Pp_tabla_origen);
            cmb_tipo_documento.CargarCombo("SELECT " + cmb_tipo_documento.Pp_Pk + ", " + cmb_tipo_documento.Pp_descripcion + " FROM " + cmb_tipo_documento.Pp_tabla_origen);

            MostrarDatos(propiedad.RecuperarDesignacion(designacionCatastral));

            CargarGrillaAsociaciones(propiedad.recuperarAsociaciones(designacionCatastral));
            if (grid_duenios.Rows.Count != 0)
            {
                documento_seleccionado = grid_duenios.CurrentRow.Cells["numero_documento"].Value.ToString();
                tipo_documento_seleccionado = grid_duenios.CurrentRow.Cells["id_tipo_documento"].Value.ToString();
            }
        }

        private void CargarGrillaAsociaciones(DataTable tabla)
        {
            DataTable tablaDuenio = new DataTable();
            NE_duenios duenio = new NE_duenios();

            grid_duenios.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                tablaDuenio = duenio.RecuperarDocumento(tabla.Rows[i]["documento"].ToString(), tabla.Rows[i]["tipo_documento"].ToString());
                grid_duenios.Rows.Add();
                grid_duenios.Rows[i].Cells[0].Value = tablaDuenio.Rows[0]["numero_documento"].ToString();
                grid_duenios.Rows[i].Cells[1].Value = tablaDuenio.Rows[0]["id_tipo_documento"].ToString();
                grid_duenios.Rows[i].Cells[2].Value = tablaDuenio.Rows[0]["tipo_documento_nombre"].ToString();
                grid_duenios.Rows[i].Cells[3].Value = tablaDuenio.Rows[0]["nombre"].ToString();
                grid_duenios.Rows[i].Cells[4].Value = tablaDuenio.Rows[0]["telefono"].ToString();
                grid_duenios.Rows[i].Cells[5].Value = tablaDuenio.Rows[0]["domicilio"].ToString();
                grid_duenios.Rows[i].Cells[6].Value = "Viejo";

            }
        }

        private void AddGrilla(DataTable tabla)
        {
            grid_duenios.Rows.Add(tabla.Rows[0]["numero_documento"].ToString(), tabla.Rows[0]["id_tipo_documento"].ToString(), tabla.Rows[0]["tipo_documento_nombre"].ToString(), tabla.Rows[0]["nombre"].ToString(), tabla.Rows[0]["telefono"].ToString(), tabla.Rows[0]["domicilio"].ToString(), "Nuevo");
        }


        private void MostrarDatos(DataTable tabla)
        {
            txt_designacion.Text = tabla.Rows[0]["designacion_catastral"].ToString();
            txt_calle.Text = tabla.Rows[0]["calle"].ToString();
            txt_numero.Text = tabla.Rows[0]["numero"].ToString();
            txt_piso.Text = tabla.Rows[0]["piso"].ToString();
            txt_departamento.Text = tabla.Rows[0]["departamento"].ToString();
            cmb_barrio.SelectedValue = int.Parse(tabla.Rows[0]["id_barrio"].ToString());
            cmb_tipo_propiedad.SelectedValue = int.Parse(tabla.Rows[0]["id_tipo_propiedad"].ToString());
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            NE_Propiedades propiedad = new NE_Propiedades();

            if (txt_calle.Text == "")
            {
                MessageBox.Show("Se nececita cargar la calle.");
                return;
            }

            if (txt_numero.Text == "")
            {
                MessageBox.Show("Se nececita cargar el numero de domicilio.");
                return;
            }

            if (grid_duenios.Rows.Count == 0)
            {
                MessageBox.Show("Se nececita cargar al menos un dueño");
                return;
            }

            if (txt_departamento.Text == "")
            {
                propiedad.modificarSinDepto(designacionCatastral, txt_calle.Text, txt_numero.Text, cmb_barrio.SelectedValue.ToString(), cmb_tipo_propiedad.SelectedValue.ToString());
                this.Close();
            }
            else
            {
                propiedad.modificarCompleto(designacionCatastral, txt_calle.Text, txt_numero.Text, txt_piso.Text, txt_departamento.Text, cmb_barrio.SelectedValue.ToString(), cmb_tipo_propiedad.SelectedValue.ToString());
                this.Close();
            }

            for (int i = 0; i < grid_duenios.Rows.Count; i++)
            {
                if (grid_duenios.Rows[i].Visible == true)
                {
                    tabla = propiedad.recuperarAsociaciones(txt_designacion.Text, grid_duenios.Rows[i].Cells[0].Value.ToString(), grid_duenios.Rows[i].Cells[1].Value.ToString());
                    if (tabla.Rows.Count == 0)
                    {
                        propiedad.agregarAsociacion(txt_designacion.Text, grid_duenios.Rows[i].Cells[0].Value.ToString(), grid_duenios.Rows[i].Cells[1].Value.ToString());
                    }
                }
                else
                {
                    propiedad.borrar_asociacion(txt_designacion.Text, grid_duenios.Rows[i].Cells[0].Value.ToString(), grid_duenios.Rows[i].Cells[1].Value.ToString());
                }
            }
            this.Close();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_numero_documento.Text == "")
            {
                MessageBox.Show("Ingrese un Numero de documento para la busqueda.");
                return;
            }
            else
            {
                tabla = duenio.RecuperarDocumento(txt_numero_documento.Text, cmb_tipo_documento.SelectedValue.ToString());
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado dueño con los datos ingresados");
                    return;
                }
                else
                {
                    txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_numero_documento.Text == "" || txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese un Numero de documento para la busqueda.");
                return;
            }
            else
            {
                propiedad.agregarAsociacion(designacionCatastral, txt_numero_documento.Text, cmb_tipo_documento.SelectedValue.ToString());
                CargarGrillaAsociaciones(propiedad.recuperarAsociaciones(designacionCatastral));

                txt_numero_documento.Text = "";
                txt_nombre.Text = "";

            }
        }

        private void grid_duenios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            documento_seleccionado = grid_duenios.CurrentRow.Cells["numero_documento"].Value.ToString();
            tipo_documento_seleccionado = grid_duenios.CurrentRow.Cells["id_tipo_documento"].Value.ToString();
        }


        private void btn_sacar_Click(object sender, EventArgs e)
        {
            grid_duenios.CurrentRow.Visible = false;
        }

        private void cmb_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_provincia.SelectedIndex != -1)
            {
                cmb_localidad.Enabled = true;
                cmb_localidad.CargarCombo("SELECT " + cmb_localidad.Pp_Pk + ", " + cmb_localidad.Pp_descripcion + " FROM " + cmb_localidad.Pp_tabla_origen + " WHERE id_provincia = " + cmb_provincia.SelectedValue.ToString());
                cmb_localidad.SelectedIndex = -1;
                cmb_barrio.Enabled = false;
            }
        }

        private void cmb_localidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_localidad.SelectedIndex != -1)
            {
                cmb_barrio.Enabled = true;
                cmb_barrio.CargarCombo("SELECT " + cmb_barrio.Pp_Pk + ", " + cmb_barrio.Pp_descripcion + " FROM " + cmb_barrio.Pp_tabla_origen + " WHERE id_localidad = " + cmb_localidad.SelectedValue.ToString());
                cmb_barrio.SelectedIndex = -1;
            }
        }
    }
}
