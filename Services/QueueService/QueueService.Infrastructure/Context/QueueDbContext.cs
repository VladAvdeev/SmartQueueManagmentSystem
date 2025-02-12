using Microsoft.EntityFrameworkCore;
using QueueService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueService.Infrastructure.Context
{
    public class QueueDbContext : DbContext
    {
        public DbSet<QueueItem> QueueItems { get; set; }
        public QueueDbContext(DbContextOptions<QueueDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
