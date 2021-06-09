using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace G11_TP_PAV.Clases
{
    class BE_Transaccional
    {
        public enum EstadoAccionBD { correcto, error };
        public enum EstadoTransaccion { correcta, error };
        public enum TipoConexion { simple, transaccional };
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlTransaction Transaccion;
        EstadoTransaccion ControlTransaccion = EstadoTransaccion.correcta;
        TipoConexion ControlConexion = TipoConexion.simple;
        string cadena_conexion = "Data Source=200.69.137.167,11333;" +
                                 "Initial Catalog=BD3K6G11_2021;Persist Security Info=True;" +
                                 "User ID=BD3K6G11_2021;Password=BDG11_9654";

        private void Conectar()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = cadena_conexion;
                Conexion.Open();
                Cmd.Connection = Conexion;
                Cmd.CommandType = CommandType.Text;
                if (ControlConexion == TipoConexion.transaccional)
                {
                    Transaccion = Conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    Cmd.Transaction = Transaccion;
                }
            }
        }

        public DataTable Consulta(string sql)
        {
            Conectar();
            DataTable tabla = new DataTable();
            Cmd.CommandText = sql;
            try
            {
                tabla.Load(Cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                + "En el comando:" + "\n"
                + sql + "\n"
                + "El mensaje es:" + "\n"
                + e.Message);
            }
            desconectar();
            return tabla;
        }

        private string EjecutarNoSelect(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                + "En el comando:" + "\n"
                + sql + "\n"
                + "El mensaje es:" + "\n"
                + e.Message);
            }
            if (sql.ToUpper().IndexOf("INSERT") >= 0)
            {
                DataTable tabla = new DataTable();
                Cmd.CommandText = "SELECT @@Identity";
                try
                {
                    tabla.Load(Cmd.ExecuteReader());
                }
                catch (Exception e)
                {
                    ControlTransaccion = EstadoTransaccion.error;
                    MessageBox.Show("Error con la Base de Datos" + "\n"
                    + "En el comando:" + "\n"
                    + "SELECT @@Identity \n"
                    + "El mensaje es:" + "\n"
                    + e.Message);
                }
                desconectar();
                return tabla.Rows[0][0].ToString();
            }
            else
            {
                desconectar();
                return "";
            }
        }

        private void desconectar()
        {
            if (ControlConexion == TipoConexion.simple)
            {
                Conexion.Close();
            }
        }
    }
}
