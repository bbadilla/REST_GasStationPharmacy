using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeApi.Models;

namespace WeApi.Controllers
{
    public class recetaController : ApiController
    {

        Receta[] recetas = new Receta[]{

        new Receta{numero=116,doctor="Juanito Mora",medicamentos="pastillas", imagen="imagen"},
    
       };


        public IEnumerable<Receta> GetAllReceta()
        {
            return recetas;
        }


        public IHttpActionResult GetReceta(int id)
        {
            var doc = recetas.FirstOrDefault((c) => c.numero == id);
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