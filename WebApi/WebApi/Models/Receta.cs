using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeApi.Models
{
    public class Receta
    { 

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
        /////
        ///
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
        /////
        ///

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
        /////
        ///
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