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

namespace G11_TP_PAV.Formularios.EstadisticaComisionTipoMoneda
{
    public partial class Frm_Estadistica_ComisionTipoMoneda : Form
    {
        public Frm_Estadistica_ComisionTipoMoneda()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_ComisionTipoMoneda_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable infoComision = new DataTable();
            NE_Tipo_Moneda moneda = new NE_Tipo_Moneda();
            infoComision = moneda.RecuperarParaEstadistica();
            ReportDataSource ds = new ReportDataSource("DataSetTiposMonedaComision", infoComision);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
            
        }
    }
}
