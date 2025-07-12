using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.Common.BaseDto
{
    public class EntityDto<TKey>
    {
        public TKey Id { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.UtcNow;
        public Guid? CreatorId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public Guid? LastModifierId { get; set; }
    }
}
