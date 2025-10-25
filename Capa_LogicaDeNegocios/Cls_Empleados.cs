using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos; 
using System.Data;
using System.Security.AccessControl;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Empleados
    {
        //definimos atributos de la clase
        public int C_IdEmpleado { get; set; } 
        public string C_StrNombre { get; set; }
        public double C_NumDocumento { get; set; }  
        public string C_StrDireccion { get; set; }
        public string C_StrTelefono { get; set; }
        public string C_StrEmail { get; set; }
        public int C_IdRolEmpleado { get; set; }
        public DateTime C_DtmIngreso { get; set; }
        public DateTime C_DtmRetiro  { get; set; }
        public string C_strDatosAdicionales { get; set; }
        public DateTime C_StrFechaModifica { get; set; }
        public string C_StrUsuarioModifico { get; set; }
        public DateTime C_DtmFechaModifica { get; set; }


        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos(); //objeto de la clase acceso a datos

        //Colsultar datos de empleados
        public DataTable ConsultaEmpleado()
        {
            string sentencia;
            try
                {
                sentencia = "SELECT * FROM TBLEMPLEADO";
                DataTable dt = new DataTable();
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
              return null;
            }
            
        }

        public DataTable Consulta_Empleado(int IdEmpleado)
        {
            string sentencia="";
            try
            {
                sentencia = $"SELECT * FROM TBLEMPLEADO where IdEmpleado={IdEmpleado}";
                DataTable dt = new DataTable();
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public DataTable Filtrar_Empleado(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLEMPLEADO WHERE strNombre LIKE '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable Consulta_RolEmpleado()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT * FROM TBLROLES";
                DataTable dt = new DataTable();
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //Eliminar registro de la base de datos 
       public string EliminaEmpleado()
        {
            string mensaje = "";
            try
            { //creamos una estructura de tipo lista que tendra parametro que necesita el procedimiento almacenado

                List<Cls_Parametros> lst = new List<Cls_Parametros>();
                //adicionamos el parametro que permite indicar el id del empleado que borramos
                //contiene el nombre y el valor del parametro
                lst.Add(new Cls_Parametros("@IdEmpleado", C_IdEmpleado));
                //ejecutamos el procedimiento y pasamos lst con los parametros y valores
                mensaje = AccesoDatos.Ejecutar_Procedimiento("eliminar_Empleado", lst);
            }
            catch (Exception ex)
            {
                return "Error al eliminar el empleado. " + ex.Message;
            }
            return mensaje;
        }

        //metodo que permite insertar como actualizar registros en la base de datos empleados

        public string ActualizarEmpleado()
        {
            string mensaje = "";
            try
            { //creamos una estructura de tipo lista que tendra parametro que necesita el procedimiento almacenado
                List<Cls_Parametros> lst = new List<Cls_Parametros>();
                //adicionamos los parametros que permite indicar los datos del empleado que actualizamos
                //contiene el nombre y el valor del parametro
                lst.Add(new Cls_Parametros("@IdEmpleado", C_IdEmpleado));
                lst.Add(new Cls_Parametros("@StrNombre", C_StrNombre));
                lst.Add(new Cls_Parametros("@NumDocumento", C_NumDocumento));
                lst.Add(new Cls_Parametros("@StrDireccion", C_StrDireccion));
                lst.Add(new Cls_Parametros("@StrTelefono", C_StrTelefono));
                lst.Add(new Cls_Parametros("@StrEmail", C_StrEmail));
                lst.Add(new Cls_Parametros("@IdRolEmpleado", C_IdRolEmpleado));
                lst.Add(new Cls_Parametros("@DtmIngreso", C_DtmIngreso));
                lst.Add(new Cls_Parametros("@DtmRetiro", C_DtmRetiro));
                lst.Add(new Cls_Parametros("@strDatosAdicionales", C_strDatosAdicionales));
                lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_Parametros("@StrUsuarioModifico", C_StrUsuarioModifico));
                //ejecutamos el procedimiento y pasamos lst con los parametros y valores
                mensaje = AccesoDatos.Ejecutar_Procedimiento("actualizar_Empleado", lst);
            }
            catch (Exception ex)
            {
                return "Error al actualizar el empleado. " + ex.Message;
            }
            return mensaje;
        }
    }
}
