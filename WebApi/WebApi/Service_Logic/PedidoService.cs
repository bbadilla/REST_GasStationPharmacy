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
    public class PedidoService
    {
        private static object pedido;

        public static string SiteAddress { get; set; }

        public static List<Pedido> GetAll()
        {

            var doc = XElement.Load(ConfigurationManager.AppSettings["Archivo4"]);
            var s = new XmlSerializer(typeof(List<Pedido>));
            var pedidos = s.Deserialize(doc.CreateReader()) as List<Pedido>;
            return pedidos;

        }




        public static void AddPedido(Pedido pedido)
        {

            var pedidos = GetAll();
            pedidos.Add(pedido);
            XDocument doc = Serialize<List<Pedido>>(pedidos);
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