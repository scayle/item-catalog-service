using System;
using System.Collections.Generic;
using System.Text;

namespace ItemCatalogService
{
    public class Item
    {
        public Guid Id { get; set; }

        public int Name { get; set; }

        public decimal BuyPrice { get; set; }

        public decimal SellPrice { get; set; }

        public DateTime CreateTime { get; set; }

        public int StockQuantity { get; set; }

        public int Description { get; set; }

        public decimal Discount { get; set; }

        public SellerCompany SellerCompany { get; set; }

        public List<Question> Questions { get; set; } = new List<Question>();
        public List<Rating> Ratings { get; set; } = new List<Rating>();

    }
}
