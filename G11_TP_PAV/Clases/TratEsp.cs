using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G11_TP_PAV.Clases;

namespace G11_TP_PAV.Clases
{
    class TratEsp
    {
        public enum Resultado { correcto, error}

        public Resultado Validar(Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBoxHeredada")
                {
                    if (((TextBoxHeredada)item).Text == "")
                    {
                        MessageBox.Show(((TextBoxHeredada)item).Pp_MensajeError);
                        ((TextBoxHeredada)item).Focus();
                        return Resultado.error;
                    }
                }
                if (item.GetType().Name == "ComboBoxHeredada")
                {
                    if(((ComboBoxHeredadaG)item).SelectedIndex == -1)
                    {
                        MessageBox.Show(((ComboBoxHeredadaG)item).Pp_MensajeError);
                        ((ComboBoxHeredadaG)item).Focus();
                        return Resultado.error;
                    }
                }
                if (item.GetType().Name == "NumericHeredada")
                {
                    if(((NumericHeredada)item).Value == 0)
                    {
                        MessageBox.Show(((NumericHeredada)item).Pp_MensajeError);
                        ((NumericHeredada)item).Focus();
                        return Resultado.error;
                    }
                }
            }
            return Resultado.correcto;
        }

        public string ConstructorInsert(string nombreTabla, Control.ControlCollection controles)
        {
            string sql = "INSERT INTO "+nombreTabla+" (";
            string columna = "";
            string tipoDatoColumna = "";
            string valorColumna = "";
            string paqueteColumnas = "";
            string paqueteValores = "";
            DataTable estructura = BuscarEstructuraTabla(nombreTabla);

            for (int i = 0; i < estructura.Columns.Count; i++)
            {
                columna = estructura.Columns[i].Caption;
                tipoDatoColumna = estructura.Columns[i].DataType.Name;
                valorColumna = BuscarColumnaEnControles(columna, controles);
                if (valorColumna != "")
                {
                    valorColumna = FormatearDato(valorColumna, tipoDatoColumna);
                    if (paqueteColumnas == "")
                    {
                        paqueteColumnas = columna;
                        paqueteValores = valorColumna;
                    }
                    else
                    {
                        paqueteColumnas += ", " + columna;
                        paqueteValores += ", " + valorColumna;
                    }
                }
            }
            sql += paqueteColumnas + ") VALUES (" + paqueteValores + ")";
            MessageBox.Show("Los datos se cargaron correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return sql;
        }

        private DataTable BuscarEstructuraTabla(string nombreTabla)
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            return _BD.Consulta("SELECT TOP 1 * FROM " + nombreTabla);
        }

        private string BuscarColumnaEnControles(string campo, Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBoxHeredada")
                {
                    if (((TextBoxHeredada)item).Pp_campo == campo)
                    {
                        return ((TextBoxHeredada)item).Text;
                    }
                }
                if (item.GetType().Name == "ComboBoxHeredada")
                {
                    if (((ComboBoxHeredadaG)item).Pp_campo == campo)
                    {
                        return ((ComboBoxHeredadaG)item).SelectedValue.ToString();
                    }
                }
                if (item.GetType().Name == "NumericHeredada")
                {
                    if (((NumericHeredada)item).Pp_campo == campo)
                    {
                        return ((NumericUpDown)item).Value.ToString();
                    }
                }
                if (item.GetType().Name == "DateTimeHeredada")
                {
                    if (((DateTimeHeredada)item).Pp_campo == campo)
                    {
                        return ((DateTimeHeredada)item).Value.ToShortDateString();
                    }
                }
            }
            return "";
        }
        
        private string FormatearDato(string valorColumna, string tipoDatoColumna)
        {
            switch (tipoDatoColumna)
            {
                case "String":
                    return "'" + valorColumna + "'";
                default:
                    return valorColumna;
            }
        }

        public string ConstructorModificar(string nombreTabla, Control.ControlCollection controles, string sqlExtra, string valorExtra)
        {
            string sql = "UPDATE " + nombreTabla + " SET ";
            string columna = "";
            string tipoDatoColumna = "";
            string valorColumna = "";
            string paqueteColumnas = "";
            DataTable estructura = BuscarEstructuraTabla(nombreTabla);

            for (int i = 0; i < estructura.Columns.Count; i++)
            {
                columna = estructura.Columns[i].Caption;
                tipoDatoColumna = estructura.Columns[i].DataType.Name;
                valorColumna = BuscarColumnaEnControles(columna, controles);
                if (valorColumna != "")
                {
                    valorColumna = FormatearDato(valorColumna, tipoDatoColumna);
                    if (paqueteColumnas == "")
                    {
                        paqueteColumnas = columna+" = "+valorColumna;
                    }
                    else
                    {
                        paqueteColumnas += ", "+columna+" = "+valorColumna;
                    }
                }
            }
            sql += paqueteColumnas + " WHERE "+sqlExtra+valorExtra;
            MessageBox.Show("Los datos se modificaron correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return sql;
        }

        public string ConstructorBorrar(string nombreTabla, string idBorrado, string valorBorrado)
        {
            string sqlDelete = "DELETE FROM "+nombreTabla+" WHERE "+idBorrado+"="+valorBorrado;
            MessageBox.Show("Los datos fueron borrados correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return sqlDelete;
        }
    }
}
