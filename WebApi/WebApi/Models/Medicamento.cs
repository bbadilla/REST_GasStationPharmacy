using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeApi.Models
{
    public class Medicamento
    {
      
        
        
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
        /// /
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
        /// //
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
        /// //
        /// </summary>


        //////
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
        /// ///
        /// </summary>
      

        /// <summary>
        /// /
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

        /// <summary>
        /// //
        /// </summary>
        

    }
}