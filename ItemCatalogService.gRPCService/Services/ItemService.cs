using Grpc.Core;
using ItemCatalogService.Data.DataAccess;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemCatalogService.gRPCService.Services
{
    public class ItemService : Item.ItemBase
    {
        public ILogger<ItemService> Logger { get; }
        public ItemContext ItemContext { get; }
        public ItemService(ILogger<ItemService> logger, ItemContext itemContext)
        {
            Logger = logger;
            ItemContext = itemContext;
        }

        public override Task<CreateTestItemsReply> CreateTestItems(CreateTestItemsRequest request, ServerCallContext context)
        {
            List<Data.Item> items = new List<Data.Item>();

            for (int i = 0; i < 5; i++)
            {
                items.Add(new Data.Item()
                {
                    Id = new Guid(),
                    Name = $"Test Item {i}",
                    CreateTime = DateTime.Now,
                    SellerCompany = new Data.SellerCompany()
                    {
                        Id = new Guid(),
                        Name = $"Test Company {i}"
                    }

                });
            }

            ItemContext.AddRange(items);
            ItemContext.SaveChanges();

            return Task.FromResult(new CreateTestItemsReply());
        }
    }
}
