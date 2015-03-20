using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaVirtualMVC.Repositorio;
namespace LojaVirtualMVC.WEB.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 3;
        //
        // GET: /Vitrine/
        public ActionResult ListaProdutos(int Pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos
                .OrderBy(p => p.Descricao)
            .Skip((Pagina - 1) * ProdutosPorPagina)
            .Take(ProdutosPorPagina);

            return View(produtos);
        }
	}
}