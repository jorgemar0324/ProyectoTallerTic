using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia;

namespace Taller.App.Persistencia
{
    public class RepositorioVehiculo
    {
        private readonly AppContex appContex;

        public RepositorioVehiculo(AppContex contex)
        {
            this.appContex = contex;
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                this.appContex.Vehiculos.Add(vehiculo);
                this.appContex.SaveChanges();
                Console.WriteLine("");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Se agregó Vehiculo con Exito");
                Console.WriteLine("----------------------------");
                Console.WriteLine("");
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
        }

        public IEnumerable<Vehiculo> ObtenerVehiculo()
        {
            return this.appContex.Vehiculos;
        }

        public Vehiculo BuscarVehiculo(string Id)
        {
            try
            {
                return this.appContex.Vehiculos.FirstOrDefault(v => v.Id == Id);
            }
            catch (System.Exception)
            {
                Console.WriteLine("No se ha Encontrado Vehiculo" + Id);
                return null;   
                throw;
            }
        }

        public void EliminarVehiculo(string Id)
        {
            try
            {
                var vehiculo = this.appContex.Vehiculos.FirstOrDefault(v => v.Id ==Id);
                if(vehiculo != null)
                {
                    this.appContex.Vehiculos.Remove(vehiculo);
                    this.appContex.SaveChanges();
                    Console.WriteLine("Se eliminó Vehiculo: "+ Id+"  con exito");
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("No se pudo Eliminar");
                throw;
            }
        }

        public void EditarVehiculo(Vehiculo vehi)
        {
            try
            {
                var vehiculo = this.appContex.Vehiculos.FirstOrDefault(p => p.Id == vehi.Id);
                if(vehiculo != null)
                {
                    vehiculo.Marca = vehi.Marca;
                    vehiculo.Modelo = vehi.Modelo;
                    vehiculo.Pasajeros = vehi.Pasajeros;
                    vehiculo.Motor = vehi.Motor;
                    vehiculo.Pais = vehi.Pais;
                    vehiculo.Descripcion = vehi.Descripcion;
                    vehiculo.PropietarioId = vehi.PropietarioId;
                    this.appContex.SaveChanges();

                    Console.WriteLine("Vehiculo Editado Con Exito");

                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("No se encontrò elemento");
                throw;
            }
        }
    }
}