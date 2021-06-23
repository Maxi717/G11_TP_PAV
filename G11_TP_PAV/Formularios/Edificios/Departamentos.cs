using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G11_TP_PAV.Clases;
using G11_TP_PAV.Negocio;
using G11_TP_PAV;

namespace G11_TP_PAV.Formularios
{
    public partial class Departamentos : Form
    {

        public string id { get; set; }
        public Departamentos()
        {
            InitializeComponent();
        }

        NE_departamentos departamento = new NE_departamentos();


        private void button1_Click(object sender, EventArgs e)
        {
            AltaDepartamentos AltaDepto = new AltaDepartamentos();
            AltaDepto.ShowDialog();
            AltaDepto.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarDepartamentos ModifDepto = new ModificarDepartamentos();
            id = dataGridView1.CurrentRow.Cells["id_departamento"].Value.ToString();
            ModifDepto.id = id;
            ModifDepto.ShowDialog();
            ModifDepto.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BajaDepartamentos BajaDepto = new BajaDepartamentos();
            id = dataGridView1.CurrentRow.Cells["id_departamento"].Value.ToString();
            BajaDepto.id = id;
            BajaDepto.ShowDialog();
            BajaDepto.Dispose();
        }

        private void Departamentos_Load(object sender, EventArgs e)
        {
            cmb_Barrio.CargarCombo();
            cmb_Edificio.CargarCombo();
            dataGridView1.Rows.Clear();
            DataTable tabla = new DataTable();
            tabla = departamento.RecuperarDepartamentos();
            CargarGrilla(tabla);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chk_edificio.Checked == true)
            {

                dataGridView1.Rows.Clear();
                DataTable tabla = new DataTable();
                tabla = departamento.RecuperarDepartamentos();
                CargarGrilla(tabla);
            }
            if (cmb_Edificio.SelectedIndex != -1 && cmb_Barrio.SelectedIndex != -1)
            {
                dataGridView1.Rows.Clear();
                CargarGrilla(departamento.RecuperarBarrioEdificio(cmb_Barrio.SelectedValue.ToString(),cmb_Edificio.SelectedValue.ToString()));
                return;
            }

        }
        private void CargarGrilla(DataTable tabla)
        {
            if (tabla.Rows.Count == 0)
            {
                dataGridView1.Rows.Clear();

            }
            else
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = tabla.Rows[i]["Id_Departamento"].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = tabla.Rows[i]["Piso"].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = tabla.Rows[i]["Denominacion"].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = tabla.Rows[i]["Superficie"].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = tabla.Rows[i]["Porcentaje"].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = tabla.Rows[i]["Duenio"].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = tabla.Rows[i]["Domicilio"].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = tabla.Rows[i]["Barrio"].ToString();
                    



                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmb_Barrio.SelectedIndex = -1;
            cmb_Edificio.SelectedIndex = -1;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells["id_departamento"].Value.ToString();
        }

        private void chk_edificio_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Barrio.SelectedIndex = -1;
            cmb_Edificio.SelectedIndex = -1;
        }
    }

}