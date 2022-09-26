using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia;

namespace Taller.App.Front.Pages.JefeOperaciones
{
    public class GestionVehiculosModel : PageModel
    {
        private static RepositorioVehiculo repovehi = new RepositorioVehiculo(

            new Persistencia.AppContex()
        );


        public IEnumerable<Vehiculo> listaVehiculos;
        public Vehiculo vehiculoActual;

        public void OnGet()
        {
            this.ObtenerVehiculo();
        }


        public void ObtenerVehiculo()
        {
            this.listaVehiculos = (IEnumerable<Vehiculo>)repovehi.ObtenerVehiculo();
        }

        public void OnPostDel(string id)
        {
            if (id != null)
            {
                repovehi.EliminarVehiculo(id);
                this.ObtenerVehiculo();
            }
        }

        public void OnPostAdd(Vehiculo vehiculo)
        {
            // Console.WriteLine("Mecanico:" + mecanico.nivelEstudio);

            repovehi.AgregarVehiculo(vehiculo);
            this.ObtenerVehiculo();
        }


    }
}




