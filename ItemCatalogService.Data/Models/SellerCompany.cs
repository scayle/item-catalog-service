using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItemCatalogService
{
    public class SellerCompany
    {
        public Guid Id { get; set; }

        [MaxLength(200)]
        [Required]
        public string Name { get; set; }

        public List<ContactPerson> Contacts { get; set; } = new List<ContactPerson>();
        public List<Adress> LocationAdresses { get; set; } = new List<Adress>();
    }
}
