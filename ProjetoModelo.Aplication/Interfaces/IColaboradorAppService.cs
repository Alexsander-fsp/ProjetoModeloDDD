using ProjetoModeloDDD.Aplication.ViewModels;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Aplication.Interfaces
{
    public interface IColaboradorAppService
    {
        List<ColaboradorViewModel> GetAll();        
    }
}
