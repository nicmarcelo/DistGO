using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CFFLORES.WebService.Errores
{
    [DataContract]
    public class RepetidoException
    {
        [DataMember]
        public string excodigobarra { get; set; }
        [DataMember]
        public string exNombreProducto { get; set; }
        [DataMember]
        public Int32 exStock { get; set; }
        [DataMember]
        public Double exPrecio { get; set; }
    }
}