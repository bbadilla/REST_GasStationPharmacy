using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeApi.Models
{
    public class Receta
    {
        public int numero { get; set; }
        public string doctor { get; set; }
        public string medicamentos { get; set; }
        public string imagen { get; set; }
    }
}