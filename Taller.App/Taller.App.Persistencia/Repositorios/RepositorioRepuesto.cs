using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia.AppRepositorios;

namespace Taller.App.Persistencia.Repositorios
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
        
    }
}