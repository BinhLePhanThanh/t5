using Microsoft.AspNetCore.Mvc;
using MIS.Entity;
using MIS.Service;

namespace MIS.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorService _authorService;

        public AuthorController(AuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IActionResult GetAllAuthors()
        {
            List<Author> authors = _authorService.GetAllAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthorById(int id)
        {
            Author author = _authorService.GetAuthorById(id);
            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }

        [HttpPost]
        public IActionResult AddAuthor(Author author)
        {
            _authorService.AddAuthor(author);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAuthor(int id, Author updatedAuthor)
        {
            if (id != updatedAuthor.Id)
            {
                return BadRequest();
            }

            var author = _authorService.GetAuthorById(id);

            if (author == null)
            {
                return NotFound();
            }

            // Ánh xạ các thuộc tính từ updatedAuthor vào author
            author.Name = updatedAuthor.Name ?? author.Name;
            author.BirthDate = updatedAuthor.BirthDate ?? author.BirthDate;
            author.Address = updatedAuthor.Address ?? author.Address;
            author.Genre = updatedAuthor.Genre ?? author.Genre;
            author.Status = updatedAuthor.Status ?? author.Status;

            _authorService.UpdateAuthor(author);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            _authorService.DeleteAuthor(id);
            return Ok();
        }
        [HttpGet("search")]
        public IActionResult SearchAuthorsByName(string namePart)
        {
            List<Author> authors = _authorService.SearchAuthorsByName(namePart);
            return Ok(authors);
        }
    }
}
