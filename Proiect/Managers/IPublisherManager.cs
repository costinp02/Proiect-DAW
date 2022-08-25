using Proiect.Entities;
using Proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Managers
{
    public interface IPublisherManager
    {
        List<Publisher> GetPublishers();
        List<Publisher> GetPublishersWithGames();

        Publisher GetPublisherById(string id);
        void Create(string name);
        void Create(PublisherModel model);
        void Update(PublisherModel model);
        void Delete(string id);
    }
}
