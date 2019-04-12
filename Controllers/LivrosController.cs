using System.Collections.Generic;
using LivrosApi.Models;
using LivrosApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivrosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly LivroService _livroService;

        public LivrosController(LivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpGet]
        public ActionResult<List<Livro>> Get()
        {
            return _livroService.Get();
        }

        [HttpGet("{id:length(24)}", Name = "GetLivro")]
        public ActionResult<Livro> Get(string id)
        {
            var livro = _livroService.Get(id);

            if (livro == null)
            {
                return NotFound();
            }

            return livro;
        }

        [HttpPost]
        public ActionResult<Livro> Create(Livro livro)
        {
            _livroService.Create(livro);

            return CreatedAtRoute("GetLivro", new { id = livro.Id.ToString() }, livro);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Livro livroIn)
        {
            var livro = _livroService.Get(id);

            if (livro == null)
            {
                return NotFound();
            }

            _livroService.Update(id, livroIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var livro = _livroService.Get(id);

            if (livro == null)
            {
                return NotFound();
            }

            _livroService.Remove(livro.Id);

            return NoContent();
        }
    }
}