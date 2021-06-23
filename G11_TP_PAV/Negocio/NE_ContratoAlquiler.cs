using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G11_TP_PAV.Clases;
using System.Data;
using System.Windows.Forms;

namespace G11_TP_PAV.Negocio
{
    class NE_ContratoAlquiler
    {
        public string Pp_nroFactura { get; set; }
        public string Pp_fechaInicio { get; set; }
        public string Pp_duracionContrato { get; set; }
        public string Pp_monto { get; set; }
        public string Pp_porcentaje { get; set; }
        public string Pp_propiedad { get; set; }
        public string Pp_cliente { get; set; }
        public string Pp_escribano { get; set; }

        BE_Edificios _BD = new BE_Edificios();
        DataTable tabla = new DataTable();
        BE_Acceso_Datos _BD2 = new BE_Acceso_Datos();


        public DataTable RecuperarDatos()
        {
            string sql = "SELECT fact.numero_factura, cont.fecha_inicio,cont.monto * (0.01 * fact.comision) as monto,concat(moneda.nombre, '-', moneda.porcentaje_comision, '%') as id_tipo_moneda,CONCAT(prop.calle, prop.numero) as propiedad,cont.documento FROM facturas_comisiones3 fact join contratoAlquiler cont on cont.numero_facturas = fact.numero_factura join propiedades prop on cont.designacion_catatral = prop.designacion_catastral join tipo_moneda moneda on cont.id_tipo_moneda = moneda.id_moneda";
            return _BD.Ejecutar_Select(sql);

        }

        public DataTable ReporteVencimientos()
        {
            string sql = "SELECT TOP (1000) [id_contratoALQ],[fecha_inicio],[duracion_contrato],[monto],[id_tipo_moneda],[designacion_catatral],cliente.nombre FROM [BD3K6G11_2021].[dbo].[contratoAlquiler] contrato join dbo.clientes cliente on contrato.documento = cliente.numero_documento where convert(date,duracion_contrato,105)>= convert(date,'" + Pp_fechaInicio + "',105) and convert(date,duracion_contrato,105)<= convert(date,'" + Pp_duracionContrato + "',105)";
            return _BD.Ejecutar_Select(sql);

        }

        public DataTable ListadoFacturasComisiones()
        {
            string sql = "SELECT facturas.numero_factura, facturas.fecha_pago, facturas.monto_con_comision, { fn CONCAT(propiedades.calle,CONVERT(CHAR,propiedades.numero)) } AS propiedad, ventas.id_compraVenta FROM compraVentas AS ventas  INNER JOIN facturas_comisiones3 AS facturas ON ventas.numero_factura = facturas.numero_factura INNER JOIN propiedades AS propiedades ON ventas.designacion_catastral = propiedades.designacion_catastral where convert(date,facturas.fecha_pago,105)>= convert(date,'" + Pp_fechaInicio + "',105) and convert(date,facturas.fecha_pago,105)<= convert(date,'" + Pp_duracionContrato + "',105)";
            return _BD.Ejecutar_Select(sql);

        }

        public DataTable RecuperarTodos()
        {
            string sql = "SELECT * FROM contratoAlquiler";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable RecuperarParaEstadistica()
        {
            string sql = "SELECT  tipo_moneda.nombre as Moneda, COUNT(*) as Cantidad FROM contratoAlquiler INNER JOIN tipo_moneda ON contratoAlquiler.id_tipo_moneda = tipo_moneda.id_moneda GROUP   BY contratoAlquiler.id_tipo_moneda, tipo_moneda.nombre";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable RecuperarPorFecha(DateTime desde, DateTime hasta)
        {
            string fechaDesde = desde.ToString();
            string fechaHasta = hasta.ToString();
            string sql = "SELECT * FROM contratoAlquiler WHERE fecha_inicio > '" + fechaDesde + "' AND fecha_inicio < '" +
                fechaHasta + "'";
            return _BD2.Consulta(sql);
        }

        public void InsertarContratoAlquiler()
        {


        }


        public void InsertarFactura() {
            string ConsultarPorcentaje = "SELECT porcentaje_comision FROM tipo_moneda WHERE id_moneda = '" + Pp_porcentaje + "'";
            tabla = _BD.Ejecutar_Select(ConsultarPorcentaje);
            string Comision = tabla.Rows[0]["porcentaje_comision"].ToString();

            string Porcentaje = (int.Parse(Pp_monto) * 0.01 * double.Parse(Comision)).ToString();
            string sqlInsertar = "INSERT INTO facturas_comisiones3 (comision,monto_con_comision,fecha_pago,matricula_escribano) VALUES('" + Pp_porcentaje + "' , '" + Porcentaje + "' , '" + Pp_fechaInicio + "' , '" + Pp_escribano + "')";
            _BD.Insertar(sqlInsertar);
            string sqlSelect = "select * from facturas_comisiones3 where numero_factura in(select MAX(numero_factura) as ID from facturas_comisiones3 )";
            tabla = _BD.Ejecutar_Select(sqlSelect);
            Pp_nroFactura = tabla.Rows[0]["numero_factura"].ToString();

            string sqlInsertarCont = "INSERT INTO contratoAlquiler (fecha_inicio,duracion_contrato,monto,id_tipo_moneda,designacion_catatral,documento,numero_facturas) VALUES('" + Pp_fechaInicio + "' , '" + Pp_duracionContrato + "' , '" + Pp_monto + "' , '" + Pp_porcentaje + "', '" + Pp_propiedad + "', '" + Pp_cliente + "', '" + Pp_nroFactura + "')";
            _BD.Insertar(sqlInsertarCont);



            _BD.Validar();
        }

        public DataTable Info_Etd_ComiXTipo()
        {
            string ComiXTipo = "SELECT 'Contrato Alquiler' AS TIPO ,SUM(A.monto) AS MONTO FROM [BD3K6G11_2021].[dbo].[facturas_comisiones3] F FULL join dbo.contratoAlquiler A on A.numero_facturas = F.numero_factura UNION SELECT 'Contrato Venta' AS TIPO ,SUM(V.monto) AS MONTO FROM [BD3K6G11_2021].[dbo].[facturas_comisiones3] F FULL join dbo.compraVentas V on V.numero_factura = F.numero_factura";
            return _BD.Ejecutar_Select(ComiXTipo);

        }

        public DataTable EST_Compra_Moneda()
        {
            string Compra_Venta = "SELECT m.nombre AS Moneda,count(v.id_moneda) AS Cantidades FROM[BD3K6G11_2021].[dbo].[compraVentas] V inner join tipo_moneda M on m.id_moneda = v.id_moneda group BY(m.nombre)";
            return _BD.Ejecutar_Select(Compra_Venta);

        }
    }
}
