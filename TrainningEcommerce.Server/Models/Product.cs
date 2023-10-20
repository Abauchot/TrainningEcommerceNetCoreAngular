using System.ComponentModel.DataAnnotations;
using TrainingEcommerce.Server.Models;

namespace TrainningEcommerce.Server.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; } = "";
        public string ProductDescription { get; set; } = "";
        [Required]
        public decimal ProductPrice { get; set; }
        [Required]
        public decimal ProductQuantity { get; set; }

        public int CategoryId { get; set; }    
        public Category Category { get; set; }

    }
}
