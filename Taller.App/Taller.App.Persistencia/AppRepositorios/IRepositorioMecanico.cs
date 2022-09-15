using System.Collections.Generic;
using Taller.App.Dominio;

namespace Taller.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMecanico   
     {
        IEnumerable<Mecanico> GetAllMecanico();
        
        Mecanico AddMecanico(Mecanico mecanico);
        Mecanico UpdateMecanico(Mecanico mecanico);
        void DeleteMecanico(int IdMecanico);
        Mecanico GetMecanico(int IdMecanico);
    }
}