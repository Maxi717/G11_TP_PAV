using G11_TP_PAV.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G11_TP_PAV.Negocio
{
    class NE_EstadisticasGonza
    {
        public DataTable RecuperarDesdeHasta(string min, string max)
        {
            BE_Transaccional _BD = new BE_Transaccional();
            string sql = @"SELECT p.nombre as nombre, count (e.id) as detalle "
                        +"FROM edificios e "
	                    +"INNER JOIN barrios b on e.id_barrio=b.id_barrio "
	                    +"INNER JOIN localidades l on b.id_localidad=l.id_localidad "
	                    +"INNER JOIN provincias p on l.id_provincia=p.id_provincia "
                        + "WHERE e.cant_departamentos >= " + min + "AND e.cant_departamentos <=  "+ max
                        + "GROUP BY p.nombre";
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarSuperficie(string id)
        {
            BE_Transaccional _BD = new BE_Transaccional();
            string sql = @"SELECT l.nombre as nombre, sum(d.superficie) as detalle "
                         + "FROM departamento d "
                         + "INNER JOIN barrios b on d.id_barrio=b.id_barrio "
                         + "INNER JOIN localidades l on b.id_localidad=l.id_localidad "
                         + "INNER JOIN provincias p on l.id_provincia=p.id_provincia "
                         + "WHERE p.id_provincia = " + id
                         + " GROUP BY l.nombre";
            return _BD.Consulta(sql);
        }
    }
}
