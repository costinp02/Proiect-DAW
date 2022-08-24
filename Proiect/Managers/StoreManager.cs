using Proiect.Entities;
using Proiect.Models;
using Proiect.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Managers
{
    public class StoreManager : IStoreManager
    {
        private readonly IStoreRepository storeRepository;

        public StoreManager(IStoreRepository storeRepository)
        {
            this.storeRepository = storeRepository;
        }

        public void Create(string name)
        {
            var newStore = new Store
            {
                Id = "7",
                Name = name
            };

            storeRepository.Create(newStore);
        }

        public void Create(StoreModel model)
        {
            var newStore = new Store
            {
                Id = model.Id,
                Name = model.Name
            };

            storeRepository.Create(newStore);
        }

        public void Update(StoreModel model)
        {
            var store = GetStoreById(model.Id);

            store.Name = model.Name;
            storeRepository.Update(store);
        }

        public void Delete(string id)
        {
            var store = GetStoreById(id);

            storeRepository.Delete(store);
        }

        public Store GetStoreById(string id)
        {
            var store = storeRepository.GetStoresIQueryable()
                .FirstOrDefault(x => x.Id == id);

            return store;
        }

        public List<Store> GetStores()
        {
            return storeRepository.GetStoresIQueryable().ToList();
        }

        public List<Store> GetStoresWithDetails()
        {
            var storesWithGames = storeRepository.GetStoresWithDetails();

            return storesWithGames.ToList();
        }
    }
}
