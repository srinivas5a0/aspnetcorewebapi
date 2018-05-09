using NUnit.Framework;

namespace RetailPlatformApp.Services.Tests
{
    [TestFixture]
    public class StoreServerServiceChecks
    {
        private readonly StoreServerService _storeServerService;

        public StoreServerServiceChecks()
        {
            _storeServerService = new StoreServerService();
        }

        [Test]
        public void CheckGetAllStoreReturnValues()
        {
            var result = _storeServerService.GetAllStores();

            Assert.AreEqual(1,_storeServerService.GetAllStores().Count());
        }
    }
}