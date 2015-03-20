using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using LojaVirtualMVC.WEB.Models;
namespace LojaVirtualMVC.WEB.HtmlHelpers
{
    public static class PaginacaoHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginacao, Func<int,string> paginaUrl)
        {
            StringBuilder resultado = new StringBuilder();
            for (int i = 0; i < paginacao.TotalPagina; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", paginaUrl(i));
                tag.InnerHtml = i.ToString();
                
                tag.AddCssClass("btn btn-default");
                if(i == paginacao.PaginaAtual)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn btn-primary");
                }
                resultado.Append(tag);
                
            }
            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}