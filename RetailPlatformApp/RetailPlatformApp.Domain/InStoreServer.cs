using System.Collections.Generic;

namespace RetailPlatformApp.Domain {

    public class InStoreServer : BaseEntity{

        public string StoreName { get; set; }
        public int StoreNumber { get; set; }
        public string IpAddress { get; set; }
        public string Country { get; set; }
        public string StoreType { get; set; } 
        public virtual ICollection < PointOfSale > PointOfSales {  
            get;  
            set;  
        } 
        
    }
}