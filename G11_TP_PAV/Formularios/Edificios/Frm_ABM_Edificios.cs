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
using ABM_Edificios;
using G11_TP_PAV.Formularios;

namespace G11_TP_PAV.Formularios
{
    public partial class Frm_ABM_Edificios : Form
    {
        public string id { get; set; }


        public Frm_ABM_Edificios()
        {
            InitializeComponent();
        }
        NE_edificios edificio = new NE_edificios();
        private void Form1_Load(object sender, EventArgs e)
        {
            BE_Edificios _BD = new BE_Edificios();
            DataTable tabla = new DataTable();

            string sql;
            sql = "SELECT id_barrio, nombre FROM barrios";
            tabla = _BD.Ejecutar_Select(sql);
            cmb_barrio.DisplayMember = "nombre";
            cmb_barrio.ValueMember = "id_barrio";
            cmb_barrio.DataSource = tabla;

            dataGridView1.Rows.Clear();
            tabla = edificio.RecuperarEdificios();
            CargarGrilla(tabla);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (ck_todo.Checked == true)
            {
                dataGridView1.Rows.Clear();
                DataTable tabla = new DataTable();
                tabla = edificio.RecuperarEdificios();
                CargarGrilla(tabla);
            }
            if (cmb_barrio.SelectedIndex!=-1)
            {
                dataGridView1.Rows.Clear();
                CargarGrilla(edificio.RecuperarBarrio(cmb_barrio.SelectedValue.ToString()));
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
                        dataGridView1.Rows[i].Cells[0].Value = tabla.Rows[i]["ID"].ToString();
                        dataGridView1.Rows[i].Cells[1].Value = tabla.Rows[i]["DOMICILIO"].ToString();
                        dataGridView1.Rows[i].Cells[2].Value = tabla.Rows[i]["ASCENSOR"].ToString();
                        dataGridView1.Rows[i].Cells[3].Value = tabla.Rows[i]["cant_departamentos"].ToString();
                        dataGridView1.Rows[i].Cells[4].Value = tabla.Rows[i]["BARRIO"].ToString();


                }
            }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            cmb_barrio.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaEdificios alta = new AltaEdificios();
            alta.ShowDialog();
            alta.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.CurrentRow.Cells)
             id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmb_barrio.SelectedValue.ToString());
            ModificarEdificios modificar = new ModificarEdificios();
            id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();

            modificar.id = id;
            modificar.ShowDialog();
            modificar.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BajaEdificios baja = new BajaEdificios();
            id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();

            baja.id = id;
            baja.ShowDialog();
            baja.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Departamentos departamentos = new Departamentos();
            departamentos.ShowDialog();
            departamentos.Dispose();
        }

        private void ck_todo_CheckedChanged(object sender, EventArgs e)
        {
            cmb_barrio.SelectedIndex = -1;
        }
    }
}
