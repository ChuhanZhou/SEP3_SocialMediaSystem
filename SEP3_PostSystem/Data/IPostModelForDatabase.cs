using System.Threading.Tasks;

namespace SEP3_PostSystem.Data
{
    public interface IPostModelForDatabase
    {
        Task DatabaseSystemOnline();
        void DatabaseSystemOffline();
    }
}