using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeApi.Models
{
    [Serializable]

    public class Sucursal
    {


        /// <summary>
        /// Atributo nombre con su get y set
        /// </summary>
        private string nombre;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }

        }

        /// <summary>
        /// Atributo descripcion con su get y set
        /// </summary>
        private string descripcion;

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }

            set
            {
                this.descripcion = value;
            }

        }

        /// <summary>
        /// Atributo direccion con su get y set
        /// </summary>
        private string direccion;

        public string Direccion
        {
            get
            {
                return this.direccion;
            }

            set
            {
                this.direccion = value;
            }

        }






    }
}