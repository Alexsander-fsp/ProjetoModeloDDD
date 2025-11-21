using PrimeiroModelo.Domain.Entities;
using PrimeiroModelo.Domain.Interfaces.Services;
using ProjetoModeloDDD.Aplication.Interfaces;
using ProjetoModeloDDD.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Aplication.Services
{
    public class ColaboradorAppService : IColaboradorAppService
    {
        private readonly IColaboradorService _colaboradorService;

        public ColaboradorAppService(IColaboradorService colaboradorService)
        {
            _colaboradorService = colaboradorService;
        }

        public List<ColaboradorViewModel> GetAll()
        {
            List<ColaboradorViewModel> colaboradorViewModels = new List<ColaboradorViewModel>();

            List<Colaborador> listColaboradoresDomain = _colaboradorService.GetAll();


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
    }
}
