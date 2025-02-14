using QueueService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueService.Domain.Interfaces
{
    public interface IQueueRepository
    {
        Task<IEnumerable<QueueItem>> GetAllAsync();
        Task<QueueItem?> GetById(int id);
        Task<int> AddAsync(QueueItem item);
    }
}
