using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data.Entities
{
    public class Experience : BaseEntity
    {
        [Required]
        public string Name { get; set; } = "";
        public string? Description { get; set; }
        [Required]
        public DateTime StartedAt { get; set; } = DateTime.Now;
        public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();

    }
}