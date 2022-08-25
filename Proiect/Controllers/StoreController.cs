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
    public class StoreController : ControllerBase
    {
        private readonly IStoreManager manager;

        public StoreController(IStoreManager storeManager)
        {
            this.manager = storeManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetStores()
        {

            var stores = manager.GetStores();

            return Ok(stores);


        }

        [HttpGet("stores-with-details")]
        public async Task<IActionResult> JoinEager()
        {
            var storesWithDetails = manager.GetStoresWithDetails();

            return Ok(storesWithDetails);
        }

        [HttpPost("withObj")]
        public async Task<IActionResult> Create([FromBody] StoreModel storeCreationModel)
        {


            manager.Create(storeCreationModel);

            return Ok();
        }

        [HttpPut("withObj")]
        public async Task<IActionResult> Update([FromBody] StoreModel storeCreationModel)
        {

            manager.Update(storeCreationModel);

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
