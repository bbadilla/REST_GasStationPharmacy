using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeApi.Models;

namespace WeApi.Controllers
{
    public class doctorController : ApiController
    {

        Doctor[] doctores = new Doctor[]{

        new Doctor{cedula=102151458,nombre="Mario",apellidos="Uasas sdsas", residencia="Italia", fechaNacimiento="XX/XX/98"},
        new Doctor{cedula=451211185,nombre="Vini",apellidos="Abendano Monge", residencia="XXX", fechaNacimiento="XX/XX/98"}

       };


        public IEnumerable<Doctor> GetAllDoctor()
        {
            return doctores;
        }


        public IHttpActionResult GetDoctor(string id)
        {
            var doc = doctores.FirstOrDefault((c) => c.nombre == id);
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
