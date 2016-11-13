using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CFFLORES.WebService.Errores
{
    [DataContract]
    public class ProductoInexistente
    {
        [DataMember]
        public string exError { get; set; }
        [DataMember]
        public Int32 exCodigo { get; set; }
        [DataMember]
        public string exProducto { get; set; }
    }
}