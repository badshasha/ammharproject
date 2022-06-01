using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using simpleproject.app.data.ProgrameInterface;

namespace simpleproject.app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherRepo _service;

        public PublisherController(IPublisherRepo service)
        {
            this._service = service;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll() { 
            return Ok(this._service.GetAll());
        }

        [HttpGet("get/{id}")]
        public IActionResult Get(int id) {
            return Ok(this._service.Get(id));
        }   
        

    }
}
