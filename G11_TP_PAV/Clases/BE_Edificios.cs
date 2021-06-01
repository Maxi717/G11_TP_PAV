using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace G11_TP_PAV.Clases
{
    class BE_Edificios
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlTransaction objTransaction = null;

        public bool resultado { get; private set; }

        private void conectar()
        {
            conexion.ConnectionString = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K6G11_2021;Persist Security Info=True;User ID=BD3K6G11_2021;Password=BDG11_9654";
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;


        }
        private void desconectar()
        {
            conexion.Close();

        }
        public DataTable Ejecutar_Select(string sql)
        {
            conectar();
            cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;

        }
        public void Insertar(string sqlInsertar)
        {
            conectar();
            objTransaction = conexion.BeginTransaction("Insertar");
            cmd.Transaction = objTransaction;

            try
            {
                cmd.CommandText = sqlInsertar;
                cmd.ExecuteNonQuery();

                objTransaction.Commit();
                resultado = true;
                
            } catch(Exception ex){
                objTransaction.Rollback();
                resultado = false;

            }
                desconectar();


        }
        public void Validar()
        {
            if (resultado)
            { MessageBox.Show("Proceso realizado correctamente"); }
            else { MessageBox.Show("Error"); }
        }

        public void Modificar(string sqlInsertar)
        {
            conectar();
            cmd.CommandText = sqlInsertar;
            cmd.ExecuteNonQuery();
            desconectar();
        }
        public void Borrar (string sqlBorrar)
        {
            conectar();
            cmd.CommandText = sqlBorrar;
            cmd.ExecuteNonQuery();
            desconectar();
        }

    }
}
