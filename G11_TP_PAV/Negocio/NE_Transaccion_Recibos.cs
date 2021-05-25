using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G11_TP_PAV.Clases;

namespace G11_TP_PAV.Negocio
{
    class NE_Transaccion_Recibos
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        public DataTable GetAll(string id_depto, string mes, string anio)
        {
            string sql = "SELECT piso, denominacion, importe, mes, anio, domicilio FROM expensas e INNER JOIN recibos r ON e.numero_expensa = r.numero_expensa INNER JOIN departamento d ON e.id_departamento = d.id_departamento INNER JOIN edificios ed ON ed.id=d.id_edificio WHERE d.id_departamento = "+id_depto+" AND r.mes = '"+mes+"' AND r.anio = "+anio;
            return _BD.Consulta(sql);
        }

        public DataTable GetFecha(string num_recibo)
        {
            string sql = "SELECT mes, anio FROM recibos WHERE numero_recibo = " +num_recibo;
            return _BD.Consulta(sql);
        }
    }
}
