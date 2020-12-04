package com.example.SEP3_Database.model.domain.unit.group;

import java.util.ArrayList;

public class ChatGroup {
    private String GroupId;
    private String GroupName;
    private String CreatorId;
    private ArrayList<String> AccountIdList;

    public ChatGroup(String groupName,String creatorId)
    {
        GroupId = null;
        GroupName = groupName;
        CreatorId = creatorId;
        AccountIdList = new ArrayList<>();
        AccountIdList.add(creatorId);
    }

    public ChatGroup(String groupId,ChatGroup chatGroup)
    {
        GroupId = groupId;
        GroupName = chatGroup.GroupName;
        CreatorId = chatGroup.CreatorId;
        AccountIdList = new ArrayList<>();
        AccountIdList.add(CreatorId);
    }

    private ChatGroup(ChatGroup chatGroup)
    {
        GroupId = chatGroup.GroupId;
        GroupName = chatGroup.GroupName;
        CreatorId = chatGroup.CreatorId;
        AccountIdList = chatGroup.AccountIdList;
    }

    public String getGroupId() {
        return GroupId;
    }

    public String getGroupName() {
        return GroupName;
    }

    public String getCreatorId() {
        return CreatorId;
    }

    public ArrayList<String> getAccountIdList() {
        return AccountIdList;
    }

    public void setGroupId(String groupId) {
        GroupId = groupId;
    }

    public void setGroupName(String groupName) {
        GroupName = groupName;
    }

    public void setCreatorId(String creatorId) {
        CreatorId = creatorId;
    }

    public void setAccountIdList(ArrayList<String> accountIdList) {
        AccountIdList = accountIdList;
    }

    public String addAccountId(String id)
    {
        if (!hasId(id))
        {
            AccountIdList.add(id);
            return null;
        }
        else
        {
            return "The [" + id + "] is in the group.";
        }
    }

    public boolean hasId(String searchId)
    {
        for (int x=0;x<AccountIdList.size();x++)
        {
            if (searchId.equals(AccountIdList.get(x)))
            {
                return true;
            }
        }
        return false;
    }

    public void update(ChatGroup newChatGroup)
    {
        GroupId = newChatGroup.GroupId;
        GroupName = newChatGroup.GroupName;
        CreatorId = newChatGroup.CreatorId;
        AccountIdList = newChatGroup.AccountIdList;
    }

    public void removeAccountById(String id)
    {
        AccountIdList.remove(id);
    }

    public ChatGroup copy()
    {
        return new ChatGroup(this);
    }
}
