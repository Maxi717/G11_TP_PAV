using G11_TP_PAV.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G11_TP_PAV.Negocio
{
    class NE_ReportePropiedad
    {
        BE_Transaccional _BD_T = new BE_Transaccional();

        public DataTable RecuperarDesdeHasta(string min, string max)
        {
             string sql = @"SELECT designacion_catastral, calle, numero, piso, departamento, barrios.nombre as 'barrio', tipo_propiedad.nombre as 'tipo' "
                        + "FROM propiedades INNER JOIN barrios ON propiedades.id_barrio = barrios.id_barrio "
                        + "INNER JOIN tipo_propiedad ON propiedades.id_tipo_propiedad = tipo_propiedad.id_tipo_propiedad "
                        + "WHERE piso >= "+min+" AND piso <="+max;
            return _BD_T.Consulta(sql);
        }
    }
}
