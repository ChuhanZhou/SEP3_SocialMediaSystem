package mediator.information;

import model.domain.list.userList.FriendList;
import model.domain.unit.user.Friend;

public class FriendPackage extends InformationPackage{
    private FriendList SendList;

    public FriendPackage(FriendList friendList,String keyword)
    {
        super(InformationType.FRIEND,keyword);
        SendList = friendList.copy();
    }

    public FriendPackage(Friend friend,String keyword)
    {
        super(InformationType.ACCOUNT,keyword);
        SendList = new FriendList();
        SendList.addNewFriend(friend);
    }

    public FriendList getSendList() {
        return SendList;
    }
}
