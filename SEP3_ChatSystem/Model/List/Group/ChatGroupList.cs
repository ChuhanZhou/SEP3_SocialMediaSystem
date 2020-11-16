using System.Collections.Generic;
using SEP3_ChatSystem.Model.Unit.Group;

namespace SEP3_ChatSystem.Model.List.Group
{
    public class ChatGroupList
    {
        public List<ChatGroup> GroupList { get; set; }

        public ChatGroupList()
        {
            GroupList = new List<ChatGroup>();
        }

        public string AddNewGroup(ChatGroup newGroup)
        {
            if (!HasGroupId(newGroup.GroupId))
            {
                GroupList.Add(newGroup);
                return null;
            }
            else
            {
                return "This is not a new group";
            }
        }

        public bool HasGroupId(string id)
        {
            foreach (var group in GroupList)
            {
                if (group.GroupId==id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}