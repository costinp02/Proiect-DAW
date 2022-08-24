using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public interface IStoreRepository
    {
        IQueryable<Store> GetStoresIQueryable();

        IQueryable<Store> GetStoresWithDetails();

        void Create(Store store);
        void Update(Store store);
        void Delete(Store store);
    }
}
