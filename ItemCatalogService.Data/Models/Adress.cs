using System;
using System.Collections.Generic;
using System.Text;

namespace ItemCatalogService.Data
{
    public class Adress
    {
        //test
        public Guid ID { get; set; }
        public string StreetAdress{ get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
