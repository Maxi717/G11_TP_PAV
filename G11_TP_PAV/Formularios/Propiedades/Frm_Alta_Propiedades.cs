using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G11_TP_PAV.Negocio;
using G11_TP_PAV.Clases;
using G11_TP_PAV.Formularios.Duenios;
using System.Data;


namespace G11_TP_PAV.Formularios
{
    public partial class FRM_Alta_Propiedades : Form
    {
        DataTable tabla = new DataTable();
        NE_Propiedades propiedad = new NE_Propiedades();
        NE_duenios duenio = new NE_duenios();

        public FRM_Alta_Propiedades()
        {
            InitializeComponent();
        }

        private void CargarGrilla(DataTable tabla)
        {
            grid_duenios.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_duenios.Rows.Add();
                grid_duenios.Rows[i].Cells[0].Value = tabla.Rows[i]["numero_documento"].ToString();
                grid_duenios.Rows[i].Cells[1].Value = tabla.Rows[i]["id_tipo_documento"].ToString();
                grid_duenios.Rows[i].Cells[2].Value = tabla.Rows[i]["tipo_documento_nombre"].ToString();
                grid_duenios.Rows[i].Cells[3].Value = tabla.Rows[i]["nombre"].ToString();
                grid_duenios.Rows[i].Cells[4].Value = tabla.Rows[i]["telefono"].ToString();
                grid_duenios.Rows[i].Cells[5].Value = tabla.Rows[i]["domicilio"].ToString();
            }
        }

        private void AddGrilla(DataTable tabla)
        {
            grid_duenios.Rows.Add(tabla.Rows[0]["numero_documento"].ToString(), tabla.Rows[0]["id_tipo_documento"].ToString(), tabla.Rows[0]["tipo_documento_nombre"].ToString(), tabla.Rows[0]["nombre"].ToString(), tabla.Rows[0]["telefono"].ToString(), tabla.Rows[0]["domicilio"].ToString());
        }
    

        private void FRM_Alta_Propiedades_Load(object sender, EventArgs e)
        {
            cmb_provincia.CargarCombo("SELECT " + cmb_provincia.Pp_Pk + "," + cmb_provincia.Pp_descripcion + " FROM " + cmb_provincia.Pp_tabla_origen);
            cmb_provincia.SelectedIndex = -1;
            cmb_localidad.Enabled = false;
            cmb_barrio.Enabled = false;
            cmb_tipo_propiedad.CargarCombo("SELECT " + cmb_tipo_propiedad.Pp_Pk + ", " + cmb_tipo_propiedad.Pp_descripcion + " FROM " + cmb_tipo_propiedad.Pp_tabla_origen);
            cmb_tipo_documento.CargarCombo("SELECT " + cmb_tipo_documento.Pp_Pk + ", " + cmb_tipo_documento.Pp_descripcion + " FROM " + cmb_tipo_documento.Pp_tabla_origen);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_calle.Text == "" )
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
                propiedad.insertarsindepto(txt_designacion.Text, txt_calle.Text, txt_numero.Text, cmb_barrio.SelectedValue.ToString(), cmb_tipo_propiedad.SelectedValue.ToString());

            }
            else
            {
                propiedad.insertarCompleto(txt_designacion.Text, txt_calle.Text, txt_numero.Text, txt_piso.Text, txt_departamento.Text, cmb_barrio.SelectedValue.ToString(), cmb_tipo_propiedad.SelectedValue.ToString());
            }

            for(int i = 0; i<grid_duenios.Rows.Count; i++)
            {
                propiedad.agregarAsociacion(txt_designacion.Text, grid_duenios.Rows[i].Cells[0].Value.ToString(), grid_duenios.Rows[i].Cells[1].Value.ToString());
            }
            this.Close();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
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
                tabla = duenio.RecuperarDocumento(txt_numero_documento.Text, cmb_tipo_documento.SelectedValue.ToString());
                AddGrilla(tabla);
                txt_numero_documento.Text = "";
                txt_nombre.Text = "";
            }
        }

        private void btn_verificarDesignacion_Click(object sender, EventArgs e)
        {
            if (txt_designacion.Text == "")
            {
                MessageBox.Show("Se nececita cargar una designacion catastral.");
                return;
            }
            else
            {
                tabla = propiedad.RecuperarDesignacion(txt_designacion.Text.ToString());
                if (tabla.Rows.Count != 0)
                {
                    MessageBox.Show("Ya existe propiedad con la designacion catastral indicada");
                    return;
                }

                txt_calle.ReadOnly = false;
                txt_numero.ReadOnly = false;
                txt_piso.ReadOnly = false;
                txt_departamento.ReadOnly = false;
                txt_numero_documento.ReadOnly = false;
                txt_calle.ReadOnly = false;
                txt_nombre.ReadOnly = false;
                cmb_provincia.Enabled = true;
                cmb_tipo_documento.Enabled = true;
                cmb_tipo_propiedad.Enabled = true;
                cmb_tipo_documento.Enabled = true;
                btn_aceptar.Enabled = true;
                btn_agregar.Enabled = true;
                btn_buscar.Enabled = true;
                btn_sacar.Enabled = true;
            }
        }

        private void btn_sacar_Click(object sender, EventArgs e)
        {
            grid_duenios.Rows.RemoveAt(grid_duenios.CurrentCell.RowIndex);
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
