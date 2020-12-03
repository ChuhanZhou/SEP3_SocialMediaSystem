using System.Threading.Tasks;
using SEP3_PostSystem.Model.List.UserList;

namespace SEP3_PostSystem.UserSystem
{
    public interface ICloudUserSystem
    {
        Task<bool> HasId(string id);
        Task<FriendList> GetFriendListByUserId(string id);
    }
}