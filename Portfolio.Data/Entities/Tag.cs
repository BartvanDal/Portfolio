using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.Entities
{
    public class Tag : BaseEntity
    {
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public int YearStarted { get; set; } = 0;

        public virtual ICollection<Experience> Experiences { get; set; } = new List<Experience>();
    }
}
