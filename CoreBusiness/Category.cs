using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}