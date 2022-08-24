using Proiect.Entities;
using Proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Managers
{
    public interface IStoreManager
    {
        List<Store> GetStores();
        List<Store> GetStoresWithDetails();

        Store GetStoreById(string id);
        void Create(string name);
        void Create(StoreModel model);
        void Update(StoreModel model);
        void Delete(string id);
    }
}
