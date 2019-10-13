using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Conexion
{
    ///<summary>
    ///Clase la cual permite la conexión con la base de datos, y provee los servicios básicos para cualquier catálogo.
    ///</summary>
    public class ConexionBD
    {
        
        public string ruta = "Data Source=DESKTOP-0LUP8FU;Initial Catalog=Encuesta;Integrated Security=True;";
        //public string ruta = "Data Source=SERGIO-PC\\SQLEXPRESS;Initial Catalog=Encuesta;Integrated Security=True;";
        private string NombreTabla;
        private string[] NombreCampos;
        private SqlConnection cd;
        private SqlConnection cn;

        ///<summary>
        ///Constructor de la clase ConexionBD, recibe como parámetro el nombre de la tabla en el 
        ///catálogo y un array de tipo string con los nombres de los campos de la tabla
        ///</summary>
        public ConexionBD(string NombreTabla, string[] NombreCampos)
        {
            this.NombreTabla = NombreTabla;
            this.NombreCampos = NombreCampos;
        }

        ///<summary>
        ///Abre el flujo con el catálogo en la base de datos
        ///</summary>
        public void Conectar()
        {
            cn = new SqlConnection();
            cn.ConnectionString = ruta;
        }

        ///<summary>
        ///Trae todos los registros almacenados en una tabla
        ///</summary>
        public List<Object> SelectAll(Object ObjectoP)
        {
            Conectar();
            List<String[]> arreglo = new List<String[]>();
            string SqlString = "Select * from " + NombreTabla;
            List<Object> listadoObjectos = new List<Object>();

            using (SqlCommand cmd = new SqlCommand(SqlString, cn))
            {
                cmd.CommandType = CommandType.Text;
                cn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int numeroCampos = NombreCampos.Length;
                    string Campo = "";
                    string Valor = "";
                    Object Objecto = ((ICloneable)ObjectoP).Clone();
                    for (int i = 0; i < numeroCampos; i++)
                    {
                        Campo = NombreCampos[i];
                        Valor = reader[Campo].ToString();
                        Objecto.GetType().GetProperty(Campo).SetValue(Objecto, Valor);
                    }
                    listadoObjectos.Add(Objecto);
                }
                cn.Close();
            }
            return listadoObjectos;
        }

        ///<summary>
        ///Trae un solo registro de la tabla dada su PrimaryKey y una instancia de la clase modelo
        ///</summary>
        public Object Select(string IntCode, Object Object)
        {

            Conectar();
            string SqlString = "Select * from " + NombreTabla + " where " + NombreCampos[0] + " =@IntCode;";
            using (SqlCommand cmd = new SqlCommand(SqlString, cn))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IntCode", IntCode);
                cn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int numeroCampos = NombreCampos.Length;
                    string Campo = "";
                    string Valor = "";
                    for (int i = 0; i < numeroCampos; i++)
                    {
                        Campo = NombreCampos[i];
                        Valor = reader[Campo].ToString();
                        Object.GetType().GetProperty(Campo).SetValue(Object, Valor);
                    }
                }
                cn.Close();

            }
            return Object;
        }

        ///<summary>
        ///Permite insertar los valores dentro de la tabla en el catálogo de la base de datos
        ///</summary>
        public void Insert(string[] valores)
        {

            Conectar();
            string Parametros = "(";
            string ParametrosValor = "(";
            string ParametroActual = "";
            int i;
            for (i = 0; i < NombreCampos.Length - 1; i++)
            {

                ParametroActual = NombreCampos[i];
                Parametros += ParametroActual + ",";
                ParametrosValor += "@" + ParametroActual + ",";
            }
            ParametroActual = NombreCampos[i];
            Parametros += ParametroActual + ")";
            ParametrosValor += "@" + ParametroActual + ")";

            string SqlString = "Insert Into " + NombreTabla + " " + Parametros + " Values" + ParametrosValor;

            using (SqlCommand cmd = new SqlCommand(SqlString, cn))
            {
                cmd.CommandType = CommandType.Text;
                for (i = 0; i < NombreCampos.Length; i++)
                {
                    cmd.Parameters.AddWithValue("@" + NombreCampos[i], valores[i]);
                }
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }


    }
}
