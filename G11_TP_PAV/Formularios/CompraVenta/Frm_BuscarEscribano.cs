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

namespace G11_TP_PAV.Formularios.CompraVenta
{
    public partial class Frm_BuscarEscribano : Form
    {
        public int matricula { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public Frm_BuscarEscribano()
        {
            InitializeComponent();
        }

        private void Frm_BuscarEscribano_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            NE_Escribanos escribano = new NE_Escribanos();

            DataTable tabla = new DataTable();
            tabla = escribano.RecuperarTodos();
            CargarGrilla(tabla);
        }



        private void CargarGrilla(DataTable tabla)
        {
            gdr_Escribanos.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                gdr_Escribanos.Rows.Add();
                gdr_Escribanos.Rows[i].Cells["Matricula"].Value = tabla.Rows[i]["Matricula"].ToString();
                gdr_Escribanos.Rows[i].Cells["Nombre"].Value = tabla.Rows[i]["Nombre"].ToString();
                gdr_Escribanos.Rows[i].Cells["Apellido"].Value = tabla.Rows[i]["Apellido"].ToString();
                
            }
        }


        private void gdr_Escribanos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            matricula = int.Parse(gdr_Escribanos.CurrentRow.Cells["Matricula"].Value.ToString());

            nombre = gdr_Escribanos.CurrentRow.Cells["Nombre"].Value.ToString();

            apellido = gdr_Escribanos.CurrentRow.Cells["Apellido"].Value.ToString();

            this.Close();
        }
    }




}
