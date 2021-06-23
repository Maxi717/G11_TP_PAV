using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G11_TP_PAV.Clases;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public string AltaRecibo(string numero_recibo, string mes_, string anio, string numero_expensa)
        {
            string sql = "INSERT INTO recibos (numero_recibo, mes, anio, numero_expensa)" +
                "VALUES " +
                "("+ numero_recibo+ ", '"+ mes_ +"', " + anio + ", "+ numero_expensa +")";
            return sql;
        }

        public string AltaExpensa(string numero, string importe, string id_depto)
        {
            string sql = "INSERT INTO expensas (numero_expensa, importe, id_departamento)" +
             "VALUES " +
            "(" + numero + ", " + importe + ", " + id_depto + ")";
            return sql;
         }

        public void ejecutarTransRecibo(List<string> comandos)
        {
            _BD.Transaccion(comandos);
        }
            

        public double GastosEdificio(string id_edificio, string mes, string anio)
        {
            DataTable gastosEd = _BD.Consulta("SELECT SUM(importe) FROM GASTOS WHERE id_edificio = " + id_edificio +
                "AND YEAR(fecha) = "+ anio + " AND MONTH(fecha) = "+ mes);
            if (gastosEd.Rows[0][0].ToString() != "")
            {
                double gastoTotal = double.Parse(gastosEd.Rows[0][0].ToString());
                return gastoTotal;
            }
            else { return double.Parse("0"); }
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

        public DataTable recuperarListado()
        {
            string sql = @"SELECT r.numero_recibo AS numero , r.mes AS mes, r.anio AS año, r.numero_expensa AS numeroExpensa, e.importe AS importe, e.id_departamento AS idDepto, d.id_dueño AS idDueño 
                            FROM recibos r JOIN expensas e ON r.numero_expensa = e.numero_expensa 
                            JOIN departamento d ON e.id_departamento = d.id_departamento";

            return _BD.Consulta(sql);
        }

        public DataTable recuperarListado( string fechaMes)
        {
            string[] dato = fechaMes.Split('/');

            int indice = int.Parse(dato[0]);

            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            string sql = @"SELECT r.numero_recibo AS numero , r.mes AS mes, r.anio AS año, r.numero_expensa AS numeroExpensa, e.importe AS importe, e.id_departamento AS idDepto, d.id_dueño AS idDueño 
                            FROM recibos r JOIN expensas e ON r.numero_expensa = e.numero_expensa 
                            JOIN departamento d ON e.id_departamento = d.id_departamento
                            WHERE r.mes = '"+ meses[indice - 1] +"' AND r.anio = "+ dato[1] +"";

            return _BD.Consulta(sql);
        }

    }
}

