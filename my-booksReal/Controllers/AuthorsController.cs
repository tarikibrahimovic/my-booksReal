using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_booksReal.Data.Services;
using my_booksReal.Data.ViewModel;

namespace my_booksReal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private AuthorsService _authorsService;
        public AuthorsController(AuthorsService authorsService)
        {
            _authorsService = authorsService;
        }

        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            _authorsService.AddAuthor(author);
            return Ok();
        }
    }
}
