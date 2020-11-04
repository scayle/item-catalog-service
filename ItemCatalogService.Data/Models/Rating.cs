using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItemCatalogService.Data
{
    public class Rating
    {
        public Guid Id { get; set; }
        
        [Required]
        public User User { get; set; }

        [MaxLength(200)]
        [Required]
        public string Title { get; set; }

        public string Text { get; set; }

        [Required]
        public int RatingValue { get; set; }
    }
}
