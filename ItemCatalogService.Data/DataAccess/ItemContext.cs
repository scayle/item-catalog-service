using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItemCatalogService.Data.DataAccess
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SellerCompany> SellerCompanies { get; set; }
    }
}
