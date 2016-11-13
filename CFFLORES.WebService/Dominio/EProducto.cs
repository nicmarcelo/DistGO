using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CFFLORES.WebService.Dominio
{
    [DataContract]
    public class EProducto
    {
        [DataMember]
        public string codigobarra { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public Int32 Stock { get; set; }
        [DataMember]
        public Double Precio { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public string Tipo { get; set; }
    }
}