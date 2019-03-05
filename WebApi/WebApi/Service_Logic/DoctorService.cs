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
        private static object doctor;

        public static string SiteAddress { get; set; }

        public static List<Doctor> GetAll()
        {

            var doc = XElement.Load(ConfigurationManager.AppSettings["Archivo2"]);
            var s = new XmlSerializer(typeof(List<Doctor>));
            var doctores = s.Deserialize(doc.CreateReader()) as List<Doctor>;
            return doctores;

        }




        public static void AddDoctor(Doctor doctor)
        {

            var doctores = GetAll();
            doctores.Add(doctor);
            XDocument doc = Serialize<List<Doctor>>(doctores);
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
