using System;
using System.Collections.Generic;
using Capa_AccesoDatos;
using System.Data;


namespace Capa_LogicaDeNegocios
{
    public class Cls_Seguridad
    {
        //definimos los atributos de la clase
        public int C_IdEmpleado { get; set; }
        public string C_StrUsuario { get; set; }
        public string C_StrClave { get; set; }
        //public DateTime C_DtmFechaModifica { get; set; }
        public DateTime C_DtmFechaModifica { get; set; } = DateTime.Now;




        public string C_StrUsuarioModifico { get; set; }
       // public object AccesoDatos { get; private set; }

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos(); //objeto de la clase acceso a datos



        //consultamos los empleados para mostrar en combo
        public DataTable ConsultarEmpleado()
        {
            string sentencia;
            try
            {
                sentencia = "select IdEmpleado, strNombre from TBLEMPLEADO";
                    DataTable dt = new DataTable ();
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable Consulta_seguridadEmpleado(int IdEmpleado)
        {
            try
            {
                string sentencia = $"SELECT StrUsuario, StrClave FROM TBLSEGURIDAD WHERE IdEmpleado = {IdEmpleado}";
                return AccesoDatos.EjecutarConsulta(sentencia);
            }
            catch (Exception ex)
            {
                // Lanzas la excepción al formulario
                throw new Exception("Error al consultar seguridad del empleado: " + ex.Message);
            }
        }


        //ELIMINAMOS UN REGISTRO DE LA BD
        public string EliminarSeguridadEmpleado()
        {
            string mensaje = "";
            try
            {
                //creamos una estructura de tipo lista que tendra los parametros que necesitan los procedimientos almacenados
                List<Cls_Parametros> lst = new List<Cls_Parametros>();

                //adicionamos el parametro que permite indicar el id del empleado que borramos
                //contiene el nombre y el valor del parametro
                lst.Add(new Cls_Parametros("@IdEmpleado", C_IdEmpleado));

                //ejecutamos el procedimiento y pasamos lst con los parametros y valores
                mensaje = AccesoDatos.Ejecutar_Procedimiento("Eliminar_Seguridad", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Falló borrando el empleado. " + ex.Message;
         
            }
            return mensaje;
        }

        public string ActualizarSeguridadEmpleado()
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>(); //creamos el objeto listo lst que tendra los nombres de los parametros y valores 
                                                                       //adicionamos los parametros que necesita el procedimiento almacenado

                lst.Add(new Cls_Parametros("@IdEmpleado", C_IdEmpleado));
                lst.Add(new Cls_Parametros("@StrUsuario", C_StrUsuario));
                lst.Add(new Cls_Parametros("@StrClave", C_StrClave));
                lst.Add(new Cls_Parametros("@DtmFechaModifica", C_DtmFechaModifica));
                lst.Add(new Cls_Parametros("@StrUsuarioModifico", C_StrUsuarioModifico));

                //ejecutamos el procedimiento y pasamos lst con los parametros y valores
                mensaje = AccesoDatos.Ejecutar_Procedimiento("actualizar_Seguridad", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Falló insertando o actualizando el empleado. " + ex.Message;
            }
            return mensaje;
        }
    }
}




