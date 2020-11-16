package com.example.SEP3_Database.model.domain.unit.user;

public abstract class User
{
    private String Id;
    private UserStatus UserStatus;

    public User(String id)
    {
        Id = id;
        UserStatus = new UserStatus();
    }

    public String getId()
    {
        return Id;
    }
    public void DatabaseSetId(String id)
    {
        this.Id = id;
    }
    public UserStatus getUserStatus() {
        return UserStatus;
    }

    public void setUserStatus(UserStatus userStatus) {
        UserStatus = userStatus;
    }
}
