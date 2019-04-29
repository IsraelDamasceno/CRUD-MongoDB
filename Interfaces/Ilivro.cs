namespace LivrosApi.Models
{
    public interface ILivro
    {
        string Author { get; set; }
        string Category { get; set; }
        string Id { get; set; }
        string LivroName { get; set; }
        decimal Price { get; set; }

        Livro GetType(Livro livro);
    }
}