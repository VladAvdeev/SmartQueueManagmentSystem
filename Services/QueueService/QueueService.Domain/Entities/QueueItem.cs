using QueueService.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QueueService.Domain.Entities
{
    public class QueueItem
    {
        // Уникальный идентификатор очереди
        public Guid Id { get; set; }
        
        // название очереди в идея пока в формате "Окно 1", "Отдел продаж"
        public string Name { get; set; }
        
        // максимальная вместимость очереди (сколько макс клиентом может быть в очереди)
        public int Capacity { get; set; }
        
        // текущий номер талона
        public int CurrentNumber { get; set; }
        
        // следующий номер талона // Тогда тут лучше использовать сущность Ticket??????
        public int NextTicketNumber { get; set; }
        
        // статус очереди
        public QueueStatus Status { get; set; }
        
        // время создания очереди
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        // последнее время обновления очереди
        public DateTime? UpdatedAt { get; set; }
        
        // Идентификатор обслуживающего окна или оператора (если требуется интеграция с системой операторов)
        // подумать
        public int? ServiceCounterId { get; set; }
        
        // среднее время ожидания в минутах
        public double AverageWaitTimeInMinutes { get; set; }
    }
}
