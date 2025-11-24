using PrimeiroModelo.Domain.Entities;
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
    public class ColaboradorController : Controller
    {
        private readonly IColaboradorApplicationService _colaboradorApplicationService;

        public ColaboradorController()
        {
            ProjetoModeloContext projetoModeloContext = new ProjetoModeloContext();
            IColaboradorInfraDataRepository colaboradorRepository = new ColaboradorRepository(projetoModeloContext);
            IColaboradorDomainService colaboradorService = new ColaboradorDomainService(colaboradorRepository);
            IColaboradorApplicationService colaboradorAppService = new ColaboradorAppService(colaboradorService);

            _colaboradorApplicationService = colaboradorAppService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<ColaboradorViewModel> colaboradores = new List<ColaboradorViewModel>();
            colaboradores = _colaboradorApplicationService.GetAll();

            return View(colaboradores);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ColaboradorCommand colaboradorCommand = new ColaboradorCommand();

            return View(colaboradorCommand);
        }

        [HttpPost]
        public ActionResult Create(ColaboradorCommand colaboradorCommand)
        {
            _colaboradorApplicationService.Salvar(colaboradorCommand);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ColaboradorCommand colaboradorCommand = _colaboradorApplicationService.GetById(id);
            return View(colaboradorCommand);
        }

        [HttpPost]
        public ActionResult Edit(ColaboradorCommand colaboradorCommand)
        {
            try
            {
                _colaboradorApplicationService.Atualizar(colaboradorCommand);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            ColaboradorViewModel colaboradorViewModel = _colaboradorApplicationService.GetByIdViewModel(id);
            return View(colaboradorViewModel);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            ColaboradorCommand colaboradorCommand = _colaboradorApplicationService.GetById(id);
            return View(colaboradorCommand);
        }
        [HttpPost]
        public ActionResult Delete(ColaboradorCommand colaboradorCommand)
        {
            try
            {
                _colaboradorApplicationService.Deletar(colaboradorCommand.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}