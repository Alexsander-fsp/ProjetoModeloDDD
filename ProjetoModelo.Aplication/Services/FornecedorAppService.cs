using ProjetoModeloDDD.Aplication.Interfaces;
using ProjetoModeloDDD.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeiroModelo.Domain.Interfaces.Services;
using PrimeiroModelo.Domain.Entities;
using ProjetoModeloDDD.Aplication.Commands;

namespace ProjetoModeloDDD.Aplication.Services
{
    public class FornecedorAppService : IFornecedorApplicationService
    {
        private readonly IFornecedorDomainService _fornecedorDomainService;

        public FornecedorAppService(IFornecedorDomainService fornecedorDomainService)
        {
            _fornecedorDomainService = fornecedorDomainService;
        }

        public List<FornecedorViewModel> GetAll()
        {
            List<FornecedorViewModel> fornecedorViewModel = new List<FornecedorViewModel>();
            List<Fornecedor> listFornecedoresDomain = _fornecedorDomainService.GetAll();

            foreach (var fornecedor in listFornecedoresDomain)
            {
                fornecedorViewModel.Add(new FornecedorViewModel
                {
                    Id = fornecedor.Id,
                    Nome = fornecedor.Nome,
                    CNPJ = fornecedor.CNPJ,
                    Telefone = fornecedor.Telefone,
                    Email = fornecedor.Email,
                    Endereco = fornecedor.Endereco,
                });
            }

            return fornecedorViewModel;
        }

        public void Salvar(FornecedorCommand fornecedorCommand)
        {
            Fornecedor fornecedor = new Fornecedor
            {
                Nome = fornecedorCommand.Nome,
                CNPJ = fornecedorCommand.CNPJ,
                Telefone = fornecedorCommand.Telefone,
                Email = fornecedorCommand.Email,
                Endereco = fornecedorCommand.Endereco,
            };
            _fornecedorDomainService.Salvar(fornecedor);
        }

        public FornecedorCommand GetById(int id)
        {
            var fornecedor = _fornecedorDomainService.GetById(id);

            FornecedorCommand fornecedorCommand = new FornecedorCommand
            {
                Id = fornecedor.Id,
                Nome = fornecedor.Nome,
                CNPJ = fornecedor.CNPJ,
                Telefone = fornecedor.Telefone,
                Email = fornecedor.Email,
                Endereco = fornecedor.Endereco,
            };

            return fornecedorCommand;
        }

        public void Atualizar(FornecedorCommand fornecedorCommand)
        {
            Fornecedor fornecedor = new Fornecedor
            {
                Id = fornecedorCommand.Id,
                Nome = fornecedorCommand.Nome,
                CNPJ = fornecedorCommand.CNPJ,
                Telefone = fornecedorCommand.Telefone,
                Email = fornecedorCommand.Email,
                Endereco = fornecedorCommand.Endereco,
            };

            _fornecedorDomainService.Atualizar(fornecedor);
        }

        public void Excluir(int id)
        {
            _fornecedorDomainService.Excluir(id);
        }

        public FornecedorViewModel GetByIdViewModel(int id)
        {
            var EntityDornecedor = _fornecedorDomainService.GetById(id);

            FornecedorViewModel fornecedorViewModel1 = new FornecedorViewModel
            {
                Id = EntityDornecedor.Id,
                Nome = EntityDornecedor.Nome,
                CNPJ = EntityDornecedor.CNPJ,
                Telefone = EntityDornecedor.Telefone,
                Email = EntityDornecedor.Email,
                Endereco = EntityDornecedor.Endereco,
            };

            return fornecedorViewModel1;
        }
    }
}
