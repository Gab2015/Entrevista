using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Interview.WebAPI.Models;
using Oracle.DataAccess.Client;

namespace Interview.WebAPI.Controllers
{
    public class CuentaController : ApiController
    {
        [HttpGet]
        public List<DTOCuenta> Get()
        {
            OracleCommand cmd = new OracleCommand();
            OracleParameter pCuentaInfo = new OracleParameter();
            ConexionODP ObjConexion = new ConexionODP();
            List<DTOCuenta> DTOCuentas = new List<DTOCuenta>();
            
            cmd.Connection = ObjConexion.IniConexion();
            pCuentaInfo.OracleDbType = OracleDbType.RefCursor;
            pCuentaInfo.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(pCuentaInfo);
            cmd.CommandText = "SYS_INTERVIEW.GETINFOCUENTA";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                DTOCuenta objCuenta = new DTOCuenta();
                objCuenta.ID = Convert.ToInt32(reader.GetValue(0));
                objCuenta.Cuenta = Convert.ToString(reader.GetValue(1));
                objCuenta.Descripcion = Convert.ToString(reader.GetValue(2));
                DTOCuentas.Add(objCuenta);
            }
            return DTOCuentas;
        }
    }
}