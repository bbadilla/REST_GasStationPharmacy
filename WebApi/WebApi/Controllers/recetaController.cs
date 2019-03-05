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
    public class recetaController : ApiController
    {

        public IEnumerable<Receta> Get()
        {

            //ClienteService.SiteAddress = string.Format("http://{0}{1}", Request.RequestUri.Host, (Request.RequestUri.Port != 80) ? string.Format(":{0}", Request.RequestUri.Port) : string.Empty);
            var result = RecetaService.GetAll();
            return result;

        }

        public void Post(Receta receta)
        {

            RecetaService.AddCliente(receta);

        }
    }
}