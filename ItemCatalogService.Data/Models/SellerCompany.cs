using System;
using System.Collections.Generic;
using System.Text;

namespace ItemCatalogService.Data
{
    public class SellerCompany
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<ContactPerson> Contacts { get; set; } = new List<ContactPerson>();

        public List<Adress> LocationAdresses { get; set; } = new List<Adress>();
    }
}
