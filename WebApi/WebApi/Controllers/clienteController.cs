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

     

        public IEnumerable<Cliente> Get() {

           //ClienteService.SiteAddress = string.Format("http://{0}{1}", Request.RequestUri.Host, (Request.RequestUri.Port != 80) ? string.Format(":{0}", Request.RequestUri.Port) : string.Empty);
            var result = ClienteService.GetAll();
            return result;
            
        }

            public void Post(Cliente cliente)
        {
            
            ClienteService.AddCliente(cliente);

        }

    }
}
