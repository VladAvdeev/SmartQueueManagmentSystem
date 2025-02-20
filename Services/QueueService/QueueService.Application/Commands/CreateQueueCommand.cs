using MediatR;
using QueueService.Application.Abstractions;
using QueueService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueService.Application.Commands
{
    /// <summary>
    /// Команда, которая содержит модель
    /// </summary>
    public class CreateQueueCommand : IBaseCommand<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } 
    }
}
