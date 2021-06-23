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
using G11_TP_PAV.Clases;

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
            if (rd_mesAño.Checked == true)
            {
                ReportDataSource dato = new ReportDataSource("DataSet1", listado.recuperarListado(txt_mesFiltro.Text));
                rv_ReciboExpensas.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.ListadoRecibosExpensas.ListadoRecibosExpensas.rdlc";
                rv_ReciboExpensas.LocalReport.DataSources.Clear();
                rv_ReciboExpensas.LocalReport.DataSources.Add(dato);
                rv_ReciboExpensas.RefreshReport();
            }
            else
            {
                //sin filtro
                ReportDataSource dato = new ReportDataSource("DataSet1", listado.recuperarListado());
                rv_ReciboExpensas.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.ListadoRecibosExpensas.ListadoRecibosExpensas.rdlc";
                rv_ReciboExpensas.LocalReport.DataSources.Clear();
                rv_ReciboExpensas.LocalReport.DataSources.Add(dato);
                rv_ReciboExpensas.RefreshReport();

            }


        }

        private void chk_Filtro_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Filtro.Checked == true)
            {
                groupBox1.Enabled = true;
                rd_mesAño.Checked = true;
            }
            else
            {
                groupBox1.Enabled = false;
                rd_mesAño.Checked = false;
            }
        }

        private void rd_mesAño_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_mesAño.Checked == true)
            {
                txt_mesFiltro.Enabled = true;
                btn_mesActual.Enabled = true;
            }
            else
            {
                txt_mesFiltro.Enabled = false;
                btn_mesActual.Enabled = false;
            }
        }

        private void btn_mesActual_Click(object sender, EventArgs e)
        {
            TratEspeciales tratamiento = new TratEspeciales();

            string fecha = tratamiento.RecuperarFecha();

            string[] dato = fecha.Split('/');

            txt_mesFiltro.Text = dato[1] + dato[2];
        }
    }
}
