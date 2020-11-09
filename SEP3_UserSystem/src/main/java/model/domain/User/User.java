package model.domain.User;

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

    public abstract User copy();
}
