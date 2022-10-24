using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_booksReal.Data.Services;
using my_booksReal.Data.ViewModel;

namespace my_booksReal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private PublishersService _publishersService;
        public PublishersController(PublishersService publisherService)
        {
            _publishersService = publisherService;
        }

        [HttpPost("add-publisher")]
        public IActionResult AddAuthor([FromBody] PublisherVM publisher)
        {
            _publishersService.AddPublisher(publisher);
            return Ok();
        }
    }
}
