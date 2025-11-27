using ProjetoModeloDDD.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeiroModelo.Domain.Interfaces.Services;
using ProjetoModeloDDD.Aplication.ViewModels;
using PrimeiroModelo.Domain.Entities;
using ProjetoModeloDDD.Aplication.Commands;

namespace ProjetoModeloDDD.Aplication.Services
{
    public class ProdutoAppService : IProdutoApplicationService
    {
        private readonly IProdutoDomainService _produtoDomainService;

        public ProdutoAppService(IProdutoDomainService produtoDomainService)
        {
            _produtoDomainService = produtoDomainService;
        }

        public void Atualizar(ProdutoCommand produtoCommand)
        {
            _produtoDomainService.Atualizar(new Produto
            {
                Id = produtoCommand.Id,
                Nome = produtoCommand.Nome,
                Valor = produtoCommand.Valor,
                Disponivel = produtoCommand.Disponivel,
                ClienteProduto = produtoCommand.ClienteProduto,
            });
        }

        public void Excluir(int id)
        {
            _produtoDomainService.Excluir(id);
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

        public ProdutoCommand GetById(int id)
        {
            var produto = _produtoDomainService.GetById(id);
            ProdutoCommand produtoCommand = new ProdutoCommand()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor,
                Disponivel = produto.Disponivel,
                ClienteProduto = produto.ClienteProduto,
            };
            return produtoCommand;
        }

        public ProdutoViewModel GetByIdViewModel(int id)
        {            
            var produto = _produtoDomainService.GetById(id);
            ProdutoViewModel produtoViewModel = new ProdutoViewModel()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor,
                Disponivel = produto.Disponivel,
                ClienteProduto = produto.ClienteProduto,
            };
            return(produtoViewModel);
        }

        public void Salvar(ProdutoCommand produtocommand)
        {
            Produto produto = new Produto()
            {
                Nome = produtocommand.Nome,
                Valor = produtocommand.Valor,
                Disponivel = produtocommand.Disponivel,
                ClienteProduto = produtocommand.ClienteProduto,
            };
            _produtoDomainService.Add(produto);
        }
    }
}
