using MassTransit;
using QueueService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueService.Infrastructure.MessageBroker
{
    public class QueueEventPublisher
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public QueueEventPublisher(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        public async Task PublishQueueCreatedEvent(QueueItem queueItem)
        {
            await _publishEndpoint.Publish(new QueueCreatedEvent
            {

            });
        }
    }
}
