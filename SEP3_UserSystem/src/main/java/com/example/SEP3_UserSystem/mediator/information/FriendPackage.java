package com.example.SEP3_UserSystem.mediator.information;

import com.example.SEP3_UserSystem.model.domain.list.userList.FriendList;
import com.example.SEP3_UserSystem.model.domain.unit.user.Friend;

public class FriendPackage extends InformationPackage{
    private FriendList SendList;

    public FriendPackage(FriendList friendList,String keyword)
    {
        super(InformationType.FRIEND,keyword);
        SendList = friendList.copy();
    }

    public FriendPackage(Friend friend, String keyword)
    {
        super(InformationType.FRIEND,keyword);
        SendList = new FriendList();
        SendList.addNewFriend(friend);
    }

    public FriendList getSendList() {
        return SendList;
    }
}
