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

        static void Main(string[] args)
        {
            //AgregarMecanico();
            //ObtenerMecanicos();
            //BuscarMecanico("8");
            EliminarMecanico("1");
        }

        static void AgregarMecanico()
        {
            var mecanico = new Mecanico
            {
                Id = "3",
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
    }



}