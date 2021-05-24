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
    class NE_departamentos
    {
        public string Pp_id_departamento { get; set; }
        public string Pp_piso { get; set; }
        public string Pp_denominacion { get; set; }
        public string Pp_superficie { get; set; }
        public string Pp_porcentaje { get; set; }
        public string Pp_numero_documento { get; set; }
        public string Pp_id { get; set; }
        public string Pp_id_barrio { get; set; }

        BE_Edificios _BD = new BE_Edificios();
        DataTable tabla = new DataTable();


        public DataTable RecuperarDepartamentos()
        {
            string sql = "SELECT [Id_Departamento],[Piso] ,[Denominacion] ,[Superficie] ,[Porcentaje] ,duenios.nombre as Duenio ,edificios.domicilio as Domicilio ,barrios.nombre as Barrio FROM[BD3K6G11_2021].[dbo].[departamento] depto join dbo.barrios barrios on depto.id_barrio = barrios.id_barrio join dbo.duenios duenios on depto.id_dueño = duenios.numero_documento join dbo.edificios edificios on depto.id_edificio = edificios.id; ";
            return _BD.Ejecutar_Select(sql);

        }

        public DataTable RecuperarBarrioEdificio(string fk_barrio, string fk_edificio)
        {
            string sql = "SELECT [Id_Departamento],[Piso] ,[Denominacion] ,[Superficie] ,[Porcentaje] ,duenios.nombre as Duenio ,edificios.domicilio as Domicilio ,barrios.nombre as Barrio FROM[BD3K6G11_2021].[dbo].[departamento] depto join dbo.barrios barrios on depto.id_barrio = barrios.id_barrio join dbo.duenios duenios on depto.id_dueño = duenios.numero_documento join dbo.edificios edificios on depto.id_edificio = edificios.id WHERE edificios.ID ="+ fk_edificio + " and barrios.id_barrio = "+ fk_barrio;
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable RecuperarID(string id)
        {
            string sql = "SELECT [Id_Departamento],[Piso] ,[Denominacion] ,[Superficie] ,[Porcentaje] ,duenios.numero_documento as Duenio ,edificios.id as Domicilio ,barrios.id_barrio as Barrio FROM[BD3K6G11_2021].[dbo].[departamento] depto join dbo.barrios barrios on depto.id_barrio = barrios.id_barrio join dbo.duenios duenios on depto.id_dueño = duenios.numero_documento join dbo.edificios edificios on depto.id_edificio = edificios.id WHERE depto.id_departamento = " + id;
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = "INSERT INTO departamento (piso,denominacion,superficie,porcentaje,id_dueño,id_edificio,id_barrio) VALUES('" + Pp_piso + "' , '" + Pp_denominacion+ "' , '" + Pp_superficie+ "' , '" + Pp_porcentaje+ "', '" + Pp_numero_documento + "', '" + Pp_id + "', '" + Pp_id_barrio + "' )";

            _BD.Insertar(sqlInsertar);
        }

        public void Modificar()
        {
            string sql = "UPDATE departamento SET piso ='" + Pp_piso + "', denominacion ='" + Pp_denominacion + "', superficie = '" + Pp_superficie + "', porcentaje ='" + Pp_porcentaje + "' , id_dueño ='" + Pp_numero_documento + "', id_edificio ='" + Pp_id + "' , id_barrio ='" + Pp_id_barrio + "'WHERE id_departamento ='" + Pp_id_departamento + "'";
            _BD.Ejecutar_Select(sql);
        }
        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM departamento where id_departamento ='" + Pp_id_departamento + "'";
            _BD.Ejecutar_Select(sqlBorrar);
        }

    }




}
