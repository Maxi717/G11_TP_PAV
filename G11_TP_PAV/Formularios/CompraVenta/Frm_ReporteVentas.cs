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

namespace G11_TP_PAV.Formularios.CompraVenta
{
    public partial class Frm_ReporteVentas : Form
    {
        public Frm_ReporteVentas()
        {
            InitializeComponent();
        }

        private void Frm_ReporteVentas_Load(object sender, EventArgs e)
        {

            this.rv1.RefreshReport();
        }


        private void chk_Filtro_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Filtro.Checked == true)
            { groupBox1.Enabled = true;
              rd_mesAño.Checked = true;
            }
            else 
            { 
                groupBox1.Enabled = false;
                rd_mesAño.Checked = false;
                rd_periodo.Checked = false;
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

        private void rd_periodo_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_periodo.Checked == true)
            {
                txt_desde.Enabled = true;
                txt_hasta.Enabled = true;
            }
            else
            {
                txt_desde.Enabled = false;
                txt_hasta.Enabled = false;
            }
        }

        private void btn_GenerarReporte_Click(object sender, EventArgs e)
        {
            NE_CompraVenta venta = new NE_CompraVenta();
            if (rd_mesAño.Checked == true)
            {
                ReportDataSource dato = new ReportDataSource("DataSetVenta", venta.RecuperarInformeVenta(txt_mesFiltro.Text));
                rv1.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.CompraVenta.Reporte_Ventas.rdlc";
                rv1.LocalReport.DataSources.Clear();
                rv1.LocalReport.DataSources.Add(dato);
                rv1.RefreshReport();
            }
            else
            {
                if (rd_periodo.Checked == true)
                {
                    ReportDataSource dato = new ReportDataSource("DataSetVenta", venta.RecuperarInformeVenta(txt_desde.Text, txt_hasta.Text));
                    rv1.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.CompraVenta.Reporte_Ventas.rdlc";
                    rv1.LocalReport.DataSources.Clear();
                    rv1.LocalReport.DataSources.Add(dato);
                    rv1.RefreshReport();

                }
                else
                {
                    //sin filtro
                    ReportDataSource dato = new ReportDataSource("DataSetVenta", venta.RecuperarInformeVenta());
                    rv1.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.CompraVenta.Reporte_Ventas.rdlc";
                    rv1.LocalReport.DataSources.Clear();
                    rv1.LocalReport.DataSources.Add(dato);
                    rv1.RefreshReport();
                }
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
