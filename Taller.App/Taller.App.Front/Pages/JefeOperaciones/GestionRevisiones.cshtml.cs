using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia;

namespace Taller.App.Front.Pages.JefeOperaciones
{
    public class GestionRevisionesModel : PageModel
    {
        private static RepositorioRevision reporevisiones = new RepositorioRevision(

            new Persistencia.AppContex()
        );


        public IEnumerable<Revision> listaRevisiones;
        public Revision revisionActual;

        public void OnGet()
        {
            this.ObtenerRevision();
        }


        public void ObtenerRevision()
        {
            this.listaRevisiones = (IEnumerable<Revision>)reporevisiones.ObtenerRevision();
        }


        public void OnPostDel(string id)
        {
            if (id != null)
            {
                reporevisiones.EliminarRevision(id);
                this.ObtenerRevision();
            }
        }

        public void OnPostAdd(Revision revision)
        {
            // Console.WriteLine("Mecanico:" + mecanico.nivelEstudio);

            reporevisiones.AgregarRevision(revision);
            this.ObtenerRevision();
        }


    }
}




