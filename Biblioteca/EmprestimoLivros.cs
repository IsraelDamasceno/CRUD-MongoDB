using System;
using LivrosApi.Models;

namespace LivrosApi.Biblioteca
{
    public class CadastrarLivros
    {
        private Livro _livro;

        public CadastrarLivros(Livro livro)
        {
            _livro = livro;
        }
        public void EL()
        {
            if (string.IsNullOrWhiteSpace (_livro.LivroName))
            {
                throw new Exception("Informe o nome corretamente");
            }

            if (string.IsNullOrWhiteSpace(_livro.Category))
            {
                throw new Exception("Informe a categoria  corretamente");
            }

            if (string.IsNullOrWhiteSpace(_livro.Author))
            {
                throw new Exception("Informe o nome do autor corretamente");
            }

            if (_livro.Price < 0m && _livro.Price == null)
            {
                throw new Exception("Informe o valor corretamente");
            }
        }
    }
}

