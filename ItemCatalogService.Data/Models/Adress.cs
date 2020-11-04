using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItemCatalogService
{
    public class Adress
    {
        public Guid ID { get; set; }
        
        [MaxLength(200)]
        [Required]
        public string StreetAdress{ get; set; }
        
        [MaxLength(100)]
        [Required]
        public string City { get; set; }
        
        [MaxLength(100)]
        [Required]
        public string State { get; set; }

        [MaxLength(50)]
        [Required]
        public string ZipCode { get; set; }
    }
}
