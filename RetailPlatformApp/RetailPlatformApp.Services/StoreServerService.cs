using RetailPlatformApp.Data;
using RetailPlatformApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailPlatformApp.Services
{
    public class StoreServerService : IStoreServerService
    {
        private readonly IRepository<InStoreServer> _inStoreServerRepo;

        public StoreServerService(IRepository<InStoreServer> inStoreServerRepo){
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

        public List<InStoreServer> GetAllStores(){
            return _inStoreServerRepo.GetAll().ToList();
        }
    }
}