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

namespace G11_TP_PAV.Informes
{
    public partial class Frm_ListadoEdificios : Form
    {
        public Frm_ListadoEdificios()
        {
            InitializeComponent();
        }

        private void Frm_ListadoEdificios_Load(object sender, EventArgs e)
        {
            this.RV_edificios.RefreshReport();
        }

        private void RV_edificios_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            NE_edificios edificio = new NE_edificios();
            tabla = edificio.RecuperarEdificiosComunes();

            ReportDataSource ds = new ReportDataSource("DataEdificios",tabla);

            RV_edificios.LocalReport.DataSources.Clear();
            RV_edificios.LocalReport.DataSources.Add(ds);
            RV_edificios.RefreshReport();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            NE_edificios edificio = new NE_edificios();
            tabla = edificio.RecuperarEdificiosDesdeHasta(txt_limInferior.Text, txt_limSuperior.Text);

            ReportDataSource ds = new ReportDataSource("DataEdificios", tabla);

            RV_edificios.LocalReport.DataSources.Clear();
            RV_edificios.LocalReport.DataSources.Add(ds);
            RV_edificios.RefreshReport();

        }
    }
}
