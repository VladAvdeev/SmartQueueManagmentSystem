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
        Task<IEnumerable<QueueItem>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<QueueItem?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task AddAsync(QueueItem item, CancellationToken cancellationToken = default);
        Task UpdateAsync(QueueItem queue, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}
