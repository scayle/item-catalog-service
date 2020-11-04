using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItemCatalogService
{
    public class EMail
    {
        public Guid Id { get; set; }

        [MaxLength(200)]
        [Required]
        public string EMailAdress { get; set; }
    }
}
