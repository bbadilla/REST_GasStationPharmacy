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
    public class doctorController : ApiController
    {
        /// <summary>
        /// Get para obtener todos los doctores
        /// </summary>
        /// <returns>  Todos los doctores del xml de tipo Objeto Doctor </returns>
        public IEnumerable<Doctor> Get()
        {

            //ClienteService.SiteAddress = string.Format("http://{0}{1}", Request.RequestUri.Host, (Request.RequestUri.Port != 80) ? string.Format(":{0}", Request.RequestUri.Port) : string.Empty);
            var result = DoctorService.GetAll();
            return result;

        }

        /// <summary>
        /// Post de doctor para anadir uno nuevo
        /// </summary>
        /// <param name="doctor"></param>
        public void Post(Doctor doctor)
        {

            DoctorService.AddDoctor(doctor);

        }

    }
}
