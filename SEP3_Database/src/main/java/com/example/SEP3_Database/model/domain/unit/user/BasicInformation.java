package com.example.SEP3_Database.model.domain.unit.user;

public abstract class BasicInformation extends User{
    private String UserName;
    private Birthday Birthday;

    public BasicInformation(String id, String userName)
    {
        super(id);
        UserName = userName;
    }

    public String getUserName() {
        return UserName;
    }

    public void setUserName(String userName) {
        UserName = userName;
    }

    public Birthday getBirthday() {
        return Birthday;
    }

    public void setBirthday(Birthday birthday) {
        Birthday = birthday;
    }

    public void update(String userName,Birthday birthday) {
        UserName = userName;
        Birthday = birthday;
    }
}
