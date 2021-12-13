using System;
using System.ComponentModel.DataAnnotations;

namespace BookCatalogs.Models
{
    public class Book
    {
        [Required]
        public Guid id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
