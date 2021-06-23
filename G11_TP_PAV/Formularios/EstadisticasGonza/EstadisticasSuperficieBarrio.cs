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
    public partial class EstadisticasSuperficieBarrio : Form
    {
        NE_EstadisticasGonza estadistica = new NE_EstadisticasGonza();

        public EstadisticasSuperficieBarrio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EstadisticasSuperficieBarrio_Load(object sender, EventArgs e)
        {
            cmb_edificio.CargarCombo();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmarReporte();
        }

        private DataTable CalcularDatosUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = estadistica.RecuperarSuperficie(cmb_edificio.SelectedValue.ToString());
            return tabla;
        }

        private void ArmarReporte()
        {
            DataTable tabla = CalcularDatosUsuarios();
            ReportDataSource datos = new ReportDataSource("DataSetSuperficie", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.EstadisticasGonza.ReporteSuperficieProvincia.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("Rp01", "Superficies");
            reportViewer1.LocalReport.SetParameters(parametros);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();
        }
    }
}
