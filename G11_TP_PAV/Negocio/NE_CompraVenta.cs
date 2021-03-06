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

        
        public string fechaActual { get; set; }

        public int nroDoc { get; set; }

        public int id_documento { get; set; }

        public string designCatastral { get; set; }

        public decimal monto { get; set; }

        public string fechaPago { get; set; }

        public string tipoMoneda { get; set; }

        public int escribano { get; set; }





        BE_Acceso_Datos _BD = new BE_Acceso_Datos();



        public DataTable Recuperar()
        {
            string SqlSelect = @"SELECT cv.id_compraVenta, cv.fecha, c.nombre, cv.designacion_catastral, cv.monto, tm.nombre, cv.numero_factura
                                 FROM compraVentas cv JOIN clientes c 
                                                  ON cv.id_tipo_documento = c.id_tipo_documento AND cv.documento_comprador = c.numero_documento
                                                  JOIN tipo_moneda tm ON cv.id_moneda = tm.id_moneda";


            return _BD.Consulta(SqlSelect);
        }

        public void insertar()
        {

            List<string> listado = construirComando();

            try
            {
                _BD.Transaccion(listado);
                MessageBox.Show("La CompraVenta se registro con exito");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            
        }



        

        private List<string> construirComando()
        {
            string comandoFactura = crearCmdFactura();
            string comandoCompraVenta = crearCmdCompraVenta();

            List<string> lista = new List<string> { comandoFactura, comandoCompraVenta };
            
            return lista;
        }



        private string crearCmdFactura()
        {



            decimal comision = calcularComision(tipoMoneda);

            comision = comision / 100;

            comision = comision * monto;

            decimal monto_comision = comision + monto;


            string SqlInsertar = @"INSERT INTO facturas_comisiones3"
                                  + " (comision, monto_con_comision, fecha_pago, matricula_escribano)"
                                  + " VALUES ("
                                  + comision.ToString().Trim().Replace(",", ".")
                                  + ", " + monto_comision.ToString().Trim().Replace(",", ".") 
                                  + ", Convert (Date, '" + fechaPago + "', 103)"
                                  + ", " + escribano
                                  + ")";

            return SqlInsertar;
        }


        private decimal calcularComision(string tipoMoneda)
        {
            NE_Tipo_Moneda moneda = new NE_Tipo_Moneda();

            DataTable tabla = moneda.Recuperar_x_IdMoneda(tipoMoneda); 

            decimal numero = decimal.Parse(tabla.Rows[0][2].ToString());

            return numero;
        }

        private string crearCmdCompraVenta()
        {
            string idFactura = calcularIdFactura();

            string SqlInsertar = @"INSERT INTO compraVentas"
                                  + " (fecha, monto, id_moneda, designacion_catastral, documento_comprador, id_tipo_documento, numero_factura)"
                                  + " VALUES ("
                                  + "Convert (Date, '" + fechaActual + "', 103)"
                                  + ", " + monto.ToString().Trim().Replace(",", ".")
                                  + ", "+ tipoMoneda
                                  + ", '" + designCatastral + "'"
                                  + ", " + nroDoc
                                  + ", " + id_documento
                                  + ", " + idFactura
                                  + ")";

            return SqlInsertar;

        }



        private string calcularIdFactura()
        {
            string sql = @"SELECT *"
                          + " FROM facturas_comisiones3 ";

            DataTable tabla = _BD.Consulta(sql);

            int cantColum = tabla.Rows.Count;

            int id = int.Parse(tabla.Rows[cantColum - 1]["numero_factura"].ToString());
                    

            return (id + 1).ToString();

        }


        public DataTable RecuperarInformeVenta()
        {
            string SqlSelect = @"SELECT cv.id_compraVenta as id, cv.fecha as fecha, cv.monto as monto, tm.nombre as nombre_moneda, cv.designacion_catastral as design_catas, c.nombre as nombre_cliente, e.matricula as mp, e.apellido as apellido_escribano, e.nombre as nombre_escribano, cv.numero_factura as numero_factura
                                 FROM compraVentas cv JOIN clientes c 
                                                  ON cv.id_tipo_documento = c.id_tipo_documento AND cv.documento_comprador = c.numero_documento
                                                  JOIN tipo_moneda tm 
                                                  ON cv.id_moneda = tm.id_moneda
                                                  JOIN facturas_comisiones3 fc
                                                  ON cv.numero_factura = fc.numero_factura
                                                  JOIN escribanos e 
                                                  ON fc.matricula_escribano = e.matricula";


            return _BD.Consulta(SqlSelect);
        }

        public DataTable RecuperarInformeVenta(string FechaMes)
        {
            string[] dato = FechaMes.Split('/');

            string SqlSelect = @"SELECT cv.id_compraVenta as id, cv.fecha as fecha, cv.monto as monto, tm.nombre as nombre_moneda, cv.designacion_catastral as design_catas, c.nombre as nombre_cliente, e.matricula as mp, e.apellido as apellido_escribano, e.nombre as nombre_escribano, cv.numero_factura as numero_factura
                                 FROM compraVentas cv JOIN clientes c 
                                                  ON cv.id_tipo_documento = c.id_tipo_documento AND cv.documento_comprador = c.numero_documento
                                                  JOIN tipo_moneda tm 
                                                  ON cv.id_moneda = tm.id_moneda
                                                  JOIN facturas_comisiones3 fc
                                                  ON cv.numero_factura = fc.numero_factura
                                                  JOIN escribanos e 
                                                  ON fc.matricula_escribano = e.matricula
                                WHERE month(cv.fecha) = "+ dato[0] +" AND YEAR(cv.fecha) = "+ dato[1] +"";

            return _BD.Consulta(SqlSelect);


        }

        public DataTable RecuperarInformeVenta(string fechaDesde , string fechaHasta)
        {

            string SqlSelect = @"SELECT cv.id_compraVenta as id, cv.fecha as fecha, cv.monto as monto, tm.nombre as nombre_moneda, cv.designacion_catastral as design_catas, c.nombre as nombre_cliente, e.matricula as mp, e.apellido as apellido_escribano, e.nombre as nombre_escribano, cv.numero_factura as numero_factura
                                 FROM compraVentas cv JOIN clientes c 
                                                  ON cv.id_tipo_documento = c.id_tipo_documento AND cv.documento_comprador = c.numero_documento
                                                  JOIN tipo_moneda tm 
                                                  ON cv.id_moneda = tm.id_moneda
                                                  JOIN facturas_comisiones3 fc
                                                  ON cv.numero_factura = fc.numero_factura
                                                  JOIN escribanos e 
                                                  ON fc.matricula_escribano = e.matricula
                                WHERE (cv.fecha >= '" + fechaDesde + "') AND (cv.fecha <= '"+ fechaHasta +"')";

            return _BD.Consulta(SqlSelect);
        }




        public DataTable gananciasPorTipoPropiedad()
        {
            string sql = @"SELECT unido.tipo_propiedad, SUM(unido.ganancias) AS ganancias FROM(
                           SELECT  tipo_propiedad.nombre as tipo_propiedad, SUM(facturas_comisiones3.comision) AS ganancias FROM facturas_comisiones3 
                           JOIN compraVentas ON facturas_comisiones3.numero_factura = compraVentas.numero_factura 
                           JOIN propiedades ON compraVentas.designacion_catastral = propiedades.designacion_catastral 
                           JOIN tipo_propiedad ON propiedades.id_tipo_propiedad = tipo_propiedad.id_tipo_propiedad 
                           GROUP BY (tipo_propiedad.nombre)
                           UNION
                           SELECT  tipo_propiedad.nombre as tipo_propiedad, SUM(facturas_comisiones3.comision) AS ganancias FROM facturas_comisiones3
                           JOIN contratoAlquiler ON facturas_comisiones3.numero_factura = contratoAlquiler.numero_facturas 
                           JOIN propiedades ON contratoAlquiler.designacion_catatral = propiedades.designacion_catastral 
                           JOIN tipo_propiedad ON propiedades.id_tipo_propiedad = tipo_propiedad.id_tipo_propiedad 
                           GROUP BY (tipo_propiedad.nombre)) AS unido
                           GROUP BY (unido.tipo_propiedad)";
            return (_BD.Consulta(sql));
        }
  
    }
}
