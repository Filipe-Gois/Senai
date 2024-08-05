using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiProductManager.Domains
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public Guid IdProduct { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(60)")]
        public string? Name { get; set; }
        [Column(TypeName = "DECIMAL(8,2)")]
        public decimal? Price { get; set; }
    }
}
