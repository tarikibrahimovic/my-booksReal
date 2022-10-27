using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_booksReal.Data.Services;
using my_booksReal.Data.ViewModel;
using my_booksReal.Exceptions;

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
        public IActionResult AddPublisher([FromBody] PublisherVM publisher)
        {
            try
            {
            var newPublisher = _publishersService.AddPublisher(publisher);
            //return Ok();
            return Created(nameof(AddPublisher), newPublisher);
            }
            catch(PublisherNameException ex)
            {
                return BadRequest($"{ex.Message}, Publisher name: {ex.PublisherName})");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("delete-publisher-by-id/{id}")]

        public IActionResult DeletePublisherById(int id)
        {
            try
            {
                int x1 = 1;
                int x2 = 2;
                int resault = x1 / x2;

                _publishersService.DeletePublisherById(id);
                return Ok();
            }
            catch(ArithmeticException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
