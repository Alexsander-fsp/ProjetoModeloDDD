using ProjetoModeloDDD.Aplication.Commands;
using ProjetoModeloDDD.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Aplication.Interfaces
{
    public interface IProdutoApplicationService
    {
        void Atualizar(ProdutoCommand produtoCommand); 
        void Excluir(int id);
        List<ProdutoViewModel> GetAll();
        ProdutoCommand GetById(int id);
        ProdutoViewModel GetByIdViewModel(int id);
        void Salvar(ProdutoCommand produtocommand);
    }
}
