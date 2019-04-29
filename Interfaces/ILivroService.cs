using System.Collections.Generic;
using LivrosApi.Models;

namespace LivrosApi.Services
{
    public interface ILivroService
    {
        Livro Create(Livro livro);
        List<Livro> Get();
        Livro Get(string id);
        void Remove(Livro livroIn);
        void Remove(string id);
        void Update(string id, Livro livroIn);
    }
}