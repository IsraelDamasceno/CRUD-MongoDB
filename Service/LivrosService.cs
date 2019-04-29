using System.Collections.Generic;
using System.Linq;
using LivrosApi.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace LivrosApi.Services
{
    public class LivroService : ILivroService
    {
        private readonly IMongoCollection<Livro> _livros;


        public LivroService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("Livros"));
            var database = client.GetDatabase("Livros");
            _livros = database.GetCollection<Livro>("LivrosCadastrados");
        }

        public List<Livro> Get()
        {
            return _livros.Find(livro => true).ToList();
        }

        public Livro Get(string id)
        {
            return _livros.Find<Livro>(livro => livro.Id == id).FirstOrDefault();
        }

        public Livro Create(Livro livro)
        {
            _livros.InsertOne(livro);
            return livro;
        }

        public void Update(string id, Livro livroIn)
        {
            _livros.ReplaceOne(lc => lc.Id == id, livroIn);
        }

        public void Remove(Livro livroIn)
        {
            _livros.DeleteOne(lc => lc.Id == livroIn.Id);
        }

        public void Remove(string id)
        {
            _livros.DeleteOne(lc => lc.Id == id);
        }
    }
}