using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TorneoApp.Models;

namespace TorneoApp.Controllers
{
    public class PartidoController : ApiController
    {
        Partido[] partidos = new Partido[] {
            new Partido { Id = 1, Equipo1 = "Peñarol", Equipo2 = "Nacional", Temperatura = 22.0 },
            new Partido { Id = 2, Equipo1 = "Cerro", Equipo2 = "Rampla", Temperatura = 24 },
            new Partido { Id = 3, Equipo1 = "Progreso", Equipo2 ="Livepool", Temperatura = 16 }
        };

        [HttpGet]
        public IEnumerable<Partido> PartidosFecha() { return partidos; }

        [HttpGet]
        public IHttpActionResult darPartido(int id)
        {
            var partido = partidos.FirstOrDefault((p) => p.Id == id);
            if(partido == null)
            {
                return NotFound();
            }
            return Ok(partido);
        }
    }
}
