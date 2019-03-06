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
    public class SucursalService
    {
        private static object rol;
        /// <summary>
        /// Direccion del xml
        /// </summary>
        public static string SiteAddress { get; set; }

        /// <summary>
        /// Obtiene todas las sucursales del xml
        /// </summary>
        /// <returns></returns>
        public static List<Sucursal> GetAll()
        {

            var doc = XElement.Load(ConfigurationManager.AppSettings["Archivo7"]);
            var s = new XmlSerializer(typeof(List<Sucursal>));
            var roles = s.Deserialize(doc.CreateReader()) as List<Sucursal>;
            return roles;

        }



        /// <summary>
        /// anade una nueva sucursal al xml
        /// </summary>
        /// <param name="rol"></param>
        public static void AddSucursal(Sucursal rol)
        {

            var roles = GetAll();
            roles.Add(rol);
            XDocument doc = Serialize<List<Sucursal>>(roles);
            doc.Save(ConfigurationManager.AppSettings["Archivo7"]);
        }


        /// <summary>
        /// Serializa el xml
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
