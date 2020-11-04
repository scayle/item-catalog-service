using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItemCatalogService.Data
{
    public class User
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public List<EMail> EMails { get; set; } = new List<EMail>();
    }
}
