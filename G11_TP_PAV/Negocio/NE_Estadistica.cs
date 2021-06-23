using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using G11_TP_PAV.Clases;


namespace G11_TP_PAV.Negocio
{
    class NE_Estadistica
    {


        BE_Acceso_Datos _BD = new BE_Acceso_Datos();


        public DataTable recuperarGasto_x_Edificio()
        {

            DataTable tablaGastos_x_edificio = recuperarDatos();

            DataTable tablaEdificios = recuperarEdificios();

            DataTable tablaFinal = armarTabla(tablaEdificios, tablaGastos_x_edificio);

            


            return tablaFinal;

        }


        private DataTable recuperarDatos()
        {
            string SqlSelect = @"SELECT g.id_edificio, g.importe
                                   FROM gastos g ";

            return _BD.Consulta(SqlSelect);

        }

        private DataTable recuperarEdificios()
        {
            string SqlSelect = @"SELECT id, domicilio
                                FROM edificios ";

            return _BD.Consulta(SqlSelect);

        }

        private DataTable armarTabla(DataTable tablaEdificio, DataTable tablaConsulta)
        {
            DataTable tablaFinal = new DataTable();

            DataColumn columna1 = new DataColumn();

            columna1.DataType = System.Type.GetType("System.String");
            columna1.ColumnName = "denominacion";
            tablaFinal.Columns.Add(columna1);

            DataColumn columna2 = new DataColumn();

            columna2.DataType = System.Type.GetType("System.Double");
            columna2.ColumnName = "valor";
            tablaFinal.Columns.Add(columna2);
            
             
            DataRow fila;

            for (int i = 0; i < tablaEdificio.Rows.Count; i++)
            {
                fila = tablaFinal.NewRow();
                fila["denominacion"] = tablaEdificio.Rows[i][1];
                fila["valor"] = valorEdificio(tablaEdificio.Rows[i][0].ToString(), tablaConsulta);
                tablaFinal.Rows.Add(fila);

            }


            return tablaFinal;

        }

        private Double valorEdificio(string id, DataTable tabla)
        {
            Double valorFinal = 0;

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i][0].ToString() == id)
                {
                    valorFinal += Double.Parse(tabla.Rows[i][1].ToString());
                }

            }

            return valorFinal;

        }

        //_--------------------------------------------------------------------------


        public DataTable recuperarFactura_X_Escribano()
        {

            DataTable tablaFactura_x_Escribano = recuperarDatos2();

            DataTable tabla_Escribano = recuperarEscribanos();

            DataTable tablaFinal = armarTabla2(tabla_Escribano, tablaFactura_x_Escribano);




            return tablaFinal;

        }




        private DataTable recuperarDatos2()
        {
            string SqlSelect = @"SELECT matricula_escribano AS matricula
                                 FROM facturas_comisiones3";

            return _BD.Consulta(SqlSelect);

        }

        private DataTable recuperarEscribanos()
        {
            string SqlSelect = @"SELECT Matricula, CAST(Matricula AS varchar(10) ) + ' | ' + Nombre +' '+Apellido AS Nombre 
                                FROM escribanos   ";

            return _BD.Consulta(SqlSelect);

        }

        private DataTable armarTabla2(DataTable tablaEscribano, DataTable tablaConsulta)
        {
            DataTable tablaFinal = new DataTable();

            DataColumn columna1 = new DataColumn();

            columna1.DataType = System.Type.GetType("System.String");
            columna1.ColumnName = "denominacion";
            tablaFinal.Columns.Add(columna1);

            DataColumn columna2 = new DataColumn();

            columna2.DataType = System.Type.GetType("System.Double");
            columna2.ColumnName = "valor";
            tablaFinal.Columns.Add(columna2);


            DataRow fila;

            for (int i = 0; i < tablaEscribano.Rows.Count; i++)
            {
                fila = tablaFinal.NewRow();
                fila["denominacion"] = tablaEscribano.Rows[i][1];
                fila["valor"] = valorEscribano(tablaEscribano.Rows[i][0].ToString(), tablaConsulta);
                tablaFinal.Rows.Add(fila);

            }


            return tablaFinal;

        }

        private int valorEscribano(string id, DataTable tabla)
        {
            int valorFinal = 0;

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i][0].ToString() == id)
                {
                    valorFinal += 1;
                }

            }

            return valorFinal;

        }


    }
}
