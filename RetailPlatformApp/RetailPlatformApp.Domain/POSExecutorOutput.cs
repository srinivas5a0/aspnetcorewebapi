namespace RetailPlatformApp.Domain
{
    public class POSExecutorOutput : BaseEntity
    {
        public string IpAddress { get; set; } 
        public string Command { get; set; }
        public string Status { get; set; }
        public string Result { get; set; }
    }
}