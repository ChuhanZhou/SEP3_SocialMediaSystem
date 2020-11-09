package model.domain.User;

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

    @Override
    public Friend copy() {
        return new Friend(getId(),getUserName(),getBirthday());
    }
}
