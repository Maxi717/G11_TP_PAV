using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using G11_TP_PAV.Negocio;
using System.Windows.Forms;

namespace G11_TP_PAV.Est_Comi_Contrato
{
    public partial class Frm_Est_Comi_Contrato : Form
    {
        public Frm_Est_Comi_Contrato()
        {
            InitializeComponent();
        }

        private void Frm_Est_Comi_Contrato_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            NE_ContratoAlquiler ComiXContrato = new NE_ContratoAlquiler();
            tabla = ComiXContrato.Info_Etd_ComiXTipo();

            ReportDataSource ds = new ReportDataSource("DS_CXC", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
