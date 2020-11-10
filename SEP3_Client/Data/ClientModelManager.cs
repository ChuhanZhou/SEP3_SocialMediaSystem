using System.Collections.Generic;
using SEP3_Client.Model;

namespace SEP3_Client.Data
{
    public class ClientModelManager : IClientModel
    {
        private List<FunctionType> FunctionTypes;
        public ClientModelManager()
        {
            FunctionTypes = new List<FunctionType>();
        }
    }
}