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

namespace G11_TP_PAV.Formularios.ContratoAlquiler
{
    public partial class Frm_ListadoContratos : Form
    {
        public Frm_ListadoContratos()
        {
            InitializeComponent();
        }
        //ej
        private void Frm_ListadoContratos_Load(object sender, EventArgs e)
        {
            DataTable infoalquileres = new DataTable();
            NE_ContratoAlquiler alq = new NE_ContratoAlquiler();
            infoalquileres = alq.RecuperarTodos();
            ReportDataSource ds = new ReportDataSource("DatosContratosAlquiler", infoalquileres);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            btn_filtrar.Text = "Espere por favor";
            btn_filtrar.Enabled = false;
            btn_deshacer.Enabled = false;
            DataTable infoAlq = new DataTable();
            NE_ContratoAlquiler alq = new NE_ContratoAlquiler();
            DateTime desde = dt_desde.Value;
            DateTime hasta = dt_hasta.Value;
            infoAlq = alq.RecuperarPorFecha(desde, hasta);
            btn_filtrar.Text = "Ya casi está listo";
            ReportDataSource ds = new ReportDataSource("DatosContratosAlquiler", infoAlq);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
            btn_filtrar.Text = "Filtrar";
            btn_filtrar.Enabled = true;
            btn_deshacer.Enabled = true;
            this.reportViewer1.RefreshReport();

        }

        private void btn_deshacer_Click(object sender, EventArgs e)
        {
            DataTable infoalquileres = new DataTable();
            NE_ContratoAlquiler alq = new NE_ContratoAlquiler();
            infoalquileres = alq.RecuperarTodos();
            ReportDataSource ds = new ReportDataSource("DatosContratosAlquiler", infoalquileres);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
        }
    }
}
