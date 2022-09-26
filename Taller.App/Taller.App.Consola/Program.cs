using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia;

namespace Taller.App.Consola
{
    class Program
    {
        private static RepositorioMecanico Repositorio = new RepositorioMecanico
        (
            new Persistencia.AppContex()
        );

        private static RepositorioPropietario RepositorioPropietario = new RepositorioPropietario
        (
            new Persistencia.AppContex()
        );

        private static RepositorioVehiculo RepositorioVehiculo = new RepositorioVehiculo
        (
            new Persistencia.AppContex()
        );

        private static RepositorioRepuesto RepositorioRepuesto = new RepositorioRepuesto
        (
            new Persistencia.AppContex()
        );

        private static RepositorioRevision RepositorioRevision = new RepositorioRevision
        (
            new Persistencia.AppContex()
        );

        static void Main(string[] args)


        {    //-----------------------Mecanico-------------------------------

            //AgregarMecanico();
            //EditarMecanico("1");
            //ObtenerMecanicos();
            //BuscarMecanico("1");
            //EliminarMecanico("6549007");

            // -------------------------Propietario---------------------------

            //AgregarPropietario();
            //EditarPropietario("1");
            //ObtenerPropietarios();
            // BuscarPropietario("1");
            //EliminarPropietario("1");

            //--------------------------Vehiculo-------------------------------

            //AgregarVehiculo();
            //ObtenerVehiculo();
            //BuscarVehiculo("CUN829");
            //EliminarVehiculo("VBP009");
            //EditarVehiculo();


            //---------------------------Repuesto-----------------------------------

            AgregarRepuesto();
            //ObtenerRepuesto();
            //EliminarRepuesto("0002");

            //---------------------------Revision-----------------------------------
            //AgregarRevision();
            //EditarRevision();
            //ObtenerRevision();
            //EliminarRevision("3");
        }

        //--------------------------------------------------------------------------------------------
        // CRUD MECANICO
        //--------------------------------------------------------------------------------------------

        static void AgregarMecanico()
        {
            var mecanico = new Mecanico
            {
                Id = "1",
                Nombre = "Carlos",
                Apellido = "Toro",
                Telefono = "45456355365",
                FechaNacimiento = new DateTime(1994, 05, 26),
                Correo = "lmarin@gmaill",
                Contrasenia = "gsdfgadsfv",
                Ciudad = "Cali",
                NivelEstudio = "Tecnólogo",
            };
            Repositorio.AgregarMecanico(mecanico);
        }

        static void ObtenerMecanicos()
        {
            foreach (var m in Repositorio.ObtenerMecanicos())
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Nombre " + m.Nombre + "\nId " + m.Id);
                Console.WriteLine("---------------------");
            }
        }

        static void BuscarMecanico(string Id)
        {
            var m = Repositorio.BuscarMecanico(Id);
            if (m != null)
            {
                Console.WriteLine("Se encontró " + m.Nombre + " " + m.Apellido + "\n de " + m.Ciudad);
            }
            else
            {
                Console.WriteLine("No se encontró Mecanico: " + Id);
            }
        }

        static void EliminarMecanico(string Id)
        {
            Repositorio.EliminarMecanico(Id);
        }

        static void EditarMecanico(string id)
        {
            var mecanico = new Mecanico
            {
                Id = "1",
                Nombre = "Jefry",
                Apellido = "Rivera",
                Telefono = "3034567867",
                FechaNacimiento = new DateTime(1999, 03, 06),
                Correo = "Jefri@gmail",
                Contrasenia = "jr567",
                Ciudad = "Rosas Cauca",
                NivelEstudio = "Tecnologo",
            };
            Repositorio.EditarMecanico(mecanico);
        }




        // ----------------------------------------------------------------------------------------------

        // CRUD DEL PROPIETARIO

        //-----------------------------------------------------------------------------------------------

        static void AgregarPropietario()
        {
            var propietario = new Propietario
            {
                Id = "1020",
                Nombre = "Julio",
                Apellido = "Jimenez",
                Telefono = "30535305",
                FechaNacimiento = new DateTime(1980, 01, 26),
                Correo = "jg@gmail",
                Contrasenia = "12345",
                Ciudad = "Bogota",
                Direccion = "Cra 98 55a",
            };
            RepositorioPropietario.AgregarPropietario(propietario);
        }

