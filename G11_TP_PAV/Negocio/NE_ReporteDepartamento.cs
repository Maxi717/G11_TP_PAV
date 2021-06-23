using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G11_TP_PAV.Clases;

namespace G11_TP_PAV.Negocio
{
    class NE_ReporteDepartamento
    {
        public DataTable RecuperarDesdeHasta(string min, string max)
        {
            BE_Transaccional _BD = new BE_Transaccional();
            string sql = @"SELECT id_departamento, piso, denominacion, superficie, porcentaje, duenios.numero_documento as duenio, edificios.id as domicilio, barrios.id_barrio as barrio "
                        + "FROM[BD3K6G11_2021].[dbo].[departamento] depto join dbo.barrios barrios on depto.id_barrio = barrios.id_barrio join dbo.duenios duenios on depto.id_dueño = duenios.numero_documento join dbo.edificios edificios on depto.id_edificio = edificios.id"
                        + " WHERE superficie >= " + min + " AND superficie <= " + max;
            return _BD.Consulta(sql);
        }

    }
}
