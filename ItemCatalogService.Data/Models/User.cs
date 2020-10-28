using System;
using System.Collections.Generic;
using System.Text;

namespace ItemCatalogService.Data
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<EMail> EMails { get; set; } = new List<EMail>();
    }
}
