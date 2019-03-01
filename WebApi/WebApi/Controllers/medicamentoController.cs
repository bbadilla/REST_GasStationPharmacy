using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeApi.Models;

namespace WeApi.Controllers
{
    public class medicamentoController : ApiController
    {

        Medicamento[] medicamentos = new Medicamento[]{

        new Medicamento{nombre="paracetamol",farmacia="La bomba",prescripcion="NO", cantidad=10000, precio=500},
        new Medicamento{nombre="Tapcin",farmacia="Fishel",prescripcion="NO", cantidad=999, precio=1000},

       };


        public IEnumerable<Medicamento> GetAllMedicamento()
        {
            return medicamentos;
        }


        public IHttpActionResult GetMedicamento(string id)
        {
            var doc = medicamentos.FirstOrDefault((c) => c.nombre == id);
            if (doc != null)
            {
                return Ok(doc);
            }
            else
            {
                return NotFound();
            }
        }

    }
}
