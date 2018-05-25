using AutoMapper;
using ProjetoTesteFortes.Application.Interface;
using ProjetoTesteFortes.Domain.Entities;
using ProjetoTesteFortesMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTesteFortesMVC.Controllers
{
    public class PedidosController : Controller
    {

        // GET: Pedidos
        private readonly IPedidoAppService _pedidoApp;
        private readonly IProdutoAppService _produtoApp;

        public PedidosController(IPedidoAppService pedidoApp, IProdutoAppService produtoApp)
        {
            _pedidoApp = pedidoApp;
            _produtoApp = produtoApp;
        }

        // GET: Pedidos
        public ActionResult Index()
        {
            var pedidoViewModel = Mapper.Map<IEnumerable<Pedido>, IEnumerable<PedidoViewModel>>(_pedidoApp.GetAll());

            return View(pedidoViewModel);
        }

        // GET: Pedidos/Details/5
        public ActionResult Details(int id)
        {
            var pedido = _pedidoApp.GetById(id);
            var pedidoViewModel = Mapper.Map<Pedido, PedidoViewModel>(pedido);

            return View(pedidoViewModel);
        }

        // GET: Pedidoss/Create
        public ActionResult Create()
        {
            ViewBag.ProdutoId = new SelectList(_produtoApp.GetAll(), "ProdutoId", "Descricao");
            return View();
        }

        // POST: Pedidos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PedidoViewModel pedido)
        {
            if (ModelState.IsValid)
            {
                var pedidoDomain = Mapper.Map<PedidoViewModel, Pedido>(pedido);
                _pedidoApp.Add(pedidoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.PedidoId = new SelectList(_produtoApp.GetAll(), "ProdutoId", "Descricao", pedido.ProdutoId);
            return View(pedido);
        }

        // GET: Pedidos/Edit/5
        public ActionResult Edit(int id)
        {
            var pedido = _pedidoApp.GetById(id);
            var pedidoViewModel = Mapper.Map<Pedido, PedidoViewModel>(pedido);

            ViewBag.PedidoId = new SelectList(_pedidoApp.GetAll(), "ProdutoId", "Descricao", pedidoViewModel.ProdutoId);

            return View(pedidoViewModel);
        }

        // POST: Pedidos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PedidoViewModel pedido)
        {
            if (ModelState.IsValid)
            {
                var pedidoDomain = Mapper.Map<PedidoViewModel, Pedido>(pedido);

                return RedirectToAction("Index");
            }
          ViewBag.ProdutoId = new SelectList(_produtoApp.GetAll(), "ProdutoId", "Descricao", pedido.ProdutoId);
            return View(pedido);
        }

        // GET: Pedidos/Delete/5
        public ActionResult Delete(int id)
        {
            var pedido = _pedidoApp.GetById(id);
            var pedidoViewModel = Mapper.Map<Pedido, PedidoViewModel>(pedido);

            return View(pedidoViewModel);
        }

        // POST: Fornecedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var pedido = _pedidoApp.GetById(id);
            _pedidoApp.Remove(pedido);

            return RedirectToAction("Index");
        }
    }
}