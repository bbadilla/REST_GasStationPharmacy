using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeApi.Models
{
    public class Cliente
    {

        public int cedula { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string residencia { get; set; }
        public string fechaNacimiento { get; set; }
        public int telefono { get; set; }
        public string padecimientos { get; set; }


    }
}