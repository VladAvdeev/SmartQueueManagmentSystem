using MediatR;
using Microsoft.AspNetCore.Mvc;
using QueueService.Application.Commands;
using QueueService.Application.Query;
using QueueService.Domain.Entities;

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
        [ProducesResponseType(typeof(QueueItem), StatusCodes.Status201Created)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateQueue([FromBody] CreateQueueCommand command, CancellationToken cancellationToken = default)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetQueueById), id);
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQueueById(int id)
        {
            var query = new GetQueueByIdQuery { Id = id };
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
