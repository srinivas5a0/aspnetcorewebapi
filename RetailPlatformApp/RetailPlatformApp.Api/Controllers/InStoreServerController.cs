using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RetailPlatformApp.Domain;
using RetailPlatformApp.Services;
using RetailPlatformApp.Data;


namespace RetailPlatformApp.Api.Controllers
{
    [Route("api/[controller]")]
    public class InStoreServerController : Controller {
        
        private readonly IStoreServerService _iStoreService;
        
        public InStoreServerController(IStoreServerService iStoreService) {
            _iStoreService = iStoreService;
        }

        [HttpGet]
        public ActionResult<List<InStoreServer>> Get() {
            return _iStoreService.GetAllStores();
        }

        // [HttpGet("{id}", Name = "GetTodo")]
        // public ActionResult<InStoreServer> GetById(long id)
        // {
        //     var item = _inStoreServerRepo.Get(id);
        //     if (item == null)
        //     {
        //         return NotFound();
        //     }
        //     return item;
        // }
    }
}