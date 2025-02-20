using MediatR;
using Microsoft.AspNetCore.Mvc;
using QueueService.Application.Abstractions;
using QueueService.Application.Commands;
using QueueService.Application.DTOs;
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
            Result<int> result = await _mediator.Send(command);
            if (result.IsSuccess)
            {
                return CreatedAtAction(nameof(GetQueueById), new {id = result.Value}, result.Value);
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQueueById(int id)
        {
            var query = new GetQueueByIdQuery { Id = id };
            Result<QueueDTO> result = await _mediator.Send(query);
            if (result.IsSuccess)
                return Ok(result.Value);

            else
                return NotFound(result.ErrorMessage);
        }
    }
}
