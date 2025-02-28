using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            modelBuilder.Entity<QueueItem>();
            base.OnModelCreating(modelBuilder);
        }

        public class QueueConfiguration : IEntityTypeConfiguration<QueueItem>
        {
            public void Configure(EntityTypeBuilder<QueueItem> builder)
            {
                builder.ToTable("queue_item", "public");
                builder.Property(p => p.Id).HasColumnName("id");
                builder.Property(p => p.Name).HasColumnName("queue_name");
                builder.Property(p => p.NextTicketNumber).HasColumnName("next_tickect_number");
                builder.Property(p => p.CurrentNumber).HasColumnName("current_number");
                builder.Property(p => p.Capacity).HasColumnName("capacity");
                builder.Property(p => p.CreatedAt).HasColumnName("created_at").HasDefaultValueSql();
                builder.Property(p => p.UpdatedAt).HasColumnName("updatedAt").HasDefaultValueSql();
                builder.Property(p => p.AverageWaitTimeInMinutes).HasColumnName("average_time");
                builder.Property(p => p.ServiceCounterId).HasColumnName("service_id");
            }
        }
    }
}
