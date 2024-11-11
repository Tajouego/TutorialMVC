using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(10)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,50)]
        public int DisplayOrder { get; set; }
    }
}
