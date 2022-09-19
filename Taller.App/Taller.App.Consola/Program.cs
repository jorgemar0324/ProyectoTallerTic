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


        {    //-----------------------Mecanico-------------------------------

           //AgregarMecanico();
            //EditarMeceanico();
            //ObtenerMecanicos();
            //BuscarMecanico("8");
            //EliminarMecanico("25");

            // -------------------------Propietario---------------------------

            //AgregarPropietario();
            //EditarPropietario();
            //ObtenerPropietarios();
            //BuscarPropietario("2");
            //EliminarPropietario("1");

            //--------------------------Vehiculo-------------------------------

            AgregarVehiculo();
            //ObtenerVehiculo();
            //BuscarVehiculo("1");
            //EliminarVehiculo("1");
            //EditarVehiculo();
            
        }

        //--------------------------------------------------------------------------------------------
        // CRUD MECANICO
        //--------------------------------------------------------------------------------------------

        static void AgregarMecanico()
        {
            var mecanico = new Mecanico
            {
                Id = "9778800",
                Nombre = "Luis",
                Apellido = "Serna",
                Telefono ="3124324567",
                FechaNacimiento = new DateTime(1976,03,22),
                Correo = "Luis@hotmail",
                Contrasenia = "Lucho097",
                Ciudad = "Rioacha",
                NivelEstudio = "Tecnico",
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
                Id = "6549006",
                Nombre = "Mauricio",
                Apellido = "Gonzalez",
                Telefono ="313543542",
                FechaNacimiento = new DateTime(1986,05,19),
                Correo = "lmg@hotmail.gmail",
                Contrasenia = "Mao321",
                Ciudad = "Tulua",
                NivelEstudio = "Ingeniero",
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
                Id = "24477911",
                Nombre = "Yeison",
                Apellido ="Zambrano",
                Telefono = "30224567876",
                FechaNacimiento = new DateTime(1999,01,30),
                Correo ="Yei987634@gmail",
                Contrasenia = "Yetlee78",
                Ciudad = "Pamplona",
                Direccion = "cll 13",
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
        //--------------------------------------------------------------------------------------
        // CRUD VEHICULO
        //----------------------------------------------------------------------------------------

        static void AgregarVehiculo()
        {
            var vehiculo = new Vehiculo
            {
                Id = "ZZZ583",
                Cedula = "24477911",
                Marca = "Lamborgini",
                Modelo = "2022",
                Pasajeros = "2",
                Motor = "V34",
                Pais = "EEUU",
                Descripcion = " Una uva",
            };
            RepositorioVehiculo.AgregarVehiculo(vehiculo);
        }

        static void ObtenerVehiculo()
        {
            foreach (var v in RepositorioVehiculo.ObtenerVehiculo())
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Vehiculo: "+ v.Marca + "\nModelo: "+ v.Modelo+"\nPropietario: "+ v.Cedula);
                Console.WriteLine("------------------");           
             }
        }


        static void BuscarVehiculo(string Id)
        {
            var v = RepositorioVehiculo.BuscarVehiculo(Id);
            if (v != null)

            {
                Console.WriteLine("Se encontró el vehiculo: " + v.Marca +" "+ v.Modelo + "\nPropietario: "+ v.Cedula);
            }
            else
            {
                Console.WriteLine("No se encontró");
            }
        }

        static void EliminarVehiculo(string Id)
        {
            RepositorioVehiculo.EliminarVehiculo(Id);
        }

        static void EditarVehiculo()
        {
            var vehiculo = new Vehiculo
            {
                Id = "1",
                Cedula = "2",
                Marca = "Renault",
                Modelo = "2008",
                Pasajeros = "5",
                Motor = "V6",
                Pais = "EEUU",
                Descripcion = " Como Nuevo",
            };
            RepositorioVehiculo.EditarVehiculo(vehiculo);
        }
    }



}