package com.example.SEP3_Database.model.domain.unit.user;

public class Friend extends BasicInformation {

    public Friend(Account account) {
        super(account.getId(), account.getUserName());
        setBirthday(account.getBirthday());
    }

    public Friend(String id, String userName, Birthday birthday) {
        super(id, userName);
        setBirthday(birthday);
    }

    public void update(Friend friend) {
        update(friend.getUserName(),friend.getBirthday(),friend.getGender(),friend.getHometown(),friend.getPhoneNumber());
    }

    public Friend copy() {
        return new Friend(getId(),getUserName(),getBirthday());
    }
}
