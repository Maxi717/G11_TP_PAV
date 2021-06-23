using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using G11_TP_PAV.Negocio;

namespace G11_TP_PAV.Formularios.Propiedades
{
    public partial class Frm_Listado_Propiedades : Form
    {
        NE_ReportePropiedad propiedad = new NE_ReportePropiedad();

        public Frm_Listado_Propiedades()
        {
            InitializeComponent();
        }

        private void Frm_Listado_Propiedades_Load(object sender, EventArgs e)
        {
            this.rv_prop.RefreshReport();
        }

        private DataTable CalcularDatosUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = propiedad.RecuperarDesdeHasta(num_min.Value.ToString(), num_max.Value.ToString());
            return tabla;
        }

        private void ArmarReporte()
        {
            DataTable tabla = CalcularDatosUsuarios();
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rv_prop.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.Propiedades.ReportePropiedades.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP_Prop", "Desde: "+num_min.Value.ToString()+"    Hasta:"+num_max.Value.ToString());
            rv_prop.LocalReport.DataSources.Clear();
            rv_prop.LocalReport.DataSources.Add(datos);
            rv_prop.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmarReporte();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
