using SEP3_Client.Model;

namespace SEP3_Client.Data
{
    public interface IClientModelForPostSystem
    {
        void SystemOnLine(FunctionType functionType);
        void SystemOffLine(FunctionType functionType);
    }
}