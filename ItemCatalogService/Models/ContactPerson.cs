using System;
using System.Collections.Generic;
using System.Text;

namespace ItemCatalogService
{
    public class ContactPerson
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Adress> WorkLocationAdresses { get; set; } = new List<Adress>();
        public List<EMail> EMails { get; set; } = new List<EMail>();
    }
}
