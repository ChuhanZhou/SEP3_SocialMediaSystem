package com.example.SEP3_Database.jdbc;

import com.example.SEP3_Database.model.domain.list.userList.FriendSettingList;
import com.example.SEP3_Database.model.domain.unit.user.FriendSetting;
import com.example.SEP3_Database.model.domain.unit.user.UserStatus;

public class UserRemain {
    FriendSetting friendSetting;
    FriendSettingList friendSettingList;
    UserStatus userStatus;
    String id;
    //String FriendId;
    public UserRemain(String id,FriendSettingList friendSettingList, UserStatus userStatus)
    {
        //this.FriendId = FriendId;
        this.id = id;
        this.friendSettingList = friendSettingList;
        this.userStatus = userStatus;
    }

    public void setFriendSetting(FriendSetting friendSetting) {
        this.friendSetting = friendSetting;
    }

    public void setUserStatus(UserStatus userStatus) {
        this.userStatus = userStatus;
    }

    public void setFriendSettingList(FriendSettingList friendSettingList) {
        this.friendSettingList = friendSettingList;
    }

    public FriendSetting getFriendSetting() {
        return friendSetting;
    }

    public FriendSettingList getFriendSettingList() {
        return friendSettingList;
    }

    public UserStatus getUserStatus() {
        return userStatus;
    }

    public String getPublicUserId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getId() {
        return id;
    }

    //public String getFriendId() {
    //    return FriendId;
    //}
//
    //public void setFriendId(String friendId) {
    //    FriendId = friendId;
    //}
}
