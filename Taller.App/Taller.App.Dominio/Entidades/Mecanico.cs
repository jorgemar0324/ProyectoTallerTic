using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Taller.App.Dominio.Entidades
{
    public class Mecanico : Persona
    {
        public string NivelEstudio {get; set;}

        public List<Revision> Revisiones {get; set;}
    }   
}