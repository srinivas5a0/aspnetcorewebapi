using RetailPlatformApp.Domain;
using RetailPlatformApp.Data;

namespace RetailPlatformApp.Services
{
    public class TelnetService : ITelnetService
    {
        private readonly IRepository<POSExecutorOutput> _POSExecutorOutputRepo;

        public TelnetService(IRepository<POSExecutorOutput> POSExecutorOutputRepo){
            _POSExecutorOutputRepo = POSExecutorOutputRepo;
        }

        public POSExecutorOutput ExecuteCommandSingle(string command){
            
        }

        public TelnetInterface CheckTelnetConnection(string ipAddress)
        {
            TelnetInterface telnetManager = new TelnetInterface(ipAddress, 23);

            if (telnetManager.TelnetException)
            {
                _POSExecutorOutputRepo.Insert(new POSExecutorOutput() {
                    IpAddress =  ipAddress,
                    Command = "Telnet Connection",
                    Status = "Failed",
                    Result = "Telnet Connection Exception, not available"
                });
            }
            else
            {
                _POSExecutorOutputRepo.Insert(new POSExecutorOutput() {
                    IpAddress =  ipAddress,
                    Command = "Telnet Connection",
                    Status = "Success",
                    Result = "Telnet Connection Succeded"
                });
            }

            return telnetManager;
        }
    }
}