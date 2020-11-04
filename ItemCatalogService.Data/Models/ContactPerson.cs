using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItemCatalogService.Data
{
    public class ContactPerson
    {
        public Guid Id { get; set; }

        [MaxLength(200)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(200)]
        [Required]
        public string LastName { get; set; }

        public List<Adress> WorkLocationAdresses { get; set; } = new List<Adress>();
        public List<EMail> EMails { get; set; } = new List<EMail>();
    }
}
