using MediatR;
using QueueService.Application.Abstractions;
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
    public class CreateQueueCommandHandler : IRequestHandler<CreateQueueCommand, Result<Guid>>
    {
        private readonly IQueueRepository _queueRepository;
        public CreateQueueCommandHandler(IQueueRepository queueRepository)
        {
            _queueRepository = queueRepository;
        }
        public async Task<Result<Guid>> Handle(CreateQueueCommand request, CancellationToken cancellationToken)
        {
            var newQueue = new QueueItem
            {
                // допустим что id генерируются в БД 
                Name = request.Name,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Status = Domain.Enum.QueueStatus.Active,

                // TODO доделать
            };
            await _queueRepository.AddAsync(newQueue, cancellationToken);

            // Предполагаем, что после вызова SaveChangesAsync в репозитории
            // EF Core автоматически обновит свойство Id
            // пока так, там посмотрим
            return Result<Guid>.Success(newQueue.Id);
        }

    }
}
