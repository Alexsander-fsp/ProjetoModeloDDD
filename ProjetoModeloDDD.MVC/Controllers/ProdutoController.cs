using PrimeiroModelo.Domain.Entities;
using PrimeiroModelo.Domain.Interfaces.Repositories;
using PrimeiroModelo.Domain.Interfaces.Services;
using PrimeiroModelo.Domain.Services;
using ProjetoModelo.Infra.Data.Context;
using ProjetoModelo.Infra.Data.Repositories;
using ProjetoModeloDDD.Aplication.Interfaces;
using ProjetoModeloDDD.Aplication.Services;
using ProjetoModeloDDD.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoApplicationService _produtoApplicationService;

        public ProdutoController()
        {
            ProjetoModeloContext projetoModeloContext = new ProjetoModeloContext();
            IProdutoInfraDataRepository produtoRepository = new ProdutoRepository(projetoModeloContext);
            IProdutoDomainService produtoService = new ProdutoDomainService(produtoRepository);
            _produtoApplicationService = new ProdutoAppService(produtoService);
        }

        // GET: Produto
        public ActionResult Index()
        {
            List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();
            produtos = _produtoApplicationService.GetAll();
            return View(produtos);
        }
    }
}