using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaVirtualMVC;
namespace LojaVirtualMVC.WEB.Models
{
    public class ProdutosController : Controller
    {
        private Repositorio.ProdutosRepositorio _repositorio;
        //
        // GET: /Produtos/
        public ActionResult Index()
        {
            _repositorio = new Repositorio.ProdutosRepositorio();
            var produto = _repositorio.Produtos.Take(10);
            return View(produto);
        }
	}
}