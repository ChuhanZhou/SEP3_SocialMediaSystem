package com.example.SEP3_UserSystem.mediator.information;

import com.example.SEP3_UserSystem.model.domain.list.userList.FriendSettingList;
import com.example.SEP3_UserSystem.model.domain.unit.user.FriendSetting;

public class FriendSettingPackage extends InformationPackage{
    private FriendSettingList FriendSettingList;

    public FriendSettingPackage(FriendSettingList friendSettingList,String keyword)
    {
        super(InformationType.SETTING,keyword);
        FriendSettingList = friendSettingList;
    }

    public FriendSettingPackage(FriendSetting friendSetting,String keyword)
    {
        super(InformationType.SETTING,keyword);
        FriendSettingList = new FriendSettingList();
        FriendSettingList.addNewFriendSetting(friendSetting);
    }

    public com.example.SEP3_UserSystem.model.domain.list.userList.FriendSettingList getFriendSettingList() {
        return FriendSettingList;
    }
}
