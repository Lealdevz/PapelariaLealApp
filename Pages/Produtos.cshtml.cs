using Microsoft.AspNetCore.Mvc.RazorPages;
using PapelariaLealApp.Models;
using PapelariaLealApp.Services;

namespace PapelariaLealApp.Pages
{
    public class ProdutosModel : PageModel
    {
        private readonly IProdutoService _service;

        public List<Produto> Produtos { get; set; }

        public ProdutosModel(IProdutoService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            Produtos = _service.Listar();
        }
    }
}