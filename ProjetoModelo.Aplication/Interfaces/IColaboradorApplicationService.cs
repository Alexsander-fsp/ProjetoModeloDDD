using ProjetoModeloDDD.Aplication.Commands;
using ProjetoModeloDDD.Aplication.ViewModels;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Aplication.Interfaces
{
    public interface IColaboradorApplicationService
    {
        List<ColaboradorViewModel> GetAll();
        void Salvar(ColaboradorCommand colaboradorCommand);
    }
}
