using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualMVC.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EFDBContext _context = new EFDBContext();
        public IEnumerable<Entidade.Produto> Produtos
        {
            get { return _context.Produto; }
        }
    }
}
