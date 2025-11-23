using ProjetoModeloDDD.Aplication.Commands;
using ProjetoModeloDDD.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Aplication.Interfaces
{
    public interface IFornecedorApplicationService
    {
        List<FornecedorViewModel> GetAll();
        void Salvar(FornecedorCommand fornecedorCommand);
        FornecedorCommand GetById(int id);
        void Atualizar(FornecedorCommand fornecedorCommand);
        void Excluir(int id);
        FornecedorViewModel GetByIdViewModel(int id);
    }
}
