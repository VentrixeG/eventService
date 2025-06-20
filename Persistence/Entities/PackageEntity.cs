using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class PackageEntity
    {
        [Key]
        public int Id { get; set; }

        public string? Title { get; set; }

        public string SeatingArrangement { get; set; } = null!;

        public string? Placement { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
        public string? Currency { get; set; }

        public ICollection<EventPackageEntity> Events { get; set; } = [];

    }

}
