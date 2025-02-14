using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueService.Infrastructure.Cache
{
    public class QueueCacheService
    {
        private readonly IDistributedCache _cache;

        public QueueCacheService(IDistributedCache cache)
        {
            _cache = cache;
        }

        /// работа с кэшом
    }
}
