using System.ComponentModel.DataAnnotations;

namespace BackendApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Description { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
