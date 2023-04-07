using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required, MinLength(2)]
        public string Title { get; set; }

        [Required, MinLength(2)]
        public string Author { get; set; }
        
        [Required, MinLength(2)]
        public string Publisher { get; set; }
        
        [Required, Range(0, int.MaxValue)]
        public decimal Price { get; set; }
    }
}
