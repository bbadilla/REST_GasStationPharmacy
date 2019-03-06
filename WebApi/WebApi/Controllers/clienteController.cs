using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WeApi.Models;
using WebApi.Models;

namespace WeApi.Controllers
{
    public class clienteController : ApiController
    {

     
        /// <summary>
        /// Get para obtener todos los clientes
        /// </summary>
        /// <returns>  Todos los clientes del xml de tipo Objeto Cliente </returns>
        public IEnumerable<Cliente> Get() {

           //ClienteService.SiteAddress = string.Format("http://{0}{1}", Request.RequestUri.Host, (Request.RequestUri.Port != 80) ? string.Format(":{0}", Request.RequestUri.Port) : string.Empty);
            var result = ClienteService.GetAll();
            return result;
            
        }

        /// <summary>
        /// Post de cliente anade un cliente al xml
        /// </summary>
        /// <param name="cliente"></param>
        /// 
            public void Post(Cliente cliente)
        {
            
            ClienteService.AddCliente(cliente);

        }

    }
}
