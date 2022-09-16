using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia.AppRepositorios;

namespace Taller.App.Persistencia.Repositorios
{
    public class RepositorioMecanico
    {
        private readonly AppContex appContex;

        public RepositorioMecanico(AppContex contex)
        {
            this.appContex = contex;
        }
        public void AgregarMecanico(Mecanico mecanico)
        {
            this.appContex.Mecanicos.Add(mecanico);
            this.appContex.SaveChanges();
        }

        public IEnumerable<Mecanico> ObtenerMecanicos()
        {
            return this.appContex.Mecanicos;
        }

        public Mecanico BuscarMecanico (string Id)
        {
            try
            {
                return this.appContex.Mecanicos.FirstOrDefault(m => m.Id == Id);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Exepcion");
                return null;
                throw;
            }
            
        }

        public void EliminarMecanico (string Id)
        {
            try
            {
                var mecanico = this.appContex.Mecanicos.FirstOrDefault(m => m.Id == Id);
                if (mecanico != null)
                {
                    this.appContex.Mecanicos.Remove(mecanico);
                    this.appContex.SaveChanges();
                    Console.WriteLine("Se Eliminó con exito");
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Exepcion");
                throw;
            }
        }
    }
}