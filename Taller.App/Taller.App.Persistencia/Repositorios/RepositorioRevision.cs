using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia;

namespace Taller.App.Persistencia
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

        public IEnumerable<Revision> ObtenerRevision()
        {
            return this.appContex.Revisiones;
        }

        public void EditarRevision(Revision rev)
        {
            try
            {
                var revision = this.appContex.Revisiones.FirstOrDefault(p => p.Id == rev.Id);
                if(revision != null)
                {
                    revision.Observaciones = rev.Observaciones;
                    revision.Estado = rev.Estado;
                    revision.FechaEntrega = rev.FechaEntrega;
                    this.appContex.SaveChanges();

                    Console.WriteLine("Revision Editada Con Exito");

                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("No se encontrò revision");
                throw;
            }
        }


        public void EliminarRevision(string Id)
        {
            try
            {
                var Revision = this.appContex.Revisiones.FirstOrDefault(p => p.Id == Id);
                if( Revision != null)
                {
                    this.appContex.Revisiones.Remove(Revision);
                    this.appContex.SaveChanges();
                    Console.WriteLine("Se eliminó Revision:  " + Id +"  con exito.");
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