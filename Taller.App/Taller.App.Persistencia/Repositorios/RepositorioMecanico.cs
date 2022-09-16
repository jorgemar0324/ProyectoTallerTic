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
    }
}