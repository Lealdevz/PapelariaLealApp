using Microsoft.AspNetCore.Mvc.RazorPages;
using PapelariaLealApp.Models;
using PapelariaLealApp.Services;

namespace PapelariaLealApp.Pages.Produtos
{
    public class DetailsModel : PageModel
    {
        private readonly ProdutoService _service;

        public Produto Produto { get; set; }

        public DetailsModel(ProdutoService service)
        {
            _service = service;
        }

        public void OnGet(int id)
        {
            Produto = _service.Listar()
                .FirstOrDefault(p => p.Id == id);
        }
    }
}