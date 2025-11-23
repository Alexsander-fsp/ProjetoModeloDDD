using PrimeiroModelo.Domain.Interfaces.Repositories;
using PrimeiroModelo.Domain.Interfaces.Services;
using PrimeiroModelo.Domain.Services;
using ProjetoModelo.Infra.Data.Context;
using ProjetoModelo.Infra.Data.Repositories;
using ProjetoModeloDDD.Aplication.Commands;
using ProjetoModeloDDD.Aplication.Interfaces;
using ProjetoModeloDDD.Aplication.Services;
using ProjetoModeloDDD.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly IFornecedorApplicationService _fornecedorApplicationService;

        public FornecedorController()
        {
            ProjetoModeloContext projetoModeloContext = new ProjetoModeloContext();
            IFornecedorInfraDataRepository fornecedorRepository = new FornecedorRepository(projetoModeloContext);
            IFornecedorDomainService fornecedorService = new FornecedorDomainService(fornecedorRepository);
            IFornecedorApplicationService fornecedorApplicationService = new FornecedorAppService(fornecedorService);
            _fornecedorApplicationService = fornecedorApplicationService;

        }

        // GET: Fornecedor
        public ActionResult Index()
        {
            List<FornecedorViewModel> fornecedores = new List<FornecedorViewModel>();
            fornecedores = _fornecedorApplicationService.GetAll();
            return View(fornecedores);
        }

        // GET: Fornecedor/Details/5
        public ActionResult Details(int id)
        {
            FornecedorViewModel fornecedorViewModel = _fornecedorApplicationService.GetByIdViewModel(id);

            return View(fornecedorViewModel);
        }

        // GET: Fornecedor/Create
        public ActionResult Create()
        {
            FornecedorCommand fornecedorCommand = new FornecedorCommand();

            return View(fornecedorCommand);
        }

        // POST: Fornecedor/Create
        [HttpPost]
        public ActionResult Create(FornecedorCommand fornecedorCommand)
        {
            _fornecedorApplicationService.Salvar(fornecedorCommand);
            return RedirectToAction("Index");
        }

        // GET: Fornecedor/Edit/5
        public ActionResult Edit(int id)
        {
            FornecedorCommand fornecedorCommand = _fornecedorApplicationService.GetById(id);

            return View(fornecedorCommand);
        }

        // POST: Fornecedor/Edit/5
        [HttpPost]
        public ActionResult Edit(FornecedorCommand fornecedorCommand)
        {
            try
            {
                _fornecedorApplicationService.Atualizar(fornecedorCommand);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Fornecedor/Delete/5
        public ActionResult Delete(int id)
        {
            FornecedorCommand fornecedorCommand = _fornecedorApplicationService.GetById(id);

            return View(fornecedorCommand);
        }

        // POST: Fornecedor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FornecedorCommand fornecedorCommand)
        {
            try
            {
                _fornecedorApplicationService.Excluir(fornecedorCommand.Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
