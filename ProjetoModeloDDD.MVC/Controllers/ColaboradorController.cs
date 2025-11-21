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
        private readonly IColaboradorAppService _colaboradorAppService;

        public ColaboradorController()
        {
            ProjetoModeloContext projetoModeloContext = new ProjetoModeloContext();
            IColaboradorRepository colaboradorRepository = new ColaboradorRepository(projetoModeloContext);
            IColaboradorService colaboradorService = new ColaboradorService(colaboradorRepository);
            IColaboradorAppService colaboradorAppService = new ColaboradorAppService(colaboradorService);

            _colaboradorAppService = colaboradorAppService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<ColaboradorViewModel> colaboradores = new List<ColaboradorViewModel>();
            colaboradores = _colaboradorAppService.GetAll();
           
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

            return RedirectToAction("Index");
        }
    }
}