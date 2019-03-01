using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeApi.Models;

namespace WeApi.Controllers
{
    public class clienteController : ApiController
    {

        Cliente[] clientes = new Cliente[]{
       
        new Cliente{cedula=109854122,nombre="Emanuel",apellidos="Esquivel Lopez", residencia="Palmares", fechaNacimiento="XX/XX/98", telefono=85254547, padecimientos= "dormir"},
        new Cliente{cedula=451211185,nombre="Vini",apellidos="Abendano Monge", residencia="XXX", fechaNacimiento="XX/XX/98", telefono=34556577, padecimientos= "LOL"}
           
       };


        public IEnumerable<Cliente> GetAllCliente() {
            return clientes;
        }


        public IHttpActionResult GetCliente(string id) {
            var client = clientes.FirstOrDefault((c)=>c.nombre==id);
            if (client!=null)
            {
                return Ok(client);
            }
            else
            {
                return NotFound();
            }
        }

    }
}
