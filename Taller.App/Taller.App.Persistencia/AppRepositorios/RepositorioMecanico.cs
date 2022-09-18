using Microsoft.EntityFrameworkCore;
using Taller.App.Dominio.Entidades;
using System.Linq;
namespace Taller.App.Persistencia.AppRepositorios
{
    public class NewBaseType
    {
        /// <Sumary>
        /// Referancia al contexto del Mecanico
        /// </Sumary>
        private readonly AppContext _appContext;
    }

    public class RepositorioMecanico : NewBaseType, IRepositorioMecanico
    {
        ///<Sumary>
        /// Metodo constructor Utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </Sumary>
        /// <param name= "appContext"> </param> //

        public RepositorioMecanico(AppContext appContext)
        {
            _appContext=appContext;
        }

        Mecanico IRepositorioMecanico.AddMecanico(Mecanico mecanico)
        {
            var MecanicoAdicionado= _appContext.Mecanico.add(mecanico);
            _appContext.SaveChanges();
            return MecanicoAdicionado.Entity;
        }

        void IRepositorioMecanico.DeleteMecanico(int IdMecanico)
        {
            var MecanicoEncontrado= _appContext.Mecanico.FirstOrDefault(p => p.IdMecanico);
            if(MecanicoEncontrado==null)
            return;
            _appContext.Mecanico.Remove(MecanicoEncontrado);
            _appContext.SaveChanges;
        }
        
        IEnumerable<Mecanico> IRepositorioMecanico.GetAllMecanico()
        {
            return _appContext.Mecanico;
        }

        Mecanico IRepositorioMecanico.GetMecanico(int IdMecanico)
        {
            return _appContext.Mecanico.FirstOrDefault(p => p.IdMecanico);
        }

        Mecanico IRepositorioMecanico.UpdateMecanico(Mecanico mecanico)
        {
            var MecanicoEncontrado= _appContext.Mecanico.FirstOrDefault(p => p.Id == mecanico.Id);
            if(MecanicoEncontrado!=null)
            MecanicoEncontrado.Nombre=mecanico.Nombre;
        }
    }
}