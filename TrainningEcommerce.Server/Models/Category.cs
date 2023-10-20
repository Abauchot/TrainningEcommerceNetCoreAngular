using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace TrainingEcommerce.Server.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string CategoryName { get; set; } = "";
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
