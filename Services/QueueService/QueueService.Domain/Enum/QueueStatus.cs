using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueService.Domain.Enum
{
    // статус очереди
    public enum QueueStatus
    {
        Active,
        Waiting,
        Closed
    }
}
