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
        if (newGroup!=null)
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
        return "Input null.";
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
        for (int x=0;x<GroupList.size();x++)
        {
            if (GroupList.get(x).getGroupId()==id)
            {
                return GroupList.get(x);
            }
        }
        return null;
    }

    public ChatGroupList getGroupByCreatorId(String id)
    {
        ChatGroupList chatGroupList = new ChatGroupList();
        for (int x=0;x<GroupList.size();x++)
        {
            if (GroupList.get(x).getCreatorId()==id)
            {
                chatGroupList.GroupList.add(GroupList.get(x));
            }
        }
        return chatGroupList;
    }

    public ChatGroupList getGroupByUserId(String id)
    {
        ChatGroupList chatGroupList = new ChatGroupList();
        for (int x=0;x<GroupList.size();x++)
        {
            if (GroupList.get(x).hasId(id))
            {
                chatGroupList.GroupList.add(GroupList.get(x));
            }
        }
        return chatGroupList;
    }

    public String updateGroup(ChatGroup chatGroup)
    {
        for (int x=0;x<GroupList.size();x++)
        {
            if (GroupList.get(x).getGroupId()==chatGroup.getGroupId())
            {
                GroupList.get(x).setGroupName(chatGroup.getGroupName());
                GroupList.get(x).setCreatorId(chatGroup.getCreatorId());
                GroupList.get(x).setAccountIdList(chatGroup.getAccountIdList());
                return null;
            }
        }
        return "Can find the old group.";
    }

    public void removeGroupByGroupId(String id)
    {
        for (int x=0;x<GroupList.size();x++)
        {
            if (GroupList.get(x).getGroupId()==id)
            {
                GroupList.remove(x);
                break;
            }
        }
    }

    public void removeGroupByIndex(int index)
    {
        GroupList.remove(index);
    }

    public ChatGroupList copy()
    {
        ChatGroupList copy = new ChatGroupList();
        for (int x=0;x<GroupList.size();x++)
        {
            copy.GroupList.add(GroupList.get(x).copy());
        }
        return copy;
    }
}
