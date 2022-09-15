using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.App.Dominio.Entidades
{
    public class Revision
    {
         public string IdRevision {get; set;}
         public Vehiculo Vehiculo {get; set;}
         public Mecanico Mecanico {get; set;}
          public List<Repuesto> Repuestos = new List<Repuesto>();
          public string Observaciones {get; set;}
          public string Estado {get; set;}
          public DateTime FechaSolicitud {get; set;}
          public DateTime FechaAgendamiento {get; set;}
    }
}