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

namespace G11_TP_PAV.Formularios.CompraVenta
{
    public partial class Frm_CompraVenta : Form
    {

        private int id_tipo_documento { get; set; }

        private int numero_documento { get; set; }

        public string design_catastral { get; set; }

        public int matricula { get; set; }

        public Frm_CompraVenta()
        {
            InitializeComponent();
        }

        private void textBoxHeredado1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_CompraVenta_Load(object sender, EventArgs e)
        {
            cmb_TipoMoneda.CargarCombo();
            ActualizarGrilla();
        }


        private void ActualizarGrilla()
        {
            NE_CompraVenta compraVenta = new NE_CompraVenta();
            DataTable tabla = new DataTable();
            tabla = compraVenta.Recuperar();
            CargarGrilla(tabla);
        }


        private void CargarGrilla(DataTable tabla)
        {
            gdr_CompraVenta.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                gdr_CompraVenta.Rows.Add();
                gdr_CompraVenta.Rows[i].Cells["Id_CompraVenta"].Value = tabla.Rows[i][0].ToString();
                gdr_CompraVenta.Rows[i].Cells["Fecha"].Value = tabla.Rows[i][1].ToString();
                gdr_CompraVenta.Rows[i].Cells["Cliente"].Value = tabla.Rows[i][2].ToString();
                gdr_CompraVenta.Rows[i].Cells["Propiedad"].Value = tabla.Rows[i][3].ToString();
                gdr_CompraVenta.Rows[i].Cells["MontoTotal"].Value = tabla.Rows[i][4].ToString();
                gdr_CompraVenta.Rows[i].Cells["Moneda"].Value = tabla.Rows[i][5].ToString();
                gdr_CompraVenta.Rows[i].Cells["Factura"].Value = tabla.Rows[i][6].ToString();
            }
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            Frm_BuscarCliente cliente = new Frm_BuscarCliente();
 
            cliente.ShowDialog();

            this.numero_documento = cliente.numero_documento;
            this.id_tipo_documento = cliente.id_tipo_documento;
            txt_Cliente.Text = cliente.nombre;

        }

        private void btn_DesignCatastral_Click(object sender, EventArgs e)
        {
            Frm_BuscarPropiedad propiedad = new Frm_BuscarPropiedad();

            propiedad.ShowDialog();

            this.design_catastral = propiedad.design_catastral;
            txt_DesignCatastral.Text = design_catastral;

        }

        private void btn_Escribano_Click(object sender, EventArgs e)
        {
            Frm_BuscarEscribano escribano = new Frm_BuscarEscribano();

            escribano.ShowDialog();

            this.matricula = escribano.matricula;

            string nombreEscribano = escribano.nombre + " " + escribano.apellido;

            txt_Escribano.Text = nombreEscribano;

        }

        private void btn_FechaActual_Click(object sender, EventArgs e)
        {
            TratEspeciales tratamiento = new TratEspeciales();

            txt_FechaActual.Text = tratamiento.RecuperarFecha();
        }

        private void btn_RegistrarVenta_Click(object sender, EventArgs e)
        {
            NE_CompraVenta compraVenta = new NE_CompraVenta();

            compraVenta.fechaActual = txt_FechaActual.Text;

            compraVenta.id_documento = id_tipo_documento;
            
            compraVenta.nroDoc = numero_documento;
            
            compraVenta.monto = decimal.Parse(txt_Monto.Text);
            
            compraVenta.fechaPago = txt_FechaPago.Text;

            compraVenta.escribano = matricula;

            compraVenta.designCatastral = design_catastral;

            compraVenta.tipoMoneda = cmb_TipoMoneda.SelectedValue.ToString();

            compraVenta.insertar();

            ActualizarGrilla();

        }
    }
}
