using System;
using System.Collections.Generic;
using System.Text;

namespace ItemCatalogService.Data
{
    public class Rating
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int RatingValue { get; set; }
    }
}
