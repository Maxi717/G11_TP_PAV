using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G11_TP_PAV.Clases;
using System.Windows.Forms;

namespace G11_TP_PAV.Negocio
{
    class NE_Clientes
    {
        public string Pp_nombre { get; set; }
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable RecuperarTodos()
        {
            string sql = "SELECT * FROM clientes c join tipo_documento t on c.id_tipo_documento=t.Id_tipo_documento";
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarTipoDocumento(string tipo_dni)
        {
            string sql = "SELECT * FROM clientes c join tipo_documento t on c.id_tipo_documento=t.Id_tipo_documento WHERE c.id_tipo_documento = " + tipo_dni;
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarNombre(string nombre)
        {
            string sql = "SELECT * FROM clientes c join tipo_documento t on c.id_tipo_documento=t.Id_tipo_documento WHERE c.nombre LIKE '%" + nombre.Trim() + "%'";
            return _BD.Consulta(sql);
        } 

        public DataTable RecuperarDni(string dni)
        {
            string sql = "SELECT * FROM clientes c join tipo_documento t on c.id_tipo_documento=t.Id_tipo_documento WHERE c.numero_documento = " + dni;
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarMixto(string nombre, string dni)
        {
            string sql = "SELECT * FROM clientes c join tipo_documento t on c.id_tipo_documento = t.Id_tipo_documento WHERE c.numero_documento = " + dni + " and  c.nombre LIKE '%" + nombre.Trim() + "%'";
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarTresValores(string nombre, string dni, string tipoDni)
        {
            string sql = "SELECT * FROM clientes c join tipo_documento t on c.id_tipo_documento = t.Id_tipo_documento WHERE c.numero_documento = "+ dni +" and c.id_tipo_documento = "+ tipoDni +" and  c.nombre LIKE '%"+ nombre.Trim() +"%'";
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarDniMasTipo(string dni, string tipoDni)
        {
            string sql = "SELECT * FROM clientes c join tipo_documento t on c.id_tipo_documento = t.Id_tipo_documento WHERE c.numero_documento = " + dni + " and c.id_tipo_documento = " + tipoDni;
            return _BD.Consulta(sql);
        }

        public void InsertarClientes(Control.ControlCollection controles)
        {
            TratEsp tratamiento = new TratEsp();
            _BD.Insertar(tratamiento.ConstructorInsert("clientes", controles));
        }

        public void ModificarClientes(Control.ControlCollection controles, string num_dni)
        {
            TratEsp tratamiento = new TratEsp();
            _BD.Insertar(tratamiento.ConstructorModificar("clientes", controles, "numero_documento = ", num_dni));
        }

        public void BorradoClientes(string num_dni)
        {
            TratEsp tratamientos = new TratEsp();
            _BD.Insertar(tratamientos.ConstructorBorrar("clientes", "numero_documento", num_dni));
        }
    }
}
