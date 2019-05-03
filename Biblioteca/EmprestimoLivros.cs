namespace LivrosApi.Biblioteca
{
    public class EmprestimoLivros
    {
        public string Emprestareilivro(string resposta)
        {
            return "OK";
        }
        public string Disponivel(bool disponivel)
        {

            if (disponivel == true)
            {
                return "OK";
            }
            else
            {
                return "Falta Livro";
            }

        }
        public string Emprestarlivroagora(bool disponivel)
        {

            if (disponivel == true)
            {
                return "OK";
            }
            else
            {
                return "Falta Livro";
            }
        }

    }
}

