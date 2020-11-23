package com.example.SEP3_UserSystem.model.domain.unit.user;

public class Friend extends BasicInformation {

    public Friend(Account account) {
        super(account);
    }

    public Friend(Friend friend) {
        super(friend);
    }

    public Friend(String id, String userName, Birthday birthday) {
        super(id, userName);
        setBirthday(birthday);
    }

    public void update(Friend friend) {
        update(friend.getUserName(),friend.getBirthday(),friend.getGender(),friend.getHometown(),friend.getPhoneNumber());
    }

    public Friend copy() {
        return new Friend(this);
    }
}
