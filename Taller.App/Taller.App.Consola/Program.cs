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

        private static RepositorioRepuesto RepositorioRepuesto = new RepositorioRepuesto
        (
            new Persistencia.AppRepositorios.AppContex()
        );

        private static RepositorioRevision RepositorioRevision = new RepositorioRevision
        (
            new Persistencia.AppRepositorios.AppContex()
        );

        static void Main(string[] args)


        {    //-----------------------Mecanico-------------------------------

            //AgregarMecanico();
            //EditarMeceanico();
            //ObtenerMecanicos();
            //BuscarMecanico("6549007");
            //EliminarMecanico("6549007");

            // -------------------------Propietario---------------------------

            //AgregarPropietario();
            //EditarPropietario();
            //ObtenerPropietarios();
            //BuscarPropietario("11223344558");
            //EliminarPropietario("11223344558");

            //--------------------------Vehiculo-------------------------------

            //AgregarVehiculo();
            //ObtenerVehiculo();
            //BuscarVehiculo("CUN829");
            //EliminarVehiculo("VBP009");
            //EditarVehiculo();


            //---------------------------Repuesto-----------------------------------

            //AgregarRepuesto();
            //AgregarRevision();
        }

        //--------------------------------------------------------------------------------------------
        // CRUD MECANICO
        //--------------------------------------------------------------------------------------------

        static void AgregarMecanico()
        {
            var mecanico = new Mecanico
            {
                Id = "6549010",
                Nombre = "Felipe",
                Apellido = "Torres",
                Telefono ="3124560762",
                FechaNacimiento = new DateTime(1999,05,26),
                Correo = "fTorres@hotmail",
                Contrasenia = "Jarajara213",
                Ciudad = "Tulua",
                NivelEstudio = "Ingeniero",
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
                Console.WriteLine("No se encontró Mecanico: "+ Id );
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
               Id = "6549008",
                Nombre = "Jefry",
                Apellido = "Rivera",
                Telefono ="3034567867",
                FechaNacimiento = new DateTime(1999,03,06),
                Correo = "Jefri@gmail",
                Contrasenia = "jr567",
                Ciudad = "Rosas Cauca",
                NivelEstudio = "Tecnologo",
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
                Id = "11223344559",
                Nombre = "David",
                Apellido ="Arias",
                Telefono = "3003467891",
                FechaNacimiento = new DateTime(2000,06,25),
                Correo ="DArias@gmail",
                Contrasenia = "Pasword456",
                Ciudad = "Manizalez",
                Direccion = "Av Santander",
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
                Console.WriteLine("No se encontró Propietario: "+ Id);
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
                Id = "CUN830",
                PropietarioId = "11223344559",
                Marca = "BMW",
                Modelo = "2023",
                Pasajeros = "2",
                Motor = "V10",
                Pais = "EEUU",
                Descripcion = " 0 Km",
            };
            RepositorioVehiculo.AgregarVehiculo(vehiculo);
        }

        static void ObtenerVehiculo()
        {
            foreach (var v in RepositorioVehiculo.ObtenerVehiculo())
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Vehiculo: "+ v.Marca + "\nModelo: "+ v.Modelo+"\nPropietario: "+ v.PropietarioId);
                Console.WriteLine("------------------");           
             }
        }


        static void BuscarVehiculo(string Id)
        {
            var v = RepositorioVehiculo.BuscarVehiculo(Id);
            if (v != null)

            {
                Console.WriteLine("Se encontró el vehiculo: " + v.Marca +" "+ v.Modelo + "\nPropietario: "+ v.PropietarioId);
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
                Id = "CUN829",
                PropietarioId = "11223344556",
                Marca = "KIA",
                Modelo = "2015",
                Pasajeros = "4",
                Motor = "Gas",
                Pais = "Colombia",
                Descripcion = " 250000 Km",
            };
            RepositorioVehiculo.EditarVehiculo(vehiculo);
        }

        //---------------------------------------------------------------------------------------
        //CRUD REPUESTO
        //---------------------------------------------------------------------------------------

        static void AgregarRepuesto()
        {
            var repuesto = new Repuesto
            {
                Id = "LGTH001-4",
                Nombre = "Farola",
                Marca = "Chevrolet",
                Caracteristicas = "Farola Chevrolet Aveo",
                Valor = 340000,
            
            
            };
            RepositorioRepuesto.AgregarRepuesto(repuesto);
        }

        //------------------------------------------------------------------------------
        // CRUD REVISION
        //------------------------------------------------------------------------------

        static void AgregarRevision()
        {
            var revision = new Revision
            {
                Id = "004",
                Observaciones = "Lamina y Pintura",
                Estado = "Esperando Repuesto",
                FechaSolicitud = new DateTime(2022,05,03),
                FechaAgendamiento = new DateTime(2022,05,03),
                FechaEntrega = new DateTime(2022,05,08),
                MecanicoAsignado = "6549010",
                VehiculoAsignado = "CUN829",
                
            
            };
            RepositorioRevision.AgregarRevision(revision);
        }
    }



}