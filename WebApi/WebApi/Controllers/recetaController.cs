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
        /// <summary>
        /// Get para obtener todos las recetas
        /// </summary>
        /// <returns>  Todos las recetas del xml de tipo Objeto Receta </returns>
        public IEnumerable<Receta> Get()
        {

            //ClienteService.SiteAddress = string.Format("http://{0}{1}", Request.RequestUri.Host, (Request.RequestUri.Port != 80) ? string.Format(":{0}", Request.RequestUri.Port) : string.Empty);
            var result = RecetaService.GetAll();
            return result;

        }

        /// <summary>
        /// Post de receta para anadir uno nuevo
        /// </summary>
        /// <param name="receta"></param>
        public void Post(Receta receta)
        {

            RecetaService.AddReceta(receta);

        }
    }
}