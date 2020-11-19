using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ItemCatalogService.Data.DataAccess;
using ItemCatalogService.gRPCService.Repository;

namespace ItemCatalogService.gRPCService.Repository
{
    public class ItemRepository : IItemRepository
    {
        public ItemContext ItemContext { get; set; }

        public ItemRepository(ItemContext itemContext)
        {
            ItemContext = itemContext;
        }

        public async Task CreateTestItems()
        {
            List<Data.Item> items = new List<Data.Item>();

            for (int i = 0; i < 5; i++)
            {
                items.Add(new Data.Item()
                {
                    Name = $"Test Item {i}",
                    CreateTime = DateTime.Now,
                    SellerCompany = new Data.SellerCompany()
                    {
                        Name = $"Test Company {i}"
                    }
                });
            }

            await ItemContext.Items.AddRangeAsync(items);
            await ItemContext.SaveChangesAsync();
        }
    }
}
