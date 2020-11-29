using System.Threading.Tasks;

namespace SEP3_ChatSystem.Data
{
    public interface IChatModelForDatabase
    {
        Task DatabaseSystemOnline();
        void DatabaseSystemOffline();
    }
}