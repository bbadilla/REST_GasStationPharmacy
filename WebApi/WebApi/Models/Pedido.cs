using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeApi.Models
{
    public class Pedido
    {
        

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
        /// 
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

        /////
        ///
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

        /////
        ///
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

        /////
        ///
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
        /// 
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



    }
}