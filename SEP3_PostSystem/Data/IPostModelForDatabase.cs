using System.Threading.Tasks;

namespace SEP3_PostSystem.Data
{
    public interface IPostModelForDatabase
    {
        void DatabaseSystemOnline();
        void DatabaseSystemOffline();
    }
}