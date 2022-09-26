using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia;

namespace Taller.App.Persistencia
{
    public class RepositorioRepuesto
    {
        private readonly AppContex appContex;

        public RepositorioRepuesto(AppContex contex)
        {
            this.appContex = contex;
        }

        public void AgregarRepuesto (Repuesto repuesto)
        {
            try
            {
                this.appContex.Repuestos.Add(repuesto);
                this.appContex.SaveChanges();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public IEnumerable<Repuesto> ObtenerRepuesto()
        {
            return this.appContex.Repuestos;
        }


        public void EliminarRepuesto (string Id)
        {
            try
            {
                var repuesto = this.appContex.Repuestos.FirstOrDefault(m => m.Id == Id);
                if (repuesto != null)
                {
                    this.appContex.Repuestos.Remove(repuesto);
                    this.appContex.SaveChanges();
                    Console.WriteLine("Se Eliminó Repuesto:  "+Id+"  con exito");
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