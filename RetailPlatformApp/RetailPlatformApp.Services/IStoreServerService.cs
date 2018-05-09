using RetailPlatformApp.Domain;
using RetailPlatformApp.Data;
using System.Collections.Generic;

namespace  RetailPlatformApp.Services
{
    public interface IStoreServerService
    {
        List<InStoreServer> GetAllStores();
    }
}