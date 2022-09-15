using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.App.Dominio.Entidades
{
    public class Notificacion
    {
        public string IdNotificacion {get; set;}
        public Revision Revision {get; set;}
        public string Descripcion {get; set;}
        public Propietario Propietario {get; set;}
        public Mecanico Mecanico {get; set;}
        public JefeOperaciones JefeOperaciones {get; set;}
    }
}