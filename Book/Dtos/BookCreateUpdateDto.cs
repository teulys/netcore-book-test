using System;
using System.ComponentModel.DataAnnotations;

namespace BookCatalogs.Dtos
{
    public class BookCreateUpdateDto
    {
        [Required]
        public String Title { get; set; }
        [Required]
        public Decimal Price { get; set; }
    }
}
