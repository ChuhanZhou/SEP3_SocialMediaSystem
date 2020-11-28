using System.Collections.Generic;
using SEP3_ChatSystem.Model.Unit.Group;

namespace SEP3_ChatSystem.Model.List.Group
{
    public class ChatGroupList
    {
        private static ChatGroupList allGroup;
        public List<ChatGroup> GroupList { get; set; }

        public static ChatGroupList GetAllGroupList()
        {
            if (allGroup==null)
            {
                allGroup = new ChatGroupList();
            }
            return allGroup;
        }

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

        public int GetSize()
        {
            return GroupList.Count;
        }

        public ChatGroup GetGroupByIndex(int index)
        {
            if (index>=0&&index<GroupList.Count)
            {
                return GroupList[index];
            }

            return null;
        }

        public ChatGroup GetGroupByGroupId(string id)
        {
            foreach (var group in GroupList)
            {
                if (group.GroupId==id)
                {
                    return group;
                }
            }
            return null;
        }

        public ChatGroupList GetGroupByCreatorId(string id)
        {
            ChatGroupList chatGroupList = new ChatGroupList();
            foreach (var group in GroupList)
            {
                if (group.CreatorId==id)
                {
                    chatGroupList.AddNewGroup(group);
                }
            }
            return chatGroupList;
        }
        
        public ChatGroupList GetGroupByUserId(string id)
        {
            ChatGroupList chatGroupList = new ChatGroupList();
            foreach (var group in GroupList)
            {
                if (group.HasId(id))
                {
                    chatGroupList.AddNewGroup(group);
                }
            }
            return chatGroupList;
        }

        public void RemoveGroupByGroupId(string id)
        {
            foreach (var group in GroupList)
            {
                if (group.HasId(id))
                {
                    GroupList.Remove(group);
                }
            }
        }

        public void RemoveGroupByIndex(int index)
        {
            GroupList.RemoveAt(index);
        }

        public ChatGroupList Copy()
        {
            ChatGroupList copy = new ChatGroupList();
            foreach (var group in GroupList)
            {
                copy.GroupList.Add(group.Copy());
            }
            return copy;
        }
    }
}