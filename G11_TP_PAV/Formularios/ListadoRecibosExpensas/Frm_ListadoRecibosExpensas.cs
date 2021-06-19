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

namespace G11_TP_PAV.Formularios.ListadoRecibosExpensas
{
    public partial class Frm_ListadoRecibosExpensas : Form
    {
        public Frm_ListadoRecibosExpensas()
        {
            InitializeComponent();
        }

        private void Frm_ListadoRecibosExpensas_Load(object sender, EventArgs e)
        {

            this.rv_ReciboExpensas.RefreshReport();
        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            NE_TransRecibos listado = new NE_TransRecibos();

            ReportDataSource dato = new ReportDataSource("DataSet1", listado.recuperarListado());
            rv_ReciboExpensas.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.ListadoRecibosExpensas.ListadoRecibosExpensas.rdlc";
            rv_ReciboExpensas.LocalReport.DataSources.Clear();
            rv_ReciboExpensas.LocalReport.DataSources.Add(dato);
            rv_ReciboExpensas.RefreshReport();

        }
    }
}
