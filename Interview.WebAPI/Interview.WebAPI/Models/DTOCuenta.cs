using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interview.WebAPI.Models
{
    public class DTOCuenta
    {
        public int ID { get; set; }
        public string Cuenta { get; set; }
        public string Descripcion { get; set;}
    }
}