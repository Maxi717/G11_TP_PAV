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
using Microsoft.Reporting.WinForms;

namespace G11_TP_PAV.Formularios.ReporteGanancias
{
    public partial class Frm_estadisticaGananciasPorTipoPropiedad : Form
    {
        public Frm_estadisticaGananciasPorTipoPropiedad()
        {
            InitializeComponent();
        }

        private void Frm_estadisticaGananciasPorTipoPropiedad_Load(object sender, EventArgs e)
        {

            this.RV_ganancias.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            NE_CompraVenta compraVenta = new NE_CompraVenta();
            tabla = compraVenta.gananciasPorTipoPropiedad();

            ReportDataSource ds = new ReportDataSource("ganancias", tabla);

            RV_ganancias.LocalReport.DataSources.Clear();
            RV_ganancias.LocalReport.DataSources.Add(ds);
            RV_ganancias.RefreshReport();
            this.RV_ganancias.RefreshReport();
        }
    }
}
