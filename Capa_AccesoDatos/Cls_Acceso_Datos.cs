using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Capa_AccesoDatos
{

    public class Cls_Parametros
    {
        //DEFINIR PARAMETROS ATRIBUTOS
        public string Nombre { get; set; }
        public object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamaño { get; set; }
        public ParameterDirection Direccion { get; set; }

        //CONSTRUCTOR
        public Cls_Parametros(String Objnombre, object ObjValor)
        {
            Nombre = Objnombre;
            Valor = ObjValor;
            Direccion = ParameterDirection.Input;
        }

        //constructor parametros salida
        public Cls_Parametros(String Objnombre, SqlDbType ObjTipoDato, Int32 ObjTamaño)
        {
            Nombre = Objnombre;
            TipoDato = ObjTipoDato;
            Tamaño = ObjTamaño;
            Direccion = ParameterDirection.Output;
        }
    }
    public class Cls_Acceso_Datos
    {
        SqlConnection conexion; //definir variable para la conexion
        SqlCommand cmd; //definir variable para el comando
        SqlDataReader LectorDatos = null; //definir variable para el datareader
        SqlDataAdapter da; //definir variable para el dataadapter
        DataTable dt; //definir variable para el datatable

        public string AbrirBd()
        {
            string resultado = "";
            try  //permite captura de un error
            {
                //creamos un objeto de tipo conexion
                //conexion = new SqlConnection("Server=localhost;Database=DBFACTURAS;Trusted_Connection=True;");//cadena de conexion
                conexion = new SqlConnection("Server=localhost;Database=DBFACTURAS;User Id=sa;Password=12345;");

                conexion.Open(); //abrir la conexion invocamos metodo
            }
            catch (Exception ex) //captura el error, si lo hay lanza
            {
                resultado = "ERROR: No se pudo conectar a la base de datos. " + ex.Message;
            }
            return resultado;
        }

        public string CerrarBd()
        {
            string resultado = "";
            try //captura error
            {
                conexion.Close(); //cerrar la conexion
            }
            catch (Exception ex)
            {
                resultado = "ERROR: No se pudo cerrar la base de datos. " + ex.Message;
            }
            return resultado;
        }
        public string Ejecutar_Procedimiento(String procedimiento, List<Cls_Parametros> lst)
        {
            String salida = "";
            try
            {
                int retornado;

                AbrirBd();
                //creamos el onjeto al comando los valores de los parametros a ejecutar y la conexión
                SqlCommand comando = new SqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure; //indica que es un procedimiento almacenado

                //Asignar los parametros al procedimiento almacenado
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++) //recorre la lista de parametros
                    {
                        if (lst[i].Direccion == ParameterDirection.Input) //si es de entrada
                        {
                            comando.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor); //agrega el parametro al comando
                        }
                        if (lst[i].Direccion == ParameterDirection.Output) //si es de salida
                        {
                            comando.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output; //agrega el parametro al comando
                        }
                    }
                }
                retornado = comando.ExecuteNonQuery(); //ejecuta el comando
                CerrarBd();

                if (retornado > 0)
                {
                    salida = "Los datos fueron actualizados";
                }
                else
                {
                    salida = "Los datos no fueron actualizados";
                }


            }
            catch (Exception ex)
            {
                salida = "ERROR: No se pudo ejecutar el procedimiento. " + ex.Message;
            }
            return salida;


        }

        public string EjecutarComando(String sentencia)
        {
            String salida = "";
            try
            {
                int retornado;
                AbrirBd();
                //creamos el onjeto al comando los valores de los parametros a ejecutar y la conexión
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery(); //ejecuta el comando
                CerrarBd();
                if (retornado > 0)
                {
                    salida = "Los datos fueron actualizados";
                }
                else
                {
                    salida = "Los datos no fueron actualizados";
                }
            }
            catch (Exception ex)
            {
                salida = "ERROR: No se pudo ejecutar el comando. " + ex.Message;
            }
            return salida;

        }

        public DataTable EjecutarConsulta(String cmd)
        {
            try
            {
                AbrirBd();
                //creamos el objeto al comando los valores de los parametros a ejecutar y la conexión
                da = new SqlDataAdapter(cmd, conexion); //crea el dataadapter
                dt = new DataTable(); //crea el datatable
                da.Fill(dt); //llena el datatable
                CerrarBd();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public DataTable EjecutarConsultaConParametros(string sentencia, List<Cls_Parametros> parametros)
        {
            try
            {
                AbrirBd();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                comando.CommandType = CommandType.Text;

                // Agregar los parámetros al comando
                if (parametros != null)
                {
                    foreach (var p in parametros)
                    {
                        comando.Parameters.AddWithValue(p.Nombre, p.Valor);
                    }
                }

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                CerrarBd();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la consulta con parámetros: " + ex.Message);
            }
        }

    }

}
