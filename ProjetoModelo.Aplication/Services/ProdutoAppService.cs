using ProjetoModeloDDD.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeiroModelo.Domain.Interfaces.Services;
using ProjetoModeloDDD.Aplication.ViewModels;
using PrimeiroModelo.Domain.Entities;

namespace ProjetoModeloDDD.Aplication.Services
{
    public class ProdutoAppService : IProdutoApplicationService
    {
        private readonly IProdutoDomainService _produtoDomainService;

        public ProdutoAppService(IProdutoDomainService produtoDomainService)
        {
            _produtoDomainService = produtoDomainService;
        }

        public List<ProdutoViewModel> GetAll()
        {
            List<ProdutoViewModel> produtosViewModel = new List<ProdutoViewModel>();
            List<Produto> produtosDomain = _produtoDomainService.GetAll();
            foreach (var produto in produtosDomain)
            {
                produtosViewModel.Add(new ProdutoViewModel
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    Valor = produto.Valor,
                    Disponivel = produto.Disponivel,
                    ClienteProduto = produto.ClienteProduto,
                });

            }
            return produtosViewModel;
        }
    }
}
