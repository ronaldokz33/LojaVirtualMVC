using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaVirtualMVC.Entidade;
namespace LojaVirtualMVC.WEB.Models
{
    public class ProdutosViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }
        public Paginacao Paginacao { get; set; }


    }
}