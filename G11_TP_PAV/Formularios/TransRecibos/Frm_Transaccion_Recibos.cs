using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void cmb_edificios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_departamentos.SelectedIndex = -1;
            cmb_departamentos.Pp_valorSelec = cmb_edificios.SelectedValue.ToString();
            cmb_departamentos.CargarDobleCombo("id_edificio");          
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Expensa consultar = new Frm_Consultar_Expensa();
            consultar.id_depto = cmb_departamentos.SelectedValue.ToString();
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
    }
}
