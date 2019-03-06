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
    public class RecetaService
    {
        //private static object cliente;
        /// <summary>
        /// /Direccion del xml
        /// </summary>
        public static string SiteAddress { get; set; }

        /// <summary>
        /// Obtiene todos los elementos del xml
        /// </summary>
        /// <returns></returns>
        public static List<Receta> GetAll()
        {

            var doc = XElement.Load(ConfigurationManager.AppSettings["Archivo5"]);
            var s = new XmlSerializer(typeof(List<Receta>));
            var recetas = s.Deserialize(doc.CreateReader()) as List<Receta>;
            return recetas;

        }



        /// <summary>
        /// /Anade 
        /// </summary>
        /// <param name="receta"></param>
        public static void AddReceta(Receta receta)
        {

            var recetas = GetAll();
            recetas.Add(receta);
            XDocument doc = Serialize<List<Receta>>(recetas);
            doc.Save(ConfigurationManager.AppSettings["Archivo4"]);
        }

        /// <summary>
        /// serializa el xml
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        private static XDocument Serialize<T>(T source)
        {

            XDocument target = new XDocument();
            XmlSerializer s = new XmlSerializer(typeof(T));
            System.Xml.XmlWriter writer = target.CreateWriter();
            s.Serialize(writer, source);
            writer.Close();
            return target;
        }


    }
}