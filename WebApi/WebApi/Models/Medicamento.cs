using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeApi.Models
{
    public class Medicamento
    {


        /// <summary>
        /// Atributo cantidad con su get y set
        /// </summary>
        private int cantidad;

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }

            set
            {
                this.cantidad = value;
            }

        }

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
        /// Atributo farmacia con su get y set
        /// </summary>
        private string farmacia;

        public string Farmacia
        {
            get
            {
                return this.farmacia;
            }

            set
            {
                this.farmacia = value;
            }
        }

        /// <summary>
        /// Atributo precio con su get y set
        /// </summary>
        private string precio;

        public string Precio
    {
            get
            {
                return this.precio;
            }

            set
            {
                this.precio = value;
            }
        }

        /// <summary>
        /// Atributo prescripcion con su get y set
        /// </summary>
        private string prescripcion;

        public string Prescripcion
        {
            get
            {
                return this.prescripcion;
            }

            set
            {
                this.prescripcion = value;
            }
        }

    }
}