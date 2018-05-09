using RetailPlatformApp.Domain;

namespace RetailPlatformApp.Services
{
    public interface ITelnetService
    {
        POSExecutorOutput ExecuteCommandSingle(string command);
    }
}