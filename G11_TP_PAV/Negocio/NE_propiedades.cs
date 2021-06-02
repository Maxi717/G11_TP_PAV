using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using G11_TP_PAV;
using G11_TP_PAV.Clases;

namespace G11_TP_PAV.Negocio
{
    class NE_Propiedades
    {

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT designacion_catastral, calle, numero, piso, departamento, barrios.nombre as 'barrio', tipo_propiedad.nombre as 'tipo' "
                        + "FROM propiedades INNER JOIN barrios ON propiedades.id_barrio = barrios.id_barrio "
                        + "INNER JOIN tipo_propiedad ON propiedades.id_tipo_propiedad = tipo_propiedad.id_tipo_propiedad";
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarDesignacion(string designacion)
        {
            string sql = @"SELECT designacion_catastral, calle, numero, piso, departamento,"
                        + "propiedades.id_barrio, propiedades.id_tipo_propiedad, barrios.nombre as 'barrio', tipos_propiedad.nombre as 'tipo' "
                        + "FROM propiedades "
                        + "INNER JOIN barrios ON propiedades.id_barrio = barrios.id_barrio "
                        + "INNER JOIN tipos_propiedad ON propiedades.id_tipo_propiedad = tipos_propiedad.id_tipo_propiedad "
                        + "WHERE designacion_catastral =" + designacion.ToString();
            return _BD.Consulta(sql);
        }

       public void insertarCompleto(string designacion, string calle, string numero, string piso, string departamento, string id_barrio, string id_tipo_propiedad)
        {
            string sql = @"INSERT INTO propiedades"
                         + " VALUES (" + designacion
                         + ", '" + calle + "'"
                         + ", " + numero
                         + ", " + piso
                         + ", " + departamento
                         + ", " + id_barrio 
                         + ", " + id_tipo_propiedad + ")";
            _BD.Consulta(sql);
        }

        public void insertarsindepto(string designacion, string calle, string numero, string id_barrio, string id_tipo_propiedad)
        {
            string sql = @"INSERT INTO propiedades (designacion_catastral, calle, numero, id_barrio, id_tipo_propiedad)"
                        + " VALUES (" + designacion
                        + ", '" + calle + "'"
                        + ", " + numero
                        + ", " + id_barrio
                        + ", " + id_tipo_propiedad + ")";
            _BD.Consulta(sql);
        }

        public void borrar (string designacion_catastral)
        {
            _BD.Consulta("DELETE FROM propiedades WHERE designacion_catastral = " + designacion_catastral);
        }

        public void modificarCompleto (string designacion, string calle, string numero, string piso, string departamento, string id_barrio, string id_tipo_propiedad)
        {
            string sql = @"UPDATE propiedades SET"
                        + " calle = '" + calle + "'"
                        + ", numero = " + numero
                        + ", piso = " + piso
                        + ", departamento = " + departamento
                        + ", id_barrio = " + id_barrio
                        + ", id_tipo_propiedad = " + id_tipo_propiedad
                        + " WHERE designacion_catastral = " + designacion;
            _BD.Consulta(sql);
        }

        public void modificarSinDepto(string designacion, string calle, string numero, string id_barrio, string id_tipo_propiedad)
        {
            string sql = @"UPDATE propiedades SET"
                        + " calle = '" + calle + "'"
                        + ", numero = " + numero
                        + ", piso = NULL"
                        + ", departamento = NULL"
                        + ", id_barrio = " + id_barrio
                        + ", id_tipo_propiedad = " + id_tipo_propiedad
                        + " WHERE designacion_catastral = " + designacion;
            _BD.Consulta(sql);
        }
    }
}