        static void ObtenerPropietarios()
        {
            foreach (var p in RepositorioPropietario.ObtenerPropietario())
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Nombre " + p.Nombre + "\nTelefono " + p.Telefono);
                Console.WriteLine("---------------------");
            }
        }

        static void BuscarPropietario(string Id)
        {
            var p = RepositorioPropietario.BuscarPropietario(Id);
            if (p != null)
            {
                Console.WriteLine("Se encontró " + p.Nombre + " " + p.Apellido + "\n de " + p.Ciudad);
            }
            else
            {
                Console.WriteLine("No se encontró Propietario: " + Id);
            }
        }

        static void EliminarPropietario(string Id)
        {
            RepositorioPropietario.EliminarPropietario(Id);
        }

        static void EditarPropietario(string Id)
        {
            var propietario = new Propietario
            {
                Id = "1",
                Nombre = "Rigoberto",
                Apellido = "Madrid",
                Telefono = "3002423433",
                FechaNacimiento = new DateTime(1980, 05, 19),
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
                Id = "ABC455",
                PropietarioId = "2",
                Marca = "Ford",
                Modelo = "1999",
                Pasajeros = "8",
                Motor = "2600",
                Pais = "EEUU",
                Descripcion = "",
            };
            RepositorioVehiculo.AgregarVehiculo(vehiculo);
        }

        static void ObtenerVehiculo()
        {
            foreach (var v in RepositorioVehiculo.ObtenerVehiculo())
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Vehiculo: " + v.Marca + "\nModelo: " + v.Modelo + "\nPropietario: " + v.PropietarioId);
                Console.WriteLine("------------------");
            }
        }


        static void BuscarVehiculo(string Id)
        {
            var v = RepositorioVehiculo.BuscarVehiculo(Id);
            if (v != null)

            {
                Console.WriteLine("Se encontró el vehiculo: " + v.Marca + " " + v.Modelo + "\nPropietario: " + v.PropietarioId);
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
                Id = "0011",
                Nombre = "Farola",
                Marca = "Chevrolet",
                Caracteristicas = "Farola Chevrolet Aveo",
                Valor = 340000,
                RevisionId = "0002"


            };
            RepositorioRepuesto.AgregarRepuesto(repuesto);
        }

        static void ObtenerRepuesto()
         {
            foreach (var v in RepositorioRepuesto.ObtenerRepuesto())
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Id Repuesto: " + v.Id + "\nNombre Repuesto: " + v.Nombre + "\nMarca Vehiculo: " + v.Marca);
                Console.WriteLine("------------------");
            }
        }

        static void EliminarRepuesto(string Id)
        {
            RepositorioRepuesto.EliminarRepuesto(Id);
        }

        //------------------------------------------------------------------------------
        // CRUD REVISION
        //------------------------------------------------------------------------------

        static void AgregarRevision()
        {
            var revision = new Revision
            {
                Id = "003",
                Observaciones = "Servicio Electrico",
                Estado = "Pendiente",
                FechaSolicitud = new DateTime(2022, 09, 22),
                FechaAgendamiento = new DateTime(2022, 09, 26),
                FechaEntrega = new DateTime(2022, 09, 30),
                MecanicoId = "9011",
                VehiculoId = "CUN828",


            };
            RepositorioRevision.AgregarRevision(revision);
        }

        static void EditarRevision(string Id)
        {
            var revision = new Revision
            {
                Id = "004",
                Observaciones = "Lamina y Pintura",
                Estado = "Esperando Repuesto",
                FechaSolicitud = new DateTime(2022, 05, 03),
                FechaAgendamiento = new DateTime(2022, 05, 03),
                FechaEntrega = new DateTime(2022, 05, 08),
                MecanicoId = "6549010",
                VehiculoId = "CUN829",
            };
            RepositorioRevision.EditarRevision(revision);
        }

        static void ObtenerRevision()
         {
            foreach (var v in RepositorioRevision.ObtenerRevision())
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Revision: " + v.Id + "\nMecanico: " + v.MecanicoId + "\nVehiculo: " + v.VehiculoId);
                Console.WriteLine("------------------");
            }
        }

         static void EliminarRevision(string Id)
        {
            RepositorioRevision.EliminarRevision(Id);
        }
    }



}