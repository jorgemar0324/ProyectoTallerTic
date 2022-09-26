using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia;

namespace Taller.App.Front.Pages
{
    public class GestionMecanicoModel : PageModel
    {

        private static RepositorioMecanico repositorio = new RepositorioMecanico(

            new Persistencia.AppContex()
        );


        public IEnumerable<Mecanico> listaMecanicos;
        public Mecanico mecanicoActual;

        public void OnGet()
        {
            this.ObtenerMecanicos();
        }


        public void ObtenerMecanicos()
        {
            this.listaMecanicos = (IEnumerable<Mecanico>)repositorio.ObtenerMecanicos();
        }

        public void OnPostDel(string id)
        {
            if (id != null)
            {
                repositorio.EliminarMecanico(id);
                this.ObtenerMecanicos();
            }
        }

        public void OnPostAdd(Mecanico mecanico)
        {
            // Console.WriteLine("Mecanico:" + mecanico.nivelEstudio);

            repositorio.AgregarMecanico(mecanico);
            this.ObtenerMecanicos();
        }


    }
}


