using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeApi.Models;
using WebApi.Service_Logic;

namespace WeApi.Controllers
{
    public class rolController : ApiController
    {
        /// <summary>
        /// Get para obtener todos los roles
        /// </summary>
        /// <returns>  Todos los roles del xml de tipo Objeto Rol </returns>
        public IEnumerable<Rol> Get()
        {

            //ClienteService.SiteAddress = string.Format("http://{0}{1}", Request.RequestUri.Host, (Request.RequestUri.Port != 80) ? string.Format(":{0}", Request.RequestUri.Port) : string.Empty);
            var result = RolService.GetAll();
            return result;

        }

        /// <summary>
        /// Post de rol para anadir uno nuevo
        /// </summary>
        /// <param name="rol"></param>
        public void Post(Rol rol)
        {

            RolService.AddRol(rol);

        }

    }

}

