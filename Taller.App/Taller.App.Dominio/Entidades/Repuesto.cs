using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.App.Dominio.Entidades
{
    public class Repuesto
    {
        public string IdRepuesto {get; set;}
        public string NombreRepuesto {get; set;}
        public string MarcaRepuesto {get; set;}
        public string Caracteristicas {get; set;}
        public double Valor {get; set;}
    }
}