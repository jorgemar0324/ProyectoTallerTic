using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Taller.App.Dominio.Entidades
{
    public class Vehiculo
    {
        public string Id {get; set;}
        public Propietario Propietario{ get; set;}
        public string Marca {get; set;}
        public int Modelo {get; set;}
        public int Pasajeros {get; set;}
        public string Motor {get; set;}
        public string Pais{get; set;}
        public string Descripcion{get; set;}
        
    }
}