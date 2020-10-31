using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItemCatalogService.Data.DataAccess
{
    public class ItemContext : DbContext
    {
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<ContactPerson> ContactPeople { get; set; }
        public DbSet<EMail> EMails { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<SellerCompany> SellerCompanies { get; set; }
        public DbSet<User> Users { get; set; }
        public ItemContext(DbContextOptions options) : base(options) 
        {

        }
    }
}
