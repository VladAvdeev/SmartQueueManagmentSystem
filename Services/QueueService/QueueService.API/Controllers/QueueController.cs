using MediatR;
using Microsoft.AspNetCore.Mvc;
using QueueService.Application.Commands;

namespace QueueService.API.Controllers
{
    [ApiController]
    [Route("api/queue")]
    public class QueueController : ControllerBase
    {
        private readonly IMediator _mediator;
        public QueueController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateQueue([FromBody] AddQueueCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetQueueById), id);
            throw new NotImplementedException();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetQueueById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
