using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia;

namespace Taller.App.Front.Pages.JefeOperaciones
{
    public class GestionClientesModel : PageModel
    {
private static RepositorioPropietario repocliente = new RepositorioPropietario(

            new Persistencia.AppContex()
        );


        public IEnumerable<Propietario> listaPropietarios;
        public Propietario propietarioActual;

        public void OnGet()
        {
            this.ObtenerPropietario();
        }


        public void ObtenerPropietario()
        {
            this.listaPropietarios = (IEnumerable<Propietario>)repocliente.ObtenerPropietario();
        }

        public void OnPostDel(string id)
        {
            if (id != null)
            {
                repocliente.EliminarPropietario(id);
                this.ObtenerPropietario();
            }
        }

        public void OnPostAdd(Propietario propietario)
        {
            // Console.WriteLine("Mecanico:" + mecanico.nivelEstudio);

            repocliente.AgregarPropietario(propietario);
            this.ObtenerPropietario();
        }


    }
}


