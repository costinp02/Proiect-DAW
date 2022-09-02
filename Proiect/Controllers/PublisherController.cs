using Proiect.Entities;
using Proiect.Managers;
using Proiect.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherManager manager;

        public PublisherController(IPublisherManager publisherManager)
        {
            this.manager = publisherManager;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetPublishers()
        {
            var publishers = manager.GetPublishers();

            return Ok(publishers);
        }

        [HttpGet("publishers-with-games")]
        public async Task<IActionResult> JoinEager()
        {
            var publisherWithGames = manager.GetPublishersWithGames();

            return Ok(publisherWithGames);
        }

        [HttpGet("byId/{id}")]
        public async Task<IActionResult> GetById([FromRoute] string id)
        {
            var publisher = manager.GetPublisherById(id);

            return Ok(publisher);
        }

        [HttpPost("withObj")]
        public async Task<IActionResult> Create([FromBody] PublisherModel publisherModel)
        {
            manager.Create(publisherModel);

            return Ok();
        }

        [HttpPut("withObj")]
        public async Task<IActionResult> Update([FromBody] PublisherModel publisherModel)
        {
            manager.Update(publisherModel);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            manager.Delete(id);

            return Ok();
        }

    }
}
