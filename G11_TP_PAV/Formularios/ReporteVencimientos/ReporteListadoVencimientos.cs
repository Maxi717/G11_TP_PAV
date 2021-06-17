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

namespace G11_TP_PAV.ReporteEma
{
    public partial class ReporteVencimientoContrato : Form
    {
        NE_ContratoAlquiler contrato = new NE_ContratoAlquiler();

        string fechaDesde;
        string fechaHasta;


        public ReporteVencimientoContrato()
        {
            InitializeComponent();

        }

        private void ReporteVencimientoContrato_Load(object sender, EventArgs e)
        {




                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.Clear();
            DataTable tabla = new DataTable();
            tabla = contrato.ReporteVencimientos();
            this.reportViewer1.RefreshReport();
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.ReporteVencimientos.ReporteVencimientos.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);

            this.reportViewer1.RefreshReport();






        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DT_hasta_ValueChanged(object sender, EventArgs e)
        {
            fechaHasta = DT_hasta.Value.Date.ToShortDateString();
            contrato.Pp_duracionContrato = fechaHasta;

        }

        private void DT_desde_ValueChanged(object sender, EventArgs e)
        {
            fechaDesde = DT_desde.Value.Date.ToShortDateString();
            contrato.Pp_fechaInicio = fechaDesde;

        }
    }
}
