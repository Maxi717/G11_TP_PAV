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

namespace G11_TP_PAV.Formularios.TransRecibos
{
    public partial class Frm_Transaccion_Recibos : Form
    {
        public Frm_Transaccion_Recibos()
        {
            InitializeComponent();
        }

        private void Frm_Transaccion_Recibos_Load(object sender, EventArgs e)
        {
            cmb_edificios.CargarCombo();
            cmb_edificios_R.CargarCombo();
            string sqlMes = "SELECT " + cmb_meses.Pp_Pk + ", "
                + cmb_meses.Pp_descripcion + " FROM " + cmb_meses.Pp_tabla_origen;
            cmb_meses.CargarCombo(sqlMes);
        }

        private void cmb_edificios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_departamentos.SelectedIndex = -1;
            if (cmb_edificios.SelectedValue != null)
            {
                cmb_departamentos.Pp_valorSelec = cmb_edificios.SelectedValue.ToString();
            }
            cmb_departamentos.CargarDobleCombo("id_edificio");
        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }


        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Expensa consultar = new Frm_Consultar_Expensa();
            consultar.id_depto = cmb_departamentos.SelectedValue.ToString();
            consultar.num_rec = cmb_fecha.SelectedValue.ToString();
            consultar.ShowDialog();
        }

        private void cmb_departamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_fecha.SelectedIndex = -1;
            if (cmb_departamentos.SelectedIndex != -1)
            {
                cmb_fecha.Pp_valorSelec = cmb_departamentos.SelectedValue.ToString();
                cmb_fecha.CargarComboFecha("id_departamento");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_edificios_R_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_departamentos_R.SelectedIndex = -1;
            if (cmb_edificios_R.SelectedValue != null)
            {
                cmb_departamentos_R.Pp_valorSelec = cmb_edificios_R.SelectedValue.ToString();
            }
            cmb_departamentos_R.CargarDobleCombo("id_edificio");
        }

        private void btn_recibo_Click(object sender, EventArgs e)
        {
            if (txt_anio.Text == "") { return; }
            //Calcular la expensa de un edificio es gastos del mes de ese edificio * superficie depto / superficie edificio
            int anio = Int16.Parse(txt_anio.Text);
            if (cmb_departamentos_R.SelectedValue == null
                || cmb_edificios_R.SelectedValue == null
                || cmb_meses.SelectedValue == null
                || anio < 2000 || anio > 3000)
            {
                MessageBox.Show("Debe seleccionar edificio, departamento, mes y año válidos");
            }
            else
            {
                string id_edificio = cmb_edificios_R.SelectedValue.ToString();
                string mes = cmb_meses.Text;
                if (txt_anio.Text != null)
                {
                    anio = Int16.Parse(txt_anio.Text);
                }
                string id_depto = cmb_departamentos_R.SelectedValue.ToString();
                NE_TransRecibos recibo = new NE_TransRecibos();
                double gastosEdificio = recibo.GastosEdificio(id_edificio, cmb_meses.SelectedValue.ToString(), anio.ToString());
                double superficieEdificio = recibo.SuperficieEdificio(id_edificio);
                double superficieDepto = recibo.SuperficieDepto(id_depto);
                //Calculamos el monto
                double montoExpensa = ((gastosEdificio * superficieDepto) / superficieEdificio);
                try
                {
                    int nro_expensa = recibo.CalcularNroExpensa();
                    string primerSQL = recibo.AltaExpensa(nro_expensa.ToString(), montoExpensa.ToString(), id_depto);
                    string segundoSQL = recibo.AltaRecibo(recibo.CalcularNroRecibo().ToString(), mes, anio.ToString(), nro_expensa.ToString());
                    List<string> sqls = new List<string>() { primerSQL, segundoSQL };
                    recibo.ejecutarTransRecibo(sqls);
                    MessageBox.Show("Recibo creado con exito, consultelo");
                }
                catch (Exception ex) { MessageBox.Show("Error al crear recibo." + ex.ToString()); }
            }

        }

        private void Txt_anio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int anio = Int16.Parse(txt_anio.Text);
            }
            catch (Exception) { MessageBox.Show("El año no es valido"); }
        }

        private void cmb_departamentos_R_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}