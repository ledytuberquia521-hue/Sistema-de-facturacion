using System;
using System.Collections.Generic;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Validar_Usuario
    {
        // Atributos de la clase
        public string C_StrUsuario { get; set; }
        public string C_StrClave { get; set; }
        public int C_IdEmpleado { get; set; }

        public void ValidarUsuario()
        {
            try
            {
                // Consulta SQL parametrizada
                string sentencia = "SELECT IdEmpleado FROM TBLSEGURIDAD WHERE StrUsuario = @Usuario AND StrClave = @Clave";

                // Crear lista de parámetros
                List<Cls_Parametros> parametros = new List<Cls_Parametros>()
                {
                    new Cls_Parametros("@Usuario", C_StrUsuario),
                    new Cls_Parametros("@Clave", C_StrClave)
                };

                // Ejecutar la consulta
                Cls_Acceso_Datos Acceso = new Cls_Acceso_Datos();
                DataTable dt = Acceso.EjecutarConsultaConParametros(sentencia, parametros);

                // Validar resultados
                if (dt.Rows.Count > 0)
                {
                    C_IdEmpleado = Convert.ToInt32(dt.Rows[0]["IdEmpleado"]);
                }
                else
                {
                    C_IdEmpleado = 0; // No encontrado
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar el usuario: " + ex.Message);
            }
        }
    }
}
