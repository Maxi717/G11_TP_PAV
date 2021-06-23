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

namespace G11_TP_PAV.Formularios
{
    public partial class Frm_ABMC_Publicidad : Form
    {
        public Frm_ABMC_Publicidad()
        {
            InitializeComponent();
        }

        private DataTable GenerarGrilla()
        {
            DataTable tablafull = new DataTable();
            NE_Publicidades publicidades = new NE_Publicidades();
            return publicidades.MostrarEnPantalla();

        }
        private void CargarGrilla(DataTable tabla)
        {
            grid_publicidades.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_publicidades.Rows.Add();
                grid_publicidades.Rows[i].Cells[0].Value = tabla.Rows[i]["id_publicidad"].ToString();
                grid_publicidades.Rows[i].Cells[1].Value = tabla.Rows[i]["Fecha"].ToString();
                grid_publicidades.Rows[i].Cells[2].Value = tabla.Rows[i]["Costo"].ToString();
                grid_publicidades.Rows[i].Cells[3].Value = tabla.Rows[i]["Precio"].ToString();
                grid_publicidades.Rows[i].Cells[4].Value = tabla.Rows[i]["Descripcion"].ToString();
                grid_publicidades.Rows[i].Cells[5].Value = tabla.Rows[i]["Publicado en:"].ToString();
            }
        }


        private void btn_iniciar_alta_Click(object sender, EventArgs e)
        {
            Frm_Alta_Publicidad alta = new Frm_Alta_Publicidad();
            alta.ShowDialog();
            DataTable tablafull = GenerarGrilla();
            CargarGrilla(tablafull);
        }

        private void grid_publicidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_ABMC_Publicidad_Load(object sender, EventArgs e)
        {
            DataTable tablafull = GenerarGrilla();
            CargarGrilla(tablafull);
        }
    }
}
