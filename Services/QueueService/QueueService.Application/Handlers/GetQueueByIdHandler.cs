using MediatR;
using QueueService.Application.DTOs;
using QueueService.Application.Query;
using QueueService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueService.Application.Handlers
{
    public class GetQueueByIdHandler : IRequestHandler<GetQueueByIdQuery, QueueDTO>
    {
        private readonly IQueueRepository _queueRepository;
        public GetQueueByIdHandler(IQueueRepository queueRepository)
        {
            _queueRepository = queueRepository;
        }
        public async Task<QueueDTO> Handle(GetQueueByIdQuery request, CancellationToken cancellationToken)
        {
            var queue = await _queueRepository.GetById(request.Id);
            if (queue == null)
                return null;

            var dtoQueue = new QueueDTO
            {
                Id = request.Id,
                /// тут нужно проработаь
            };
            return dtoQueue;
        }
    }
}
