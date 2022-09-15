using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.App.Dominio.Entidades
{
    public class Mecanico : Persona
    {
        public string Ciudad {get; set;}
        public string NivelEstudios {get; set;}
    }
}