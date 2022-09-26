using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace Taller.App.Dominio.Entidades
{
    public class Vehiculo
    {
        
        public string Id {get; set;}
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public string Pasajeros {get; set;}
        public string Motor {get; set;}
        public string Pais {get; set;}
        public string Descripcion {get; set;}


        public Propietario Propietario {get; set;}
        public string PropietarioId {get; set;}



        public List<Revision> Revisiones {get; set;}


    }
}