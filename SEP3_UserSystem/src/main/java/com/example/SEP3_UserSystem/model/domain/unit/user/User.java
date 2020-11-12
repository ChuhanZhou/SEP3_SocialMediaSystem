package com.example.SEP3_UserSystem.model.domain.unit.user;

public abstract class User
{
    private String Id;
    private UserState UserState;

    public User(String id)
    {
        Id = id;
        UserState = new UserState();
    }

    public String getId()
    {
        return Id;
    }

    public UserState getUserState() {
        return UserState;
    }

    public void setUserState(UserState userState) {
        UserState = userState;
    }
}
