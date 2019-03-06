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
    public class sucursalController : ApiController
    {
        /// <summary>
        /// Get para obtener todos las sucursales
        /// </summary>
        /// <returns>  Todos las sucursales del xml de tipo Objeto Sucursal </returns>
        public IEnumerable<Sucursal> Get()
        {

            //ClienteService.SiteAddress = string.Format("http://{0}{1}", Request.RequestUri.Host, (Request.RequestUri.Port != 80) ? string.Format(":{0}", Request.RequestUri.Port) : string.Empty);
            var result = SucursalService.GetAll();
            return result;

        }

        /// <summary>
        /// Anade una nueva sucursal
        /// </summary>
        /// <param name="rol"></param>
        public void Post(Sucursal rol)
        {

            SucursalService.AddSucursal(rol);

        }

    }

}

