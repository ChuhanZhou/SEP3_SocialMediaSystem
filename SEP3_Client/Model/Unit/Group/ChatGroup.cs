using System.Collections.Generic;

namespace SEP3_Client.Model.Unit.Group
{
    public class ChatGroup
    {
        public string GroupId { get; set; }
        public string GroupName { get; set; }
        public string CreatorId { get; set; }
        public List<string> AccountIdList { get; set; }

        public ChatGroup(string groupName,string creatorId)
        {
            GroupId = null;
            GroupName = groupName;
            CreatorId = creatorId;
            AccountIdList = new List<string> {creatorId};
        }
        
        public ChatGroup(string groupId,ChatGroup chatGroup)
        {
            GroupId = groupId;
            GroupName = chatGroup.GroupName;
            CreatorId = chatGroup.CreatorId;
            AccountIdList = new List<string> {chatGroup.CreatorId};
        }
        
        public ChatGroup() {}

        public string AddAccountId(string id)
        {
            if (!HasId(id))
            {
                AccountIdList.Add(id);
                return null;
            }
            else
            {
                return "The [" + id + "] is in the group.";
            }
        }

        public bool HasId(string searchId)
        {
            foreach (var id in AccountIdList)
            {
                if (searchId==id)
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveAccountById(string id)
        {
            AccountIdList.Remove(id);
        }

        public ChatGroup Copy()
        {
            return new ChatGroup
            {
                GroupId = GroupId,
                CreatorId = CreatorId,
                AccountIdList = new List<string>(AccountIdList)
            };
        }
    }
}