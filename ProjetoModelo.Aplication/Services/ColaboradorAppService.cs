using PrimeiroModelo.Domain.Entities;
using PrimeiroModelo.Domain.Interfaces.Services;
using ProjetoModeloDDD.Aplication.Commands;
using ProjetoModeloDDD.Aplication.Interfaces;
using ProjetoModeloDDD.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Aplication.Services
{
    public class ColaboradorAppService : IColaboradorApplicationService
    {
        private readonly IColaboradorDomainService _colaboradorDomainService;

        public ColaboradorAppService(IColaboradorDomainService colaboradorService)
        {
            _colaboradorDomainService = colaboradorService;
        }

        public List<ColaboradorViewModel> GetAll()
        {
            List<ColaboradorViewModel> colaboradorViewModels = new List<ColaboradorViewModel>();

            List<Colaborador> listColaboradoresDomain = _colaboradorDomainService.GetAll();


            foreach (Colaborador colaboradorDomain in listColaboradoresDomain)
            {
                ColaboradorViewModel colaboradorViewModel = new ColaboradorViewModel();

                colaboradorViewModel.Id = colaboradorDomain.Id;
                colaboradorViewModel.Nome = colaboradorDomain.Nome;
                colaboradorViewModel.Salario = colaboradorDomain.Salario;
                colaboradorViewModel.Cargo = colaboradorDomain.Cargo;
                colaboradorViewModel.DataAdmissao = colaboradorDomain.DataAdmissao;
                colaboradorViewModel.Departamento = colaboradorDomain.Departamento;
                colaboradorViewModel.Email = colaboradorDomain.Email;
                colaboradorViewModel.Telefone = colaboradorDomain.Telefone;

                colaboradorViewModels.Add(colaboradorViewModel);
            }

            return colaboradorViewModels;
        }

        public void Salvar(ColaboradorCommand colaboradorCommand)
        {
            Colaborador colaborador = new Colaborador();

            colaborador.Nome = colaboradorCommand.Nome;
            colaborador.Cargo = colaboradorCommand.Cargo;
            colaborador.Departamento = colaboradorCommand.Departamento;
            colaborador.DataAdmissao = colaboradorCommand.DataAdmissao;
            colaborador.Salario = colaboradorCommand.Salario;
            colaborador.Email = colaboradorCommand.Email;
            colaborador.Telefone = colaboradorCommand.Telefone;

            _colaboradorDomainService.Salvar(colaborador);
        }
    }
}
