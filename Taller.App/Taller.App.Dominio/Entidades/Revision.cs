using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Taller.App.Dominio.Entidades
{
    public class Revision
    {       
        public string Id {get; set;}
        public string Observaciones {get; set;}
        public string Estado {get; set;}
        public DateTime FechaSolicitud {get; set;}
        public DateTime FechaAgendamiento {get; set;}
        public DateTime FechaEntrega {get; set;}


        public Mecanico Mecanico{get; set;}
        public string MecanicoAsignado {get; set;}

    
        public Vehiculo Vehiculo{get; set;}
        public string VehiculoAsignado {get; set;}

        public Repuesto Repuesto {get; set;}
        public string RepuestoAsignado {get; set;}
        
    }
}