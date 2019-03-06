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
    public class DoctorService
    {
        //private static object doctor;

        /// <summary>
        /// direccion de los xml
        /// </summary>
        public static string SiteAddress { get; set; }

        /// <summary>
        /// Obtiene todos los elementos de los xml
        /// </summary>
        /// <returns></returns>
        public static List<Doctor> GetAll()
        {

            var doc = XElement.Load(ConfigurationManager.AppSettings["Archivo2"]);
            var s = new XmlSerializer(typeof(List<Doctor>));
            var doctores = s.Deserialize(doc.CreateReader()) as List<Doctor>;
            return doctores;

        }



        /// <summary>
        /// anade un nuevo doctor al xml
        /// </summary>
        /// <param name="doctor"></param>
        public static void AddDoctor(Doctor doctor)
        {

            var doctores = GetAll();
            doctores.Add(doctor);
            XDocument doc = Serialize<List<Doctor>>(doctores);
            doc.Save(ConfigurationManager.AppSettings["Archivo2"]);
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
