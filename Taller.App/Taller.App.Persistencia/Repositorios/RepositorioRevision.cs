using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia.AppRepositorios;

namespace Taller.App.Persistencia.Repositorios
{
    public class RepositorioRevision
    {
        private readonly AppContex appContex;


        public RepositorioRevision (AppContex contex)
        {
            this.appContex = contex;
        }

        public void AgregarRevision(Revision revision)
        {
            try
            {
                this.appContex.Revisiones.Add(revision);
                this.appContex.SaveChanges();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}