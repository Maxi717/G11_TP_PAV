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

namespace G11_TP_PAV.Formularios.Publicidades
{
    public partial class Frm_Estadistica_Publicidades : Form
    {
        public Frm_Estadistica_Publicidades()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_Publicidades_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            NE_Publicidades publicidad = new NE_Publicidades();
            tabla = publicidad.GastosPorTipoPropiedad();

            ReportDataSource ds = new ReportDataSource("gastos_publicidades", tabla);

            RV_publicidades.LocalReport.DataSources.Clear();
            RV_publicidades.LocalReport.DataSources.Add(ds);
            RV_publicidades.RefreshReport();
            this.RV_publicidades.RefreshReport();
        }
    }
}
