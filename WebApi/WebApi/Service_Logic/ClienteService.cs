using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Xml.Linq;
using System.Xml.Serialization;
using WeApi.Models;

namespace WebApi.Models
{
    public class ClienteService
    {
        //private static object cliente;

            /// <summary>
            /// direccion de los xml
            /// </summary>
        public static string SiteAddress { get; set; }

        /// <summary>
        /// Obtiene todos los elementos de los xml
        /// </summary>
        /// <returns></returns>
        public static List<Cliente> GetAll(){

            var doc = XElement.Load(ConfigurationManager.AppSettings["Archivo1"]);
            var s = new XmlSerializer(typeof(List<Cliente>));
            var clientes = s.Deserialize(doc.CreateReader()) as List<Cliente>;
            return clientes;

        }

 

        /// <summary>
        /// Anade un nuevo cliente al xml
        /// </summary>
        /// <param name="cliente"></param>
        public static void AddCliente(Cliente cliente) {

            var clientes = GetAll();
            clientes.Add(cliente);
            XDocument doc = Serialize<List<Cliente>>(clientes);
            doc.Save(ConfigurationManager.AppSettings["Archivo1"]);
        }

        /// <summary>
        /// Serializa el xml
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        private static XDocument Serialize<T>(T source) {

            XDocument target = new XDocument();
            XmlSerializer s = new XmlSerializer(typeof(T));
            System.Xml.XmlWriter writer = target.CreateWriter();
            s.Serialize(writer, source);
            writer.Close();
            return target;
        }


    }
}