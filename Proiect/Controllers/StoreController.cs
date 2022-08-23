using Proiect.Entities;
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
    public class StoreController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetStores()
        {
            var db = new ProiectContext();

            var stores = db.Stores.ToList();

            return Ok(stores);



            /* select * from Authors*/
        }

        [HttpPost("withObj")]
        public async Task<IActionResult> Create([FromBody] StoreModel storeCreationModel)
        {
            var db = new ProiectContext();

            var newStore = new Store
            {
                Id = storeCreationModel.Id,
                Name = storeCreationModel.Name
            };

            // db.Add(newAuthor);
            await db.Stores.AddAsync(newStore);

            await db.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("withObj")]
        public async Task<IActionResult> Update([FromBody] StoreModel storeCreationModel)
        {
            var db = new ProiectContext();

            var store = db.Stores.FirstOrDefault(x => x.Id == storeCreationModel.Id);

            store.Name = storeCreationModel.Name;

            db.Stores.Update(store);

            await db.SaveChangesAsync();

            return Ok();
        }
    }
}
