using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia.AppRepositorios;

namespace Taller.App.Persistencia.Repositorios
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
            this.appContex.Vehiculos.Add(vehiculo);
            this.appContex.SaveChanges();
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
                    Console.WriteLine("Se eliminó Vehiculo"+ Id+" con exito");
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("No se pudo Eliminar");
                throw;
            }
        }
    }
}