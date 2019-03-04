using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeApi.Models
{
    [Serializable]

    public class Cliente
    {
       

        private int cedula;

        public int Cedula {
            get{
                return this.cedula;
            }

            set {
                this.cedula = value;
            }
            
        }

        private string nombreC;

        public string NombreC
        {
            get
            {
                return this.nombreC;
            }

            set
            {
                this.nombreC = value;
            }
        }
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

        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }




    }
}