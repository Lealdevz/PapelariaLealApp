using Microsoft.AspNetCore.Mvc.RazorPages;
using PapelariaLealApp.Models;
using PapelariaLealApp.Services;

namespace PapelariaLealApp.Pages
{
    public class ProdutosModel : PageModel
    {
        private readonly ProdutoService _service;

        public List<Produto> Produtos { get; set; }

        public ProdutosModel(ProdutoService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            Produtos = _service.Listar();
        }
    }
}