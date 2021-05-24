using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G11_TP_PAV.Clases;
using System.Data;

namespace G11_TP_PAV.Negocio
{
    class NE_Publicidades
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable RecuperarTodos()
        {
            string sql = "SELECT * FROM publicidades";
            return _BD.Consulta(sql);
        }

        public DataTable MostrarEnPantalla()
        {
            string sql = @"SELECT publicidades.id_publicidad as 'id_publicidad', publicidades.fecha as 'Fecha',
                           publicidades.costo as 'Costo',
                           publicidades.precio as 'Precio', publicidades.descripcion as 'Descripcion', 
                           secciones.nombre as 'Publicado en:'
                           FROM PUBLICIDADES 
                           INNER JOIN secciones ON publicidades.id_seccion = secciones.id_seccion";
            return _BD.Consulta(sql);
        }

        public DataTable BusquedaAvanzada(string sql)
        {
            return _BD.Consulta(sql);
        }

        public void AltaPublicidades(string fecha, double costo, double precio, string descripcion, string id_seccion, string designacion_catastral)
        {
            string sql = @"INSERT INTO publicidades (fecha, precio, costo, descripcion, id_seccion, designacion_catastral)
                            VALUES ('" + fecha + "', " + precio.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + ", " + costo.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + ", '"+ descripcion + "', "+ 
                            id_seccion + ", " + designacion_catastral + ")";
            _BD.Insertar(sql);
        }

        public void ModPublicidad(string id_publicidad, string fecha, double costo, double precio, string descripcion, string id_seccion, string designacion_catastral)
        {
            string sqlMod = @"UPDATE publicidades SET fecha = '" + fecha + "' , costo = " + costo.ToString() + ", precio = " +
                            precio.ToString() + ", descripcion = " + descripcion + ", id_seccion = " + id_seccion + 
                            ", designacion_catastral = " + designacion_catastral + 
                            " WHERE id_publicidad = " + id_publicidad;
            _BD.Modificar(sqlMod);
        }

        public void BajaPublicidad(string id_publicidad)
        {
            string sqlDel = "DELETE FROM publicidades WHERE id_publicidad = " + id_publicidad;
            _BD.Borrar(sqlDel);
        }

        public string ConvertirFecha(DateTime fechaHora)
        {
            string fecha = fechaHora.Date.ToString();
            for(int i = 0; i <= 8; i++)
            {
                fecha = fecha.Remove(fecha.Length - 1);
            }
            return fecha;

        }
    }
}
    