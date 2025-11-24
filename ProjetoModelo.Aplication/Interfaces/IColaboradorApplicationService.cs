using ProjetoModeloDDD.Aplication.Commands;
using ProjetoModeloDDD.Aplication.ViewModels;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Aplication.Interfaces
{
    public interface IColaboradorApplicationService
    {
        void Atualizar(ColaboradorCommand colaboradorCommand);
        void Deletar(int id);
        List<ColaboradorViewModel> GetAll();
        ColaboradorCommand GetById(int id);
        ColaboradorViewModel GetByIdViewModel(int id);
        void Salvar(ColaboradorCommand colaboradorCommand);
    }
}
