using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public interface IPublisherRepository
    {
        IQueryable<Publisher> GetPublisherIQueryable();

        IQueryable<Publisher> GetPublisherWithGames();

        void Create(Publisher publisher);
        void Update(Publisher publisher);
        void Delete(Publisher publisher);
    }
}
