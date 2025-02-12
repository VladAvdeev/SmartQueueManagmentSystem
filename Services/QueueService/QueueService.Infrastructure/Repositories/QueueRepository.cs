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

        public Task<int> AddAsync(QueueItem item)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<QueueItem>> GetAllAsync()
        {
            return await _context.QueueItems.ToListAsync();
        }

        public Task<QueueItem> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
