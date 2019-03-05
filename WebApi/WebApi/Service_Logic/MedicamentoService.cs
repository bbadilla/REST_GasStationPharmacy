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
    public class MedicamentoService
    {

        private static object medicamento;

        public static string SiteAddress { get; set; }

        public static List<Medicamento> GetAll()
        {

            var doc = XElement.Load(ConfigurationManager.AppSettings["Archivo3"]);
            var s = new XmlSerializer(typeof(List<Medicamento>));
            var medicamentos = s.Deserialize(doc.CreateReader()) as List<Medicamento>;
            return medicamentos;

        }




        public static void AddMedicamento(Medicamento medicamento)
        {

            var medicamentos = GetAll();
            medicamentos.Add(medicamento);
            XDocument doc = Serialize<List<Medicamento>>(medicamentos);
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