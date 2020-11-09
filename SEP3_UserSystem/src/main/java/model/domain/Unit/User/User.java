package model.domain.Unit.User;

public abstract class User
{
    private String Id;

    public User(String id)
    {
        Id = id;
    }

    public String getId()
    {
        return Id;
    }
}
