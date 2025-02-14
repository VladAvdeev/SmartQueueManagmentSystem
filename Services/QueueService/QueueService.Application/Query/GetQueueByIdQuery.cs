using MediatR;
using QueueService.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueService.Application.Query
{
    public class GetQueueByIdQuery : IRequest<QueueDTO>
    {
        public int Id { get; set; }
    }
}
