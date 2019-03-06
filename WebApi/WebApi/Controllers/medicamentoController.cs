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
    public class medicamentoController : ApiController
    {

        /// <summary>
        /// Get para obtener todos los medicamentos
        /// </summary>
        /// <returns>  Todos los medicamentos del xml de tipo Objeto Medicamento </returns>
        public IEnumerable<Medicamento> Get() {

            //ClienteService.SiteAddress = string.Format("http://{0}{1}", Request.RequestUri.Host, (Request.RequestUri.Port != 80) ? string.Format(":{0}", Request.RequestUri.Port) : string.Empty);
            var result = MedicamentoService.GetAll();
            return result;

        }

        /// <summary>
        /// //////Post de medicamento para anadir uno nuevo
        /// </summary>
        /// <param name="medicamento"></param>
        public void Post(Medicamento medicamento)
        {

            MedicamentoService.AddMedicamento(medicamento);

        }

    }

}

