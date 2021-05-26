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
        public string Pp_id_contrato { get; set; }
        public string Pp_fechaInicio { get; set; }
        public string Pp_duracionContrato { get; set; }
        public string Pp_monto { get; set; }
        public string Pp_porcentaje { get; set; }
        public string Pp_propiedad { get; set; }
        public string Pp_cliente { get; set; }
        public string Pp_escribano { get; set; }

        BE_Edificios _BD = new BE_Edificios();
        DataTable tabla = new DataTable();



        public DataTable RecuperarDatos()
        {
            string sql = "SELECT fact.nro_factura, cont.fecha_inicio,cont.monto * (0.01 *fact.comision) as monto,concat (moneda.nombre,'-',moneda.porcentaje_comision,'%') as id_tipo_moneda,CONCAT(prop.calle, prop.numero) as propiedad,cont.documento FROM facturas_comisiones fact join contratoAlquiler cont on cont.id_contratoALQ = fact.contrato_alquiler join propiedades prop on cont.designacion_catatral = prop.designacion_catastral join tipo_moneda moneda on cont.id_tipo_moneda = moneda.id_moneda";
            return _BD.Ejecutar_Select(sql);

        }
        public void InsertarContratoAlquiler()
        {
            string sqlInsertar = "INSERT INTO contratoAlquiler (fecha_inicio,duracion_contrato,monto,id_tipo_moneda,designacion_catatral,documento) VALUES('" + Pp_fechaInicio + "' , '" + Pp_duracionContrato + "' , '" + Pp_monto + "' , '" + Pp_porcentaje + "', '" + Pp_propiedad + "', '" + Pp_cliente +  "' )";

            _BD.Insertar(sqlInsertar);

        }

        public void InsertarFactura() {
            string sqlSelect = "select * from contratoAlquiler where id_contratoALQ in(select MAX(id_contratoALQ) as ID from contratoAlquiler )";
            tabla =_BD.Ejecutar_Select(sqlSelect);
            Pp_id_contrato = tabla.Rows[0]["id_contratoALQ"].ToString();
            string sqlInsertar = "INSERT INTO facturas_comisiones (comision,monto,fecha_pago,matricula_escribano,contrato_alquiler) VALUES('" + Pp_porcentaje + "' , '" + Pp_monto + "' , '" + Pp_fechaInicio + "' , '" + Pp_escribano + "', '" + Pp_id_contrato + "' )";
            _BD.Insertar(sqlInsertar);
        }
    }
}
