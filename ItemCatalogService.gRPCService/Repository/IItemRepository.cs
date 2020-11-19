using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ItemCatalogService.gRPCService.Repository
{
    public interface IItemRepository
    {
        public Task CreateTestItems();
    }
}
