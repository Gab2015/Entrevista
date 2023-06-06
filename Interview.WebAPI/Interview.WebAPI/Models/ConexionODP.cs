using Oracle.DataAccess.Client;
using System;
using System.Configuration;
using System.Web.Configuration;


namespace Interview.WebAPI.Models
{
    /// <summary>
    /// Clase conexion a Oracle 21C
    /// <see cref="Interview.WebAPI.Models.ConexionODP/>
    /// <author>Gabriel López</author>
    /// <datecreated>05/06/2023</datecreated>
    /// </summary>
    public class ConexionODP
    {
        #region VARIABLES PRIVADAS
        private static ConexionODP vConexion = null;
        #endregion VARIABLES PRIVADAS
        #region METODOS PUBLICOS
        /// <summary>
        /// Crea la conexion a bd Oracle
        /// <author>Gabriel López</author>
        /// <datecreated>05/06/2023</datecreated>
        /// </summary>
        /// <returns>Cadena de conexion</returns>
        public OracleConnection IniConexion()
        {
            OracleConnection StrConexion = new OracleConnection();
            try
            {
                StrConexion.ConnectionString = WebConfigurationManager.AppSettings["SqlConnectionString"];
                StrConexion.Open();
            }
            catch (Exception ex)
            {
                StrConexion = null;
                throw ex;
            }
            return StrConexion;
        }
        #endregion METODOS PUBLICOS
    }
}