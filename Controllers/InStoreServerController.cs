using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RetailPlatformApp.Data;
using RetailPlatformApp.Models;

namespace RetailPlatformApp.Controllers {

    [Route("api/[controller]")]
    public class InStoreServerController : Controller {
        
        private readonly IRepository<InStoreServer> _inStoreServerRepo;
        
        public InStoreServerController(IRepository<InStoreServer> inStoreServerRepo) {
            _inStoreServerRepo = inStoreServerRepo;
            if(_inStoreServerRepo.GetAll().Count() == 0) {
                _inStoreServerRepo.Insert(new InStoreServer() {
                    Id = 1,   
                    StoreName = "UK9715ISS01",
                    IpAddress = "66.30.1.1",
                    StoreNumber = 9715,
                    Country = "HSC",
                    StoreType = "Large",
                });
            }
        }

        [HttpGet]
        public ActionResult<List<InStoreServer>> Get() {
            return _inStoreServerRepo.GetAll().ToList();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public ActionResult<InStoreServer> GetById(long id)
        {
            var item = _inStoreServerRepo.Get(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}