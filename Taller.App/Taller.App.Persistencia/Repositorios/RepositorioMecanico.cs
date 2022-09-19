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
            try
            {
                this.appContex.Mecanicos.Add(mecanico);
                this.appContex.SaveChanges();
                Console.WriteLine("Se agrego Mecanico Con exito");
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
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
                Console.WriteLine("No se ha encontrado Mecanico" + Id);
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
                    Console.WriteLine("Se Eliminó Mecanico:  "+Id+"  con exito");
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Exepcion");
                throw;
            }
        }

        public void EditarMeceanico (Mecanico mec )
        {
            try
            {
                var mecanico = this.appContex.Mecanicos.FirstOrDefault(m => m.Id == mec.Id);
                if(mecanico != null)
                {
                    mecanico.Nombre = mec.Nombre;
                    mecanico.Apellido = mec.Apellido;
                    mecanico.Telefono = mec.Telefono;
                    mecanico.FechaNacimiento = mec.FechaNacimiento;
                    mecanico.Correo = mec.Correo;
                    mecanico.Contrasenia = mec.Contrasenia;
                    mecanico.Ciudad = mec.Ciudad;
                    mecanico.NivelEstudio = mec.NivelEstudio;
                    this.appContex.SaveChanges();
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