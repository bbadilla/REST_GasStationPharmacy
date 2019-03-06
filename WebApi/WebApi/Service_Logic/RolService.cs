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
namespace WebApi.Service_Logic
{
    public class RolService
    {
        private static object rol;
        /// <summary>
        /// /Direccion del xml
        /// </summary>
        public static string SiteAddress { get; set; }

        /// <summary>
        /// Obtiene todos los roles del xml
        /// </summary>
        /// <returns></returns>
        public static List<Rol> GetAll()
        {

            var doc = XElement.Load(ConfigurationManager.AppSettings["Archivo6"]);
            var s = new XmlSerializer(typeof(List<Rol>));
            var roles = s.Deserialize(doc.CreateReader()) as List<Rol>;
            return roles;

        }



        /// <summary>
        /// /Anade un nuevo rol al xml
        /// </summary>
        /// <param name="rol"></param>
        public static void AddRol(Rol rol)
        {

            var roles = GetAll();
            roles.Add(rol);
            XDocument doc = Serialize<List<Rol>>(roles);
            doc.Save(ConfigurationManager.AppSettings["Archivo6"]);
        }


        /// <summary>
        /// /serializa el xml
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
