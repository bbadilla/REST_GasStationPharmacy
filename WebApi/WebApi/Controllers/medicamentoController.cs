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

        public IEnumerable<Medicamento> Get() {

            //ClienteService.SiteAddress = string.Format("http://{0}{1}", Request.RequestUri.Host, (Request.RequestUri.Port != 80) ? string.Format(":{0}", Request.RequestUri.Port) : string.Empty);
            var result = MedicamentoService.GetAll();
            return result;

        }

        public void Post(Medicamento medicamento)
        {

            MedicamentoService.AddMedicamento(medicamento);

        }

    }

}
}
