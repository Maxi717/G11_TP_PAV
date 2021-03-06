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
using G11_TP_PAV.Formularios.CompraVenta;
using G11_TP_PAV.Formularios.Gastos;
using G11_TP_PAV.Informes;
using G11_TP_PAV.Formularios.ContratoAlquiler;
using G11_TP_PAV.ReporteEma;
using G11_TP_PAV.Formularios.EstadisticaComisionTipoMoneda;
using G11_TP_PAV.Formularios.EstadisticaAlqTipoMoneda;
using G11_TP_PAV.Formularios.Publicidades;
using G11_TP_PAV.Formularios.ReporteGanancias;
using G11_TP_PAV.Est_Comi_Contrato;
using G11_TP_PAV.Est_Compra_Moneda;
using G11_TP_PAV.Formularios.Propiedades;
using G11_TP_PAV.Formularios.DepartamentosRepor;
using G11_TP_PAV.Formularios.EstadisticasGonza;
using G11_TP_PAV.Formularios.ListadoRecibosExpensas;
using G11_TP_PAV.Formularios.Estadisticas_Esteban;


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

        private void compraventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_CompraVenta cv = new Frm_CompraVenta();
            cv.ShowDialog();
            this.Show();
        }

        private void gastosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Listado_Gastos lgas = new Frm_Listado_Gastos();
            lgas.ShowDialog();
            this.Show();
        }

        private void contratosDeAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ListadoContratos lcon = new Frm_ListadoContratos();
            lcon.ShowDialog();
            this.Show();
        }

        private void publicidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ListadoPublicidades lisPub = new Frm_ListadoPublicidades();
            lisPub.ShowDialog();
            this.Show();
        }

        private void edificiosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ListadoEdificios lisEdif = new Frm_ListadoEdificios();
            lisEdif.ShowDialog();
            this.Show();
        }

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComisionesFacturas comisiones = new ComisionesFacturas();
            comisiones.ShowDialog();
            this.Show();
        }

        private void vencimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteVencimientoContrato venc = new ReporteVencimientoContrato();
            venc.ShowDialog();
            this.Show();
        }


        private void gananciasPorTipoDePropiedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_estadisticaGananciasPorTipoPropiedad est = new Frm_estadisticaGananciasPorTipoPropiedad();
            est.ShowDialog();
            this.Show();
        }

        private void gastosPublicitariosPorTipoDePropiedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Estadistica_Publicidades est = new Frm_Estadistica_Publicidades();
            est.ShowDialog();
            this.Show();
        }

        private void alquileresPorTipoDeMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_EstAlqTipoMoneda estATM = new Frm_EstAlqTipoMoneda();
            estATM.ShowDialog();
            this.Show();
        }

        private void comisionesPorTipoDeMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Estadistica_ComisionTipoMoneda estCTM = new Frm_Estadistica_ComisionTipoMoneda();
            estCTM.ShowDialog();
            this.Show();
        }

        private void compraVentasPorTipoDeMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Compra_Moneda estCVTM = new Frm_Compra_Moneda();
            estCVTM.ShowDialog();
            this.Show();
        }

        private void comisionesPorTipoDeContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Est_Comi_Contrato estCC = new Frm_Est_Comi_Contrato();
            estCC.ShowDialog();
            this.Show();
        }

        private void propiedadesDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Listado_Propiedades lp = new Frm_Listado_Propiedades();
            lp.ShowDialog();
            this.Show();
        }

        private void departamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ListadoDepartamentos ld = new Frm_ListadoDepartamentos();
            ld.ShowDialog();
            this.Show();
        }

        private void departamentosPorLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstadisticasProvincias ep = new EstadisticasProvincias();
            ep.ShowDialog();
            this.Show();
        }

        private void superficieDeDepartamentosPorLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstadisticasSuperficieBarrio esb = new EstadisticasSuperficieBarrio();
            esb.ShowDialog();
            this.Show();
        }

        private void compraVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ReporteVentas rvta = new Frm_ReporteVentas();
            rvta.ShowDialog();
            this.Show();
        }

        private void recibosYExpensasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ListadoRecibosExpensas lre = new Frm_ListadoRecibosExpensas();
            lre.ShowDialog();
            this.Show();
        }

        private void cantidadDeFacturasPorEscribanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Estadistica_cantFacturasXEscribano ecfe = new Frm_Estadistica_cantFacturasXEscribano();
            ecfe.ShowDialog();
            this.Show();
        }

        private void gastosPorEdificioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_EstadisticaGasto_x_Edificio ecfe = new Frm_EstadisticaGasto_x_Edificio();
            ecfe.ShowDialog();
            this.Show();
        }
    }
}