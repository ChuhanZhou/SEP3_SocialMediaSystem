using System.Threading.Tasks;
using SEP3_PostSystem.Model.List.UserList;

namespace SEP3_PostSystem.UserSystem
{
    public interface ICloudUserSystem
    {
        Task<FriendList> GetFriendListByUserId(string id);
    }
}