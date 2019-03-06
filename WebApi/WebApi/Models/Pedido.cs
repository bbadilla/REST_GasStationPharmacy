using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeApi.Models
{
    public class Pedido
    {

        /// <summary>
        /// Atributo recojo con su get y set
        /// </summary>
        private string recojo;

        public string Recojo
        {
            get
            {
                return this.recojo;
            }

            set
            {
                this.recojo = value;
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

        /// <summary>
        /// Atributo telefono con su get y set
        /// </summary>
        private string telefono;


        public string Telefono
        {
            get
            {
                return this.telefono;
            }

            set
            {
                this.telefono = value;
            }

        }

        /// <summary>
        /// Atributo listaMedicamentos con su get y set
        /// </summary>
        private string listaMedicamentos;


        public string ListaMedicamentos
        {
            get
            {
                return this.listaMedicamentos;
            }

            set
            {
                this.listaMedicamentos = value;
            }

        }

        /// <summary>
        /// Atributo hora con su get y set
        /// </summary>
        private string hora;


        public string Hora
        {
            get
            {
                return this.hora;
            }

            set
            {
                this.hora = value;
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
        /// Atributo estado con su get y set
        /// </summary>
	    private string estado;

	    public string Estado
        {
            get
            {
                return this.estado;;
            }

            set
            {
                this.estado = value;
            }

        }



    }
}