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
    public partial class Frm_Consultar_Expensa : Form
    {
        public string id_depto { get; set; }
        public string num_rec { get; set; }

        public Frm_Consultar_Expensa()
        {
            InitializeComponent();
        }

        private void Frm_Consultar_Expensa_Load(object sender, EventArgs e)
        {
            NE_Transaccion_Recibos trans = new NE_Transaccion_Recibos();
            DataTable tabla = trans.GetFecha(num_rec);
            string mes = tabla.Rows[0]["mes"].ToString();
            string anio = tabla.Rows[0]["anio"].ToString();
            MostrarDatos(trans.GetAll(id_depto, mes, anio));
        }

        private void MostrarDatos(DataTable tabla)
        {
            grid_expensas.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_expensas.Rows.Add();
                grid_expensas.Rows[i].Cells[0].Value = tabla.Rows[i]["piso"].ToString();
                grid_expensas.Rows[i].Cells[1].Value = tabla.Rows[i]["denominacion"].ToString();
                grid_expensas.Rows[i].Cells[2].Value = tabla.Rows[i]["importe"].ToString();
                grid_expensas.Rows[i].Cells[3].Value = tabla.Rows[i]["mes"].ToString();
                grid_expensas.Rows[i].Cells[4].Value = tabla.Rows[i]["anio"].ToString();
                grid_expensas.Rows[i].Cells[5].Value = tabla.Rows[i]["domicilio"].ToString();
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_expensas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
