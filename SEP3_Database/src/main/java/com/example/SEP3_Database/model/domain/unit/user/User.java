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

    public User(User user)
    {
        Id = user.Id;
        UserStatus = user.UserStatus.copy();
    }

    public String getId()
    {
        return Id;
    }

    public void setId(String id) {
        Id = id;
    }

    public UserStatus getUserStatus() {
        return UserStatus;
    }

    public void setUserStatus(UserStatus userStatus) {
        UserStatus = userStatus;
    }
}
