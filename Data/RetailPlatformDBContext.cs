using Microsoft.EntityFrameworkCore;
using RetailPlatformApp.Data.Mappings;
using RetailPlatformApp.Models;

namespace RetailPlatformApp.Data
{
    public class RetailPlatformDBContext : DbContext
    {
        public RetailPlatformDBContext(DbContextOptions<RetailPlatformDBContext> options)
                    : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {  
            base.OnModelCreating(modelBuilder);  
            new InStoreServerMap(modelBuilder.Entity < InStoreServer > ()); 
        }  
    }
}