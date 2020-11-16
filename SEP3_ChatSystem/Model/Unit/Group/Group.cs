using System.Collections.Generic;

namespace SEP3_ChatSystem.Model.Unit.Group
{
    public class Group
    {
        public string GroupId { get; set; }
        public string CreatorId { get; set; }
        public List<string> AccountIdList { get; set; }

        public Group(string groupId, string creatorId)
        {
            GroupId = groupId;
            CreatorId = creatorId;
            AccountIdList = new List<string> {creatorId};
        }
        
        public Group() {}

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

        public Group Copy()
        {
            return new Group
            {
                GroupId = GroupId,
                CreatorId = CreatorId,
                AccountIdList = new List<string>(AccountIdList)
            };
        }
    }
}