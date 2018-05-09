namespace RetailPlatformApp.Domain {

    public class PointOfSale {
        public long Id { get; set; }
        public string POSName { get; set; }
        public int POSNumber { get; set; }
        public POSType POSType { get; set; }
    }
}