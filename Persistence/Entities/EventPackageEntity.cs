using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class EventPackageEntity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [ForeignKey(nameof(Event))]
        public string EventId { get; set; } = null!;
        public EventEntity Event { get; set; } = null!;

        [ForeignKey(nameof(Package))]
        public int PackageId { get; set; }
        public PackageEntity Package { get; set; } = null!;
    }
}
