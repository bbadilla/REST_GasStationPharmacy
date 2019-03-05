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
        private static object cliente;

        public static string SiteAddress { get; set; }

        public static List<Receta> GetAll()
        {

            var doc = XElement.Load(ConfigurationManager.AppSettings["Archivo5"]);
            var s = new XmlSerializer(typeof(List<Receta>));
            var recetas = s.Deserialize(doc.CreateReader()) as List<Receta>;
            return recetas;

        }




        public static void AddCliente(Receta receta)
        {

            var recetas = GetAll();
            recetas.Add(receta);
            XDocument doc = Serialize<List<Receta>>(recetas);
            doc.Save(ConfigurationManager.AppSettings["Archivo1"]);
        }

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