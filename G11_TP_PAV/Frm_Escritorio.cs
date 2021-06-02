using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G11_TP_PAV.Formularios;
using G11_TP_PAV.Formularios.Dueños;
using G11_TP_PAV.Formularios.Escribanos;
using G11_TP_PAV.Formularios.Tipo_Moneda;
using G11_TP_PAV.Formularios.TransRecibos;
using G11_TP_PAV.Formularios.EmaContratoAlquiler;

namespace G11_TP_PAV
{
    public partial class Frm_Escritorio : Form
    {
        public Frm_Escritorio()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMC_Barrio barrio = new ABMC_Barrio();
            barrio.ShowDialog();
            this.Show();
        }

        private void propiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_AMB_Propiedades prop = new Frm_AMB_Propiedades();
            prop.ShowDialog();
            this.Show();
        }

        private void dueñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ABM_Duenios due = new Frm_ABM_Duenios();
            due.ShowDialog();
            this.Show();

        }

        private void publicidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ABMC_Publicidad pub = new Frm_ABMC_Publicidad();
            pub.ShowDialog();
            this.Show();
        }

        private void edificiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ABM_Edificios edificio = new Frm_ABM_Edificios();
            edificio.ShowDialog();
            this.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Departamentos depto = new Departamentos();
            depto.ShowDialog();
            this.Show();
        }

        private void escribanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ABM_Escribano escribano = new Frm_ABM_Escribano();
            escribano.ShowDialog();
            this.Show();
        }

        private void tiposDeMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ABM_TipoMoneda tipo_moneda = new Frm_ABM_TipoMoneda();
            tipo_moneda.ShowDialog();
            this.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Clientes cliente = new Frm_Clientes();
            cliente.ShowDialog();
            this.Show();
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Gastos gasto = new Frm_Gastos();
            gasto.ShowDialog();
            this.Show();
        }

        private void expensasRecibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Transaccion_Recibos transRec = new Frm_Transaccion_Recibos();
            transRec.ShowDialog();
            this.Show();
        }

        private void contratoAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ContratoAlquiler contrato = new Frm_ContratoAlquiler();
            contrato.ShowDialog();
            this.Show();
        }

        private void propiedadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_AMB_Propiedades prop = new Frm_AMB_Propiedades();
            prop.ShowDialog();
            this.Show();
        }
    }
}
