using System;
using System.Linq;

namespace Taller.App.Dominio.Entidades
{
    public class Vehiculo
    {
        public Propietario Propietario {get; set;}
        public string IdPlaca {get; set;}
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public string Pasajeros {get; set;}
        public string Motor {get; set;}
        public string Pais {get; set;}
        public string Descripcion {get; set;}

    }
}