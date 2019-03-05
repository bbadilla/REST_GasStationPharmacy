using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeApi.Models
{
    [Serializable]

    public class Cliente
    {
       
     
        ///  CEDULAAA
        private int cedula;

        public int Cedula {
            get{
                return this.cedula;
            }

            set {
                this.cedula = value;
            }
            
        }

      /// <summary>
      /// /
      /// </summary>
        private string apellidos;

        public string Apellidos
        {
            get{
                return this.apellidos;
            }

            set {
                this.apellidos = value;
            }
        }

        /// <summary>
        /// //
        /// </summary>
        private string residencia;

        public string Residencia
        {
            get{
                return this.residencia;
            }

            set {
                this.residencia = value;
            }
        }
        /// <summary>
        /// //
        /// </summary>

      
        //////
        private string fechaNacimiento;

        public string FechaNacimiento
        {
            get{
                return this.fechaNacimiento;
            }

            set {
                this.fechaNacimiento = value;
            }
        }

        /// <summary>
        /// ///
        /// </summary>
        private int telefono;

        public int Telefono
        {
            get{
                return this.telefono;
            }

            set {
                this.telefono = value;
            }
        }

        /// <summary>
        /// /
        /// </summary>
        private string padecimientos;

        public string Padecimientos
        {
            get{
                return this.padecimientos;
            }

            set {
                this.padecimientos = value;
            }
        }

        /// <summary>
        /// //
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

        



    }
}