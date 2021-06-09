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
using G11_TP_PAV.Clases;
using G11_TP_PAV.Negocio;

namespace G11_TP_PAV.Formularios.Gastos
{
    public partial class Frm_Listado_Gastos : Form
    {
        public Frm_Listado_Gastos()
        {
            InitializeComponent();
        }

        private void Frm_Listado_Gastos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable infoGastos = new DataTable();
            NE_Gastos gastos = new NE_Gastos();
            infoGastos = gastos.RecuperarTodos();
            ReportDataSource ds = new ReportDataSource("DatosGastos", infoGastos);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();

        }

        private void btn_deshacer_Click(object sender, EventArgs e)
        {
            btn_filtrar.Enabled = false;
            btn_deshacer.Text = "Espere por favor";
            btn_deshacer.Enabled = false;
            DataTable infoGastos = new DataTable();
            NE_Gastos gastos = new NE_Gastos();
            infoGastos = gastos.RecuperarTodos();
            ReportDataSource ds = new ReportDataSource("DatosGastos", infoGastos);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
            btn_filtrar.Enabled = true;
            btn_deshacer.Enabled = true;
            btn_deshacer.Text = "Deshacer Filtro";


        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            btn_filtrar.Text = "Espere por favor";
            btn_filtrar.Enabled = false;
            btn_deshacer.Enabled = false;
            DataTable infoGastos = new DataTable();
            NE_Gastos gastos = new NE_Gastos();
            DateTime desde = dt_desde.Value;
            DateTime hasta = dt_hasta.Value;
            infoGastos = gastos.RecuperarPorFecha(desde, hasta);
            btn_filtrar.Text = "Ya casi está listo";
            ReportDataSource ds = new ReportDataSource("DatosGastos", infoGastos);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
            btn_filtrar.Text = "Filtrar";
            btn_filtrar.Enabled = true;
            btn_deshacer.Enabled = true;
            this.reportViewer1.RefreshReport();


        }
    }
}
