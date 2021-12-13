using System;
using System.ComponentModel.DataAnnotations;

namespace BookCatalogs.Dtos
{
    public class BookDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
