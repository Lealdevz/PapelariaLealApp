using PapelariaLealApp.Models;

namespace PapelariaLealApp.Services;

public class ProdutoService : IProdutoService
{
    private static List<Produto> produtos = new List<Produto>()
    {
        new Produto { Id = 1, Nome = "Caderno 10 Matérias Preto", Preco = 22, ImagemUrl = "/images/caderno10materiaspreto.jpg", Descricao = "Caderno com capa preta e divisão para 10 matérias, ideal para organizar anotações escolares ou do trabalho. Conta com folhas pautadas e espiral resistente, oferecendo praticidade e durabilidade no uso diário."},
        new Produto { Id = 2, Nome = "Mochila Preta Lisa", Preco = 100, ImagemUrl = "/images/mochilapretalisa.jpg", Descricao = "Mochila prática e versátil, ideal para o dia a dia. Possui design simples na cor preta, amplo espaço interno e alças ajustáveis para maior conforto. Perfeita para escola, trabalho ou passeios."},
        new Produto { Id = 3, Nome = "Lapis de cor 12 cores", Preco = 10, ImagemUrl = "/images/lapisdecor12cores.png", Descricao = "Caixa com 12 lápis de cor em tons variados, ideal para desenhos, trabalhos escolares e atividades criativas. Possui cores vivas e traço macio, proporcionando uma pintura mais uniforme e divertida."},
        new Produto { Id = 4, Nome = "Lapiseira 0.7 preta", Preco = 15, ImagemUrl = "/images/lapiseira07preta.jpg", Descricao = "Lapiseira com corpo na cor preta e ponta 0.7 mm, ideal para escrita e desenhos com maior precisão. Possui design confortável e leve, proporcionando praticidade para o uso diário em estudos, trabalho ou atividades escolares."}
    };

    public List<Produto> Listar()
    {
        return produtos;
    }
}