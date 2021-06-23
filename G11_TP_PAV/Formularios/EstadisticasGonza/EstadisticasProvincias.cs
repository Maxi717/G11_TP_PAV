using G11_TP_PAV.Negocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G11_TP_PAV.Formularios.EstadisticasGonza
{
    public partial class EstadisticasProvincias : Form
    {
        NE_EstadisticasGonza estadistica = new NE_EstadisticasGonza();

        public EstadisticasProvincias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmarReporte();
        }

        private void EstadisticasProvincias_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }


        private DataTable CalcularDatosUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = estadistica.RecuperarDesdeHasta(num_min.Value.ToString(), num_max.Value.ToString());
            return tabla;
        }

        private void ArmarReporte()
        {
            DataTable tabla = CalcularDatosUsuarios();
            ReportDataSource datos = new ReportDataSource("DataSetEstadisticProvincias", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.EstadisticasGonza.ReporteEstadisticaProvincias.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("Rp01", "Desde: " + num_min.Value.ToString() + "    Hasta:" + num_max.Value.ToString());
            reportViewer1.LocalReport.SetParameters(parametros);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
