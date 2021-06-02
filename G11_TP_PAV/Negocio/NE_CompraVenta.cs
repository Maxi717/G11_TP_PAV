using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using G11_TP_PAV.Clases;
using System.Windows.Forms;

namespace G11_TP_PAV.Negocio
{
    class NE_CompraVenta
    {

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        
        public DataTable Recuperar()
        {
            string SqlSelect = @"SELECT cv.id_compraVenta, cv.fecha, c.nombre, cv.designacion_catastral, cv.monto, tm.nombre, cv.numero_factura
                                 FROM compraVentas cv JOIN clientes c 
                                                  ON cv.id_tipo_documento = c.id_tipo_documento AND cv.documento_comprador = c.numero_documento
                                                  JOIN tipo_moneda tm ON cv.id_moneda = tm.id_moneda";


            return _BD.Consulta(SqlSelect);
        }


    }
}
