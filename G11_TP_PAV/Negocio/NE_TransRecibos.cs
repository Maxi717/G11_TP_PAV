using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G11_TP_PAV.Clases;
using System.Data;
using System.Data.SqlClient;

namespace G11_TP_PAV.Negocio
{
    class NE_TransRecibos
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable RecuperarExpensas()
        {
            string sql = "SELECT * FROM expensas";
            return _BD.Consulta(sql);
        }

        public DataTable BusquedaAvanzada(string sql)
        {
            return _BD.Consulta(sql);
        }

        public void AltaRecibo(string numero_recibo, string mes_, string anio, string numero_expensa)
        {
            string sql = "INSERT INTO recibos (numero_recibo, mes, anio, numero_expensa)" +
                "VALUES " +
                "("+ numero_recibo+ ", '"+ mes_ +"', " + anio + ", "+ numero_expensa +")";
            _BD.Insertar(sql);
        }

        public void AltaExpensa(string numero, string importe, string id_depto)
        {
            string sql = "INSERT INTO expensas (numero_expensa, importe, id_departamento)" +
             "VALUES " +
            "(" + numero + ", " + importe + ", " + id_depto + ")";
            _BD.Insertar(sql);
        }

        public double GastosEdificio(string id_edificio)
        {
            DataTable gastosEd = _BD.Consulta("SELECT SUM(importe) FROM GASTOS WHERE id_edificio = " + id_edificio);
            double gastoTotal = double.Parse(gastosEd.Rows[0][0].ToString());
            return gastoTotal;
        }

        public double SuperficieEdificio(string id_edificio)
        {
            DataTable supsEd = _BD.Consulta("SELECT SUM(superficie) FROM departamento WHERE id_edificio = " + id_edificio);
            double superficieTotal = double.Parse(supsEd.Rows[0][0].ToString());
            return superficieTotal;
        }

        public double SuperficieDepto(string id_depto)
        {
            DataTable supsEd = _BD.Consulta("SELECT superficie FROM departamento WHERE id_departamento = " + id_depto);
            double supDpto = double.Parse(supsEd.Rows[0][0].ToString());
            return supDpto;
        }
 
        public int CalcularNroExpensa()
        {
            DataTable expensas = _BD.Consulta("SELECT * FROM expensas");
            int nroExpensa = (expensas.Rows.Count) + 1;
            return nroExpensa;
        }
        public int CalcularNroRecibo()
        {
            DataTable recibos = _BD.Consulta("SELECT * FROM recibos");
            int nroRecibo = (recibos.Rows.Count) + 1;
            return nroRecibo;
        }
    }
}

