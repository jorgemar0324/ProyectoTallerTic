using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Taller.App.Dominio.Entidades
{
    public class Persona
    {  
        public string Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Telefono {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public string Correo {get; set;}
        public string Contrasenia {get; set;}
            
    }
}