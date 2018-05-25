using AutoMapper;
using ProjetoTesteFortes.Application.Interface;
using ProjetoTesteFortes.Domain.Entities;
using ProjetoTesteFortes.Domain.Interfaces.Services;
using ProjetoTesteFortesMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTesteFortesMVC.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produto
        private readonly IProdutoAppService _produtoApp;
        private readonly IFornecedorService _fornecedorApp;
        
        public ProdutosController(IProdutoAppService produtoApp, IFornecedorService fornecedorApp)
        {
            _produtoApp = produtoApp;
            _fornecedorApp = fornecedorApp;
            
        }


        // GET: Produto
        public ActionResult Index()
        {
            var produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoApp.GetAll());

            return View(produtoViewModel);
        }

        //GET: Produto/Details/5 
        public ActionResult Details(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        //GET: Produto/Create
        public ActionResult Create()
        {
            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "RazaoSocial");
            return View();

        }

        //POST: Produto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produto)
        {
            if(ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoApp.Add(produtoDomain);

                return RedirectToAction("Index");
            }

            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "RazaoSocial", produto.FornecedorId);
            return View(produto);
        }

        //GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "RazaoSocial", produtoViewModel.FornecedorId);

            return View(produtoViewModel);
        }
        //POST: Produto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoApp.Update(produtoDomain);

                return RedirectToAction("Index");
            }

            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "RazaoSocial", produto.FornecedorId);
            return View(produto);

        }

        //GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            

            return View(produtoViewModel);
        }

        //POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var produto = _produtoApp.GetById(id);
            _produtoApp.Remove(produto);

            return RedirectToAction("Index");
        }



    }
}