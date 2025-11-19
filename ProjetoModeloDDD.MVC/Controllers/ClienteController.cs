using AutoMapper;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Infra.Data.Context;
using ProjetoModelo.Infra.Data.Repositories;
using ProjetoModeloDDD.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteController()
        {
            ProjetoModeloContext projetoModeloContext = new ProjetoModeloContext();
            _clienteRepository = new ClienteRepository(projetoModeloContext);                
        }

        // GET: Client
        public ActionResult Index()
        {

            var listaCliente = _clienteRepository.GetAll().ToList();
            var clienteViewModel = MvcApplication.AutoMapperConfig.Map<List<ClienteViewModel>>(listaCliente);            
            
            return View(clienteViewModel);
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Client/Create
        public ActionResult Create()  
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = MvcApplication.AutoMapperConfig.Map<Cliente>(clienteViewModel);

                _clienteRepository.Add(clienteDomain);

                return RedirectToAction("Index");
            }

            else
            {
                return View(clienteViewModel); 
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
