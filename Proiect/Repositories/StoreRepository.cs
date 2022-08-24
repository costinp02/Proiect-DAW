using Proiect.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private ProiectContext db;

        public StoreRepository(ProiectContext db)
        {
            this.db = db;
        }

        public IQueryable<Store> GetStoresIQueryable()
        {
            var stores = db.Stores;

            return stores;
        }

        public IQueryable<Store> GetStoresWithDetails()
        {
            var stores = GetStoresIQueryable().Include(x => x.Address).Include(x => x.GameStores);

            //var stores = db.GameStores.Include(x => x.Game).Include(x => x.Store);

            return stores;
        }

        public void Create(Store store)
        {
            db.Stores.Add(store);

            db.SaveChanges();
        }

        public void Update(Store store)
        {
            db.Stores.Update(store);

            db.SaveChanges();
        }

        public void Delete(Store store)
        {
            db.Stores.Remove(store);

            db.SaveChanges();
        }
    }
}
