package model.domain.unit.user;

import java.util.Date;

public class Friend extends UserInformation {

    public Friend(Account account) {
        super(account.getId(), account.getUserName());
        setBirthday(account.getBirthday());
    }

    public Friend(String id, String userName, Date birthday) {
        super(id, userName);
        setBirthday(birthday);
    }

    public void update(Friend friend) {
        update(friend.getUserName(),friend.getBirthday());
    }

    public Friend copy() {
        return new Friend(getId(),getUserName(),getBirthday());
    }
}