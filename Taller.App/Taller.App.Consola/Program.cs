using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia.Repositorios;

namespace Taller.App.Consola
{
    class Program
    {
        private static RepositorioMecanico Repositorio = new RepositorioMecanico
        (
            new Persistencia.AppRepositorios.AppContex()
        );

        private static RepositorioPropietario RepositorioPropietario = new RepositorioPropietario
        (
            new Persistencia.AppRepositorios.AppContex()
        );

        private static RepositorioVehiculo RepositorioVehiculo = new RepositorioVehiculo
        (
            new Persistencia.AppRepositorios.AppContex()
        );

        static void Main(string[] args)
        {
            //AgregarMecanico();
            //EditarMeceanico();
            //ObtenerMecanicos();
            //BuscarMecanico("8");
            //EliminarMecanico("1");
            //AgregarPropietario();
            EditarPropietario();
            //ObtenerPropietarios();
            //BuscarPropietario("2");
            //EliminarPropietario("2");
            
        }

        //--------------------------------------------------------------------------------------------
        // CRUD MECANICO
        //--------------------------------------------------------------------------------------------

        static void AgregarMecanico()
        {
            var mecanico = new Mecanico
            {
                Id = "2",
                Nombre = "Leydi",
                Apellido = "Taba",
                Telefono ="313543542",
                FechaNacimiento = new DateTime(1986,05,19),
                Correo = "lt@hotmail.gmail",
                Contrasenia = "Taba321",
                Ciudad = "Jamundi",
                NivelEstudio = "PHD",
            };
            Repositorio.AgregarMecanico(mecanico);
        }

        static void ObtenerMecanicos()
        {
            foreach (var m in Repositorio.ObtenerMecanicos())
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Nombre "+ m.Nombre + "\nTelefono "+ m.Telefono);
                Console.WriteLine("---------------------");
            }
        }

        static void BuscarMecanico(string Id)
        {
            var m = Repositorio.BuscarMecanico(Id);
            if(m != null)
            {
                Console.WriteLine("Se encontró " + m.Nombre +" "+ m.Apellido + "\n de "+ m.Ciudad);
            }
            else
            {
                Console.WriteLine("No se encontró");
            }
        }

        static void EliminarMecanico(string Id)
        {
            Repositorio.EliminarMecanico(Id);
        }

        static void EditarMeceanico()
        {
            var mecanico = new Mecanico
            {
                Id = "2",
                Nombre = "Mauricio",
                Apellido = "Gonzalez",
                Telefono ="313543542",
                FechaNacimiento = new DateTime(1986,05,19),
                Correo = "lt@hotmail.gmail",
                Contrasenia = "Taba321",
                Ciudad = "Tulua",
                NivelEstudio = "PHD",
            };
            Repositorio.EditarMeceanico(mecanico);
        }
        
    
    

        // ----------------------------------------------------------------------------------------------

        // CRUD DEL PROPIETARIO

        //-----------------------------------------------------------------------------------------------

         static void AgregarPropietario()
         {
            var propietario = new Propietario
            {
                Id = "2",
                Nombre = "Sandra",
                Apellido ="Gonzales",
                Telefono = "30177742323",
                FechaNacimiento = new DateTime(1987,11,22),
                Correo ="gmail",
                Contrasenia = "SG45",
                Ciudad = "Ibague",
                Direccion = "Av Caracas",
            };
            RepositorioPropietario.AgregarPropietario(propietario);
         }

         static void ObtenerPropietarios()
        {
            foreach (var p in RepositorioPropietario.ObtenerPropietario())
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Nombre "+ p.Nombre + "\nTelefono "+ p.Telefono);
                Console.WriteLine("---------------------");
            }
        }

        static void BuscarPropietario(string Id)
        {
            var p = RepositorioPropietario.BuscarPropietario(Id);
            if(p!= null)
            {
                Console.WriteLine("Se encontró " + p.Nombre +" "+ p.Apellido + "\n de "+ p.Ciudad);
            }
            else
            {
                Console.WriteLine("No se encontró");
            }
        }

        static void EliminarPropietario(string Id)
        {
            RepositorioPropietario.EliminarPropietario(Id);
        }

        static void EditarPropietario()
        {
            var propietario = new Propietario
            {
                Id = "2",
                Nombre = "Rigoberto",
                Apellido = "Madrid",
                Telefono ="3002423433",
                FechaNacimiento = new DateTime(1980,05,19),
                Correo = "Rm@hotmail.gmail",
                Contrasenia = "Madrid321",
                Ciudad = "Villa Maria",
                Direccion = "Diag 78",
            };
            RepositorioPropietario.EditarPropietario(propietario);
        }

        // CRUD VEHICULO


    }



}