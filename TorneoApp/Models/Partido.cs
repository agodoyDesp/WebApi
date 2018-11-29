using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TorneoApp.Models
{
    public class Partido
    {
        public int Id { get; set; }
        public String Equipo1 { get; set; }
        public String Equipo2 { get; set; }
        public Double Temperatura { get; set; }
    }
}