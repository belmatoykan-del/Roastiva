using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Roastiva.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Slug { get; set; }

        public string? ShortDescription { get; set; }
        public string? Description { get; set; }

        public decimal? Price { get; set; } // Şimdilik opsiyonel

        public string? ImageUrl { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? RoastLevel { get; set; }
        public string? Origin { get; set; }
        public string? FlavorNotes { get; set; }

        public Product()
        {
            CreatedDate = DateTime.Now;
            IsActive = true;
        }
    }
}
