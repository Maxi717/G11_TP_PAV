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

namespace G11_TP_PAV.Formularios.Estadisticas_Esteban
{
    public partial class Frm_Estadistica_cantFacturasXEscribano : Form
    {
        public Frm_Estadistica_cantFacturasXEscribano()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_cantFacturasXEscribano_Load(object sender, EventArgs e)
        {
            NE_Estadistica estadistica = new NE_Estadistica();

            ReportDataSource dato = new ReportDataSource("DataSet1", estadistica.recuperarFactura_X_Escribano());
            RV_FacturaXEscribano.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.Estadisticas_Esteban.Est_Factura_x_Escribano.rdlc";
            RV_FacturaXEscribano.LocalReport.DataSources.Clear();
            RV_FacturaXEscribano.LocalReport.DataSources.Add(dato);
            this.RV_FacturaXEscribano.RefreshReport();
        }
    }
}
