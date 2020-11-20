using Grpc.Core;
using ItemCatalogService.Data.DataAccess;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemCatalogService.gRPCService.Repository;

namespace ItemCatalogService.gRPCService.Services
{
    public class ItemService : Item.ItemBase
    {
        public ILogger<ItemService> Logger { get; }
        public IItemRepository ItemRepository { get; set; }
        public ItemService(ILogger<ItemService> logger, IItemRepository itemRepository)
        {
            Logger = logger;
            ItemRepository = itemRepository;
        }

        public override Task<CreateTestItemsReply> CreateTestItems(CreateTestItemsRequest request, ServerCallContext context)
        {
            ItemRepository.CreateTestItems();
            return Task.FromResult(new CreateTestItemsReply());
        }
    }
}
