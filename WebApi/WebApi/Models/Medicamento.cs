using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeApi.Models
{
    public class Medicamento
    {
        public string nombre { get; set; }
        public string farmacia { get; set; }
        public string prescripcion { get; set; }
        public int cantidad { get; set; }
        public int precio { get; set; }

    }
}