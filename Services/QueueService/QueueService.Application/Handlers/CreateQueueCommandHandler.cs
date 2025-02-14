using MediatR;
using QueueService.Application.Commands;
using QueueService.Domain.Entities;
using QueueService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueService.Application.Handlers
{
    /// <summary>
    /// Хендлер команды
    /// </summary>
    public class CreateQueueCommandHandler : IRequestHandler<CreateQueueCommand, int>
    {
        private readonly IQueueRepository _queueRepository;
        public CreateQueueCommandHandler(IQueueRepository queueRepository)
        {
            _queueRepository = queueRepository;
        }
        public async Task<int> Handle(CreateQueueCommand request, CancellationToken cancellationToken)
        {
            return await _queueRepository.AddAsync(new QueueItem 
            {   Id = request.Id, 
                Name = request.Name, 
                CreatedAt = request.CreatedAt
            });
        }
    }
}
