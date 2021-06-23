using G11_TP_PAV.Negocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G11_TP_PAV.Formularios.DepartamentosRepor
{
    public partial class Frm_ListadoDepartamentos : Form
    {
        NE_ReporteDepartamento depto = new NE_ReporteDepartamento();

        public Frm_ListadoDepartamentos()
        {
            InitializeComponent();
        }

        private void Frm_ListadoDepartamentos_Load(object sender, EventArgs e)
        {

            this.rv_deptos.RefreshReport();
        }

        private DataTable CalcularDatosUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = depto.RecuperarDesdeHasta(num_min.Value.ToString(), num_max.Value.ToString());
            return tabla;
        }

        private void ArmarReporte()
        {
            DataTable tabla = CalcularDatosUsuarios();
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rv_deptos.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.DepartamentosRepor.ReporteListadoDepartamentos.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP_Prop", "Desde: " + num_min.Value.ToString() + "    Hasta:" + num_max.Value.ToString());
            rv_deptos.LocalReport.DataSources.Clear();
            rv_deptos.LocalReport.DataSources.Add(datos);
            rv_deptos.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmarReporte();
        }
    }
}
