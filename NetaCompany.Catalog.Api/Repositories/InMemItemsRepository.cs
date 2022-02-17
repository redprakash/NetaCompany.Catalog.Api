using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetaCompany.Catalog.Api.Entities;

namespace NetaCompany.Catalog.Api.Repositories
{
    public class InMemItemsRepository : IItemsRepository
    {
        private readonly List<Item> _items = new()
        {
            new Item
            {
                Id = Guid.NewGuid(), Name = "Potion", 
                CreatedDate = DateTimeOffset.UtcNow, 
                Price = 10
            },
            new Item
            {
                Id = Guid.NewGuid(),
                Name = "Iron Sword",
                CreatedDate = DateTimeOffset.UtcNow,
                Price = 20
            },
            new Item
            {
                Id = Guid.NewGuid(),
                Name = "Shield",
                CreatedDate = DateTimeOffset.UtcNow,
                Price = 40
            }
        };

        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await Task.FromResult(_items);

        }

        public async Task<Item> GetItemAsync(Guid id)
        {
            var item =  _items.SingleOrDefault(item => item.Id == id);
            return await Task.FromResult(item);
        }

        public async Task CreateItemAsync(Item item)
        {
           _items.Add((item));
            await Task.CompletedTask;
        }

        public async Task UpdateItemAsync(Item item)
        {
            var index = _items.FindIndex(existingItem => existingItem.Id == item.Id);
            _items[index] = item;
            await Task.CompletedTask;
        }

        public async Task DeleteItemAsync(Guid id)
        {
            var index = _items.FindIndex(existingItem => existingItem.Id == id);
            _items.RemoveAt(index);
            await Task.CompletedTask;
        }
    }
}
