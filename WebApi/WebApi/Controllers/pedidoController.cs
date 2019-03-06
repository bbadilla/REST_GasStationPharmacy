using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeApi.Models;
using WebApi.Models;

namespace WeApi.Controllers
{
    public class pedidoController : ApiController
    {

        /// <summary>
        /// Get para obtener todos los pedidos
        /// </summary>
        /// <returns>  Todos los pedidos del xml de tipo Objeto Pedido </returns>
        public IEnumerable<Pedido> Get()
        {

            //ClienteService.SiteAddress = string.Format("http://{0}{1}", Request.RequestUri.Host, (Request.RequestUri.Port != 80) ? string.Format(":{0}", Request.RequestUri.Port) : string.Empty);
            var result = PedidoService.GetAll();
            return result;

        }

        /// <summary>
       /// //////Post de pedido para anadir uno nuevo
        /// </summary>
        /// <param name="pedido"></param>
        public void Post(Pedido pedido)
        {

            PedidoService.AddPedido(pedido);

        }

    }

}