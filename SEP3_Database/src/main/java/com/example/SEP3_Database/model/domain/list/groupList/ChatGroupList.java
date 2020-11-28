package com.example.SEP3_Database.model.domain.list.groupList;

import com.example.SEP3_Database.model.domain.unit.group.ChatGroup;

import java.util.ArrayList;

public class ChatGroupList {
    private ArrayList<ChatGroup> GroupList;

    public ChatGroupList()
    {
        GroupList = new ArrayList<>();
    }

    public String addNewGroup(ChatGroup newGroup)
    {
        if (!hasGroupId(newGroup.getGroupId()))
        {
            GroupList.add(newGroup);
            return null;
        }
        else
        {
            return "This is not a new group";
        }
    }

    public boolean hasGroupId(String id)
    {
        for (int x=0;x<GroupList.size();x++)
        {
            if (GroupList.get(x).getGroupId()==id)
            {
                return true;
            }
        }
        return false;
    }

    public int getSize()
    {
        return GroupList.size();
    }

    public ChatGroup getGroupByIndex(int index)
    {
        if (index>=0&&index<GroupList.size())
        {
            return GroupList.get(index);
        }

        return null;
    }

    public ChatGroup getGroupByGroupId(String id)
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

    public ChatGroupList getGroupByCreatorId(String id)
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

    public ChatGroupList getGroupByUserId(String id)
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

    public void removeGroupByGroupId(String id)
    {
        foreach (var group in GroupList)
        {
            if (group.HasId(id))
            {
                GroupList.Remove(group);
            }
        }
    }

    public void removeGroupByIndex(int index)
    {
        GroupList.RemoveAt(index);
    }

    public ChatGroupList copy()
    {
        ChatGroupList copy = new ChatGroupList();
        for       foreach (var group in GroupList)
        {
            copy.GroupList.Add(group.Copy());
        }
        return copy;
    }
}
