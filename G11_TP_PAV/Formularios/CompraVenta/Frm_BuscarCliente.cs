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
    public partial class Frm_BuscarCliente : Form
    {


        public string nombre { get; set; }
        public int id_tipo_documento { get; set; }
        public int numero_documento { get; set; }



        public Frm_BuscarCliente()
        {
            InitializeComponent();
        }

        private void Frm_BuscarCliente_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();

        }


        private void ActualizarGrilla()
        {
            NE_Clientes cliente = new NE_Clientes();
            
            DataTable tabla = new DataTable();
            tabla = cliente.RecuperarTodos();
            CargarGrilla(tabla);
        }


        private void CargarGrilla(DataTable tabla)
        {
            gdr_Cliente.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                gdr_Cliente.Rows.Add();
                gdr_Cliente.Rows[i].Cells["Nombre"].Value = tabla.Rows[i]["nombre"].ToString();
                gdr_Cliente.Rows[i].Cells["Tipo_Doc"].Value = tabla.Rows[i]["nombre_tipo_documento"].ToString();
                gdr_Cliente.Rows[i].Cells["Nro_Doc"].Value = tabla.Rows[i]["numero_documento"].ToString();
                gdr_Cliente.Rows[i].Cells["Id_Tipo_Doc"].Value = tabla.Rows[i]["id_tipo_documento"].ToString();
            }
        }


        private void gdr_Cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre = gdr_Cliente.CurrentRow.Cells["Nombre"].Value.ToString();
            id_tipo_documento = int.Parse(gdr_Cliente.CurrentRow.Cells["Id_Tipo_Doc"].Value.ToString());
            numero_documento = int.Parse(gdr_Cliente.CurrentRow.Cells["Nro_Doc"].Value.ToString());

            this.Close();
        }
    }
}
