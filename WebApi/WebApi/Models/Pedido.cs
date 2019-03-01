using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeApi.Models
{
    public class Pedido
    {
        public string recojo { get; set; }
        public string cliente { get; set; }
        public string telefono { get; set; }
        public string listaMedicamentos { get; set; }
        public string hora { get; set; }
        public string imagen { get; set; }
        
    }
}