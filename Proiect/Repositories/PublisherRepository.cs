using Proiect.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public class PublisherRepository : IPublisherRepository
    {
        private ProiectContext db;

        public PublisherRepository(ProiectContext db)
        {
            this.db = db;
        }

        public IQueryable<Publisher> GetPublisherIQueryable()
        {
            var publishers = db.Publishers;

            return publishers;
        }

        public void Create(Publisher publisher)
        {
            db.Publishers.Add(publisher);

            db.SaveChanges();
        }

        public void Update(Publisher publisher)
        {
            db.Publishers.Update(publisher);

            db.SaveChanges();
        }

        public void Delete(Publisher publisher)
        {
            db.Publishers.Remove(publisher);

            db.SaveChanges();
        }
    }
}
