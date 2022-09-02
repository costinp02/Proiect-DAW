using Proiect.Entities;
using Proiect.Models;
using Proiect.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Managers
{
    public class PublisherManager : IPublisherManager
    {
        private readonly IPublisherRepository publisherRepository;

        public PublisherManager(IPublisherRepository publisherRepository)
        {
            this.publisherRepository = publisherRepository;
        }

        public void Create(string name)
        {
            var newPublisher = new Publisher
            {
                Id = "7",
                Name = name
            };

            publisherRepository.Create(newPublisher);
        }

        public void Create(PublisherModel model)
        {
            var newPublisher = new Publisher
            {
                Id = model.Id,
                Name = model.Name,
                Country = model.Country,
                Rating = model.Rating
            };

            publisherRepository.Create(newPublisher);
        }

        public void Update(PublisherModel model)
        {
            var publisher = GetPublisherById(model.Id);

            publisher.Name = model.Name;
            publisherRepository.Update(publisher);
        }

        public void Delete(string id)
        {
            var publisher = GetPublisherById(id);

            publisherRepository.Delete(publisher);
        }


        public List<Publisher> GetPublishers()
        {
            return publisherRepository.GetPublisherIQueryable().ToList();
        }

        public List<Publisher> GetPublishersWithGames()
        {
            var publisherWithGames = publisherRepository.GetPublisherWithGames();

            return publisherWithGames.ToList();
        }

        public Publisher GetPublisherById(string id)
        {
            var publisher = publisherRepository.GetPublisherWithGames()
                .FirstOrDefault(x => x.Id.Equals(id));

            return publisher;
        }

    }
}
