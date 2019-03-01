using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeApi.Models;



namespace WeApi.Controllers
{
    public class pedidoController : ApiController
    {

        Pedido[] pedidos = new Pedido[]{

        new Pedido{recojo="la bomba cartago",cliente="Juanito Mora",telefono="25411014", listaMedicamentos="Drogas", hora="4:30pm", imagen="imagen"},

       };


        public IEnumerable<Pedido> GetAllPedido()
        {
            return pedidos;
        }


        public IHttpActionResult GetPedido(string id)
        {
            var doc = pedidos.FirstOrDefault((c) => c.cliente == id);
            if (doc != null)
            {
                return Ok(doc);
            }
            else
            {
                return NotFound();
            }
        }

    }
}