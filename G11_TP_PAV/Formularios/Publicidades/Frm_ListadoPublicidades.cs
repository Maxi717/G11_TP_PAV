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
    public partial class Frm_ListadoPublicidades : Form
    {
        public Frm_ListadoPublicidades()
        {
            InitializeComponent();
        }

        private void Frm_ListadoPublicidades_Load(object sender, EventArgs e)
        {

            this.RV_publicidades.RefreshReport();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            NE_Publicidades publicidad = new NE_Publicidades();
            tabla = publicidad.RecuperarFecha(publicidad.ConvertirFecha(date_inicio.Value), publicidad.ConvertirFecha(date_final.Value));

            ReportDataSource ds = new ReportDataSource("DataPublicidades", tabla);

            RV_publicidades.LocalReport.DataSources.Clear();
            RV_publicidades.LocalReport.DataSources.Add(ds);
            RV_publicidades.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            NE_Publicidades publicidad = new NE_Publicidades();
            tabla = publicidad.RecuperarTodos();

            ReportDataSource ds = new ReportDataSource("DataPublicidades", tabla);

            RV_publicidades.LocalReport.DataSources.Clear();
            RV_publicidades.LocalReport.DataSources.Add(ds);
            RV_publicidades.RefreshReport();

        }
    }
}
