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
            try
            {
                this.appContex.Propietarios.Add(propietario);
                this.appContex.SaveChanges();
                Console.WriteLine("Se agrego Propietario con exito");
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
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
                    Console.WriteLine("Se eliminó propietario:  " + Id +"  con exito.");
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("No se pudo Eliminar");
                throw;
            }
        }

        public void EditarPropietario(Propietario propi) 
        {
            try
            {
             var propietario = this.appContex.Propietarios.FirstOrDefault(p => p.Id == propi.Id);
             if(propietario != null)
            {
                propietario.Nombre = propi.Nombre;
                propietario.Apellido = propi.Apellido;
                propietario.Telefono = propi.Telefono;
                propietario.FechaNacimiento = propi.FechaNacimiento;
                propietario.Correo = propi.Correo;
                propietario.Contrasenia = propi.Contrasenia;
                propietario.Ciudad = propi.Ciudad;
                propietario.Direccion = propi.Direccion;
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