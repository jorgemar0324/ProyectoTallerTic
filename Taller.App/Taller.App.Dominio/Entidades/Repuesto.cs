using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
namespace Taller.App.Dominio.Entidades
{
    public class Repuesto
    {
        public string Id {get; set;}
        public string Nombre {get; set;}
        public string Marca {get; set;}
        public string Caracteristicas {get; set;}
        public double Valor {get; set;}



        public Revision Revision {get; set;}
        public string RevisionId {get; set;}

    
       

        
    }
}