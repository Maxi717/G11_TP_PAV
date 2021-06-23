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
    class NE_duenios
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        BE_Transaccional _BD_T = new BE_Transaccional();

        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT numero_documento, duenios.id_tipo_documento, nombre, telefono, domicilio, tipo_documento.Nombre_tipo_documento as 'tipo_documento_nombre' "
                        + "FROM duenios INNER JOIN tipo_documento ON duenios.id_tipo_documento = tipo_documento.Id_tipo_documento";
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarDocumento(string numero_documento, string tipo_documento)
        {
            string sql = @"SELECT numero_documento, duenios.id_tipo_documento, nombre, telefono, domicilio, tipo_documento.Nombre_tipo_documento as 'tipo_documento_nombre' "
                        + "FROM duenios INNER JOIN tipo_documento ON duenios.id_tipo_documento = tipo_documento.Id_tipo_documento "
                        + "WHERE numero_documento = " + numero_documento + " AND duenios.id_tipo_documento = " + tipo_documento;
            return _BD.Consulta(sql);
        }

        public void insertarDuenio(string numero_documento, string id_tipo_documento, string nombre, string telefono, string domicilio)
        {
            string sql = @"INSERT INTO duenios"
                         + " VALUES (" + numero_documento
                         + ", " + id_tipo_documento
                         + ", '" + nombre + "'"
                         + ", '" + telefono + "'"
                         + ", '" + domicilio + "')";
            _BD.Consulta(sql);
        }

        public void modificarDuenio(string numero_documento, string id_tipo_documento, string nombre, string telefono, string domicilio)
        {
            string sql = @"UPDATE duenios SET"
                        + " id_tipo_documento = " + id_tipo_documento
                        + ", nombre = '" + nombre + "'"
                        + ", telefono = '" + telefono + "'"
                        + ", domicilio = '" + domicilio + "'"
                        +" WHERE numero_documento = " + numero_documento;
            _BD.Consulta(sql);
        }

        public void borrar(string numero_documento, string id_tipo_documento)
        {
            _BD.Consulta("DELETE FROM duenios WHERE numero_documento = " + numero_documento + " AND id_tipo_documento = " + id_tipo_documento);
        }

        public void borrar_asociacion(string documento, string tipo_documento)
        {
            _BD_T.Consulta("DELETE FROM asociaciones WHERE documento = " + documento + " AND tipo_documento = " + tipo_documento);
        }

    }
}
