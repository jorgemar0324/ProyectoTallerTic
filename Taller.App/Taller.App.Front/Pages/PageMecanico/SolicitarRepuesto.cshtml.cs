using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia;

namespace Taller.App.Front.pages
{
    public class SolicitarRepuestoModel : PageModel
    {

        private static RepositorioRepuesto repositorioRepuesto = new RepositorioRepuesto(

            new Persistencia.AppContex()
        );

        public IEnumerable<Repuesto> ListaRepuestos;


        public Repuesto repuestoActual;

        public void OnPostDel(string id)
        {
            if (id != null)
            {
                repositorioRepuesto.EliminarRepuesto(id);
                this.ObtenerRepuesto();
            }
        } 
       
        public void OnGet()
        {
            this.ObtenerRepuesto();
        }

         public void ObtenerRepuesto()
        {
            this.ListaRepuestos = (IEnumerable<Repuesto>)repositorioRepuesto.ObtenerRepuesto();
        }

        public void OnPostAdd(Repuesto repuesto)
        {
            repositorioRepuesto.AgregarRepuesto(repuesto);
            this.ObtenerRepuesto();
        }


    
    }
}
