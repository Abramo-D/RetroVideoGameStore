using System.ComponentModel.DataAnnotations;

namespace RetroVideoGameStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; }


        [Required]
        //[MaxLength(20)]
        public required string CategoryName { get; set; }
    }
}
