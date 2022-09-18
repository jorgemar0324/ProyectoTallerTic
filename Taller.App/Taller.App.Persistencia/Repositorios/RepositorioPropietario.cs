using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia.AppRepositorios;

namespace Taller.App.Persistencia.Repositorios
{
    public class RepositorioPropietario
    {
        private readonly AppContex appContex;

        public RepositorioPropietario(AppContex contex)
        {
            this.appContex=contex;
        }

        public void AgregarPropietario(Propietario propietario)
        {
            this.appContex.Propietarios.Add(propietario);
            this.appContex.SaveChanges();
        }

        public IEnumerable<Propietario> ObtenerPropietario()
        {
            return this.appContex.Propietarios;
        }

        public Propietario BuscarPropietario(string Id)
        {
            try
            {
                return this.appContex.Propietarios.FirstOrDefault(p => p.Id == Id);
            }
            catch (System.Exception)
            {
                Console.WriteLine("No Encontrado Propietario" + Id);
                return null;
                throw;
            }
        }

        public void EliminarPropietario(string Id)
        {
            try
            {
                var propietario = this.appContex.Propietarios.FirstOrDefault(p => p.Id == Id);
                if( propietario != null)
                {
                    this.appContex.Propietarios.Remove(propietario);
                    this.appContex.SaveChanges();
                    Console.WriteLine("Se eliminó propietario " + Id +" con exito.");
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