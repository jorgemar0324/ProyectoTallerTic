using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;

namespace Taller.App.Persistencia.AppRepositorios
{
    public class AppContex : DbContext
    {
        public DbSet<Mecanico> Mecanicos {get; set;}
        public DbSet<Propietario> Propietarios {get; set;}
        public DbSet<Vehiculo> Vehiculos {get; set;}
        public DbSet<Revision> Revisiones {get; set;}
        public DbSet<Repuesto> Repuestos {get; set;}

         

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehiculo>()
            .HasOne(p => p.Propietario)
            .WithMany(b => b.Vehiculos)
            .HasForeignKey(p => p.PropietarioId);

            modelBuilder.Entity<Revision>()
            .HasOne(m => m.Mecanico)
            .WithMany(r => r.Revision)
            .HasForeignKey(m => m.MecanicoAsignado);

            modelBuilder.Entity<Revision>()
            .HasOne(r => r.Vehiculo)
            .WithMany(v => v.Revision)
            .HasForeignKey(r => r.VehiculoAsignado);

    
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:server-tallertic-g9-e2.database.windows.net,1433;Initial Catalog=bd_tallertic;Persist Security Info=False;User ID=Jaguartech;Password=Jaguar02;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    }
}