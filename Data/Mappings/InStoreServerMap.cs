using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailPlatformApp.Models;

namespace RetailPlatformApp.Data.Mappings{
    public class InStoreServerMap {
        public InStoreServerMap(EntityTypeBuilder < InStoreServer > entityBuilder) {
            entityBuilder.HasKey(t => t.Id);  
            entityBuilder.Property(t => t.StoreName).IsRequired();  
            entityBuilder.Property(t => t.StoreNumber).IsRequired();  
            entityBuilder.Property(t => t.StoreType).IsRequired();  
            entityBuilder.Property(t => t.IpAddress).IsRequired();  
            entityBuilder.Property(t => t.Country).IsRequired();  
        }
    }
}