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

namespace G11_TP_PAV.Est_Compra_Moneda
{
    public partial class Frm_Compra_Moneda : Form
    {
        public Frm_Compra_Moneda()
        {
            InitializeComponent();
        }

        private void Frm_Compra_Moneda_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            NE_ContratoAlquiler CompraVenta = new NE_ContratoAlquiler();
            tabla = CompraVenta.EST_Compra_Moneda();

            ReportDataSource ds = new ReportDataSource("DS_CV", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
