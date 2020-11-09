package model.domain.unit.user;

public abstract class User
{
    private String Id;
    private UserState userState;

    public User(String id)
    {
        Id = id;
        userState = new UserState();
    }

    public String getId()
    {
        return Id;
    }

    public UserState getUserState() {
        return userState;
    }
}
