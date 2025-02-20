using Microsoft.EntityFrameworkCore;
using QueueService.Domain.Entities;
using QueueService.Domain.Interfaces;
using QueueService.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueService.Infrastructure.Repositories
{
    public class QueueRepository : IQueueRepository
    {
        private readonly QueueDbContext _context;
        public QueueRepository(QueueDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(QueueItem item, CancellationToken cancellationToken = default)
        {
            await _context.QueueItems.AddAsync(item, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var queue = await _context.QueueItems.FindAsync([id], cancellationToken);
            if(queue != null)
            {
                _context.QueueItems.Remove(queue);
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<QueueItem>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _context.QueueItems.ToListAsync(cancellationToken);
        }

        public async Task<QueueItem?> GetByIdAsync(int id, CancellationToken cancellationToken =default)
        {
            return await _context.QueueItems.FindAsync([id], cancellationToken);
        }

        public async Task UpdateAsync(QueueItem queue, CancellationToken cancellationToken = default)
        {
            _context.QueueItems.Update(queue);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
