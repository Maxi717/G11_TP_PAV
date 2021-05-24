using G11_TP_PAV.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G11_TP_PAV.Negocio
{
    class NE_Gastos
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable RecuperarTodos()
        {
            string sql = "SELECT * FROM gastos g join edificios e on g.id_edificio=e.id";
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarEdificio(string id_edificio)
        {
            string sql = "SELECT * FROM gastos g join edificios e on g.id_edificio=e.id WHERE g.id_edificio = " + id_edificio;
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarComprobante(string importe)
        {
            string sql = "SELECT * FROM gastos g join edificios e on g.id_edificio=e.id WHERE g.importe = " + importe;
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarProveedor(string proveedor)
        {
            string sql = "SELECT * FROM gastos g join edificios e on g.id_edificio=e.id WHERE g.proveedor = '" + proveedor + "'";
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarMixto(string importe, string id_edificio)
        {
            string sql = "SELECT * FROM gastos g join edificios e on g.id_edificio=e.id WHERE g.id_edificio = " + id_edificio + " AND g.importe = " + importe;
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarTresValores(string id_edificio, string importe, string proveedor)
        {
            string sql = "SELECT * FROM gastos g join edificios e on g.id_edificio=e.id WHERE g.id_edificio = " + id_edificio + " AND g.importe = " + importe + " g.proveedor = '" + proveedor + "'";
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarComprobanteMasProveedor(string importe, string proveedor)
        {
            string sql = "SELECT * FROM gastos g join edificios e on g.id_edificio=e.id WHERE g.importe = " + importe + " g.proveedor = '" + proveedor + "'";
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarImporte(string numero_comprobante)
        {
            string sql = "SELECT * FROM gastos g join edificios e on g.id_edificio=e.id WHERE g.numero_comprobante = " + numero_comprobante;
            return _BD.Consulta(sql);
        }

        public void InsertarGastos(Control.ControlCollection controles)
        {
            TratEsp tratamiento = new TratEsp();
            _BD.Insertar(tratamiento.ConstructorInsert("gastos", controles));
        }

        public void ModificarGastos(Control.ControlCollection controles, string num_comprobante)
        {
            TratEsp tratamiento = new TratEsp();
            _BD.Insertar(tratamiento.ConstructorModificar("gastos", controles, "numero_comprobante = ", num_comprobante));
        }

        public void BorradoGastos(string numero_comprobante)
        {
            TratEsp tratamientos = new TratEsp();
            _BD.Insertar(tratamientos.ConstructorBorrar("gastos", "numero_comprobante", numero_comprobante));
        }
    }
}
