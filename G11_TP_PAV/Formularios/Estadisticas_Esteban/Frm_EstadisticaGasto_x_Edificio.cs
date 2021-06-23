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
    public partial class Frm_EstadisticaGasto_x_Edificio : Form
    {
        public Frm_EstadisticaGasto_x_Edificio()
        {
            InitializeComponent();
        }

        private void Frm_EstadisticaGasto_x_Edificio_Load(object sender, EventArgs e)
        {
            NE_Estadistica estadistica = new NE_Estadistica();

            ReportDataSource dato = new ReportDataSource("DataSet1", estadistica.recuperarGasto_x_Edificio());
            Rv_GanXBarrio.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.Estadisticas_Esteban.Est_Gastos_X_Edificio.rdlc";
            Rv_GanXBarrio.LocalReport.DataSources.Clear();
            Rv_GanXBarrio.LocalReport.DataSources.Add(dato);
            this.Rv_GanXBarrio.RefreshReport();
        }
    }
}
