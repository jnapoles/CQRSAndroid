using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IMediator Mediator;

        public MessageController(IMediator mediator) =>
            Mediator = mediator;

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await Mediator.Send(new Ping()));
        }

        
    }
}
