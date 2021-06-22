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



namespace G11_TP_PAV.Formularios.EstadisticaAlqTipoMoneda
{
    public partial class Frm_EstAlqTipoMoneda : Form
    {
        public Frm_EstAlqTipoMoneda()
        {
            InitializeComponent();
        }

        private void Frm_EstAlqTipoMoneda_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable infoAlqTipo = new DataTable();
            NE_ContratoAlquiler conalq = new NE_ContratoAlquiler();
            infoAlqTipo = conalq.RecuperarParaEstadistica();
            ReportDataSource ds = new ReportDataSource("DatosAlqTipoMoneda", infoAlqTipo);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
