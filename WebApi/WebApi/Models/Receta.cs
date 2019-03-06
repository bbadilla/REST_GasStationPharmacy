using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeApi.Models
{
    public class Receta
    {
        /// <summary>
        /// Atributo doctor con su get y set
        /// </summary>
        private string doctor;

        public string Doctor
        {
            get
            {
                return this.doctor;
            }

            set
            {
                this.doctor = value;
            }
        }

        /// <summary>
        /// Atributo numero con su get y set
        /// </summary>
        private int numero;

        public int Numero
        {
            get
            {
                return this.numero;
            }

            set
            {
                this.numero = value;
            }
        }

        /// <summary>
        /// Atributo medicamentos con su get y set
        /// </summary>
        private string medicamentos;

        public string Medicamentos
        {
            get
            {
                return this.medicamentos;
            }

            set
            {
                this.medicamentos = value;
            }
        }

        /// <summary>
        /// Atributo imagen con su get y set
        /// </summary>
        private string imagen;

        public string Imagen
        {
            get
            {
                return this.imagen;
            }

            set
            {
                this.imagen = value;
            }
        }

        /// <summary>
        /// Atributo cliente con su get y set
        /// </summary>
        private string cliente;

        public string Cliente
        {
            get
            {
                return this.cliente;
            }

            set
            {
                this.cliente = value;
            }
        }

    }
}