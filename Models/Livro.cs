using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LivrosApi.Models
{
    public class Livro
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string LivroName { get; set; }

        [BsonElement("Price")]
        public decimal Price { get; set; }

        [BsonElement("Category")]
        public string Category { get; set; }

        [BsonElement("Author")]
        public string Author { get; set; }

        public Livro(string id, string livroName,  decimal price, string category, string author )
        {
            id = Id;
            livroName = LivroName;
            price = Price;
            category = Category;
            author = Author;
        }
        public Livro()
        {

        }
    }
}