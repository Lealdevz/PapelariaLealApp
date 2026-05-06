using PapelariaLealApp.Models;

namespace PapelariaLealApp.Services;

public class ProdutoService
{
    private static List<Produto> produtos = new List<Produto>()
    {
        new Produto { Id = 1, Nome = "Caderno 10 Matérias Preto", Preco = 22, ImagemUrl = "/images/caderno10materiaspreto.jpg"},
        new Produto { Id = 2, Nome = "Mochila Preta Lisa", Preco = 100, ImagemUrl = "/images/mochilapretalisa.jpg"},
    };

    public List<Produto> Listar()
    {
        return produtos;
    }
}