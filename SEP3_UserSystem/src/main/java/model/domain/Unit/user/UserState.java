package model.domain.unit.user;

public class UserState {
    private boolean IsOnline;
    private String State;

    public UserState()
    {
        IsOnline = false;
    }

    public void login()
    {
        IsOnline = true;
        State = "online";
    }

    public void logoff()
    {
        IsOnline = false;
    }

    public void setState(String state) {
        State = state;
    }

    public String getState() {
        if (IsOnline)
        {
            return "[" + State + "]";
        }
        else
        {
            return "[offline]";
        }
    }

    public boolean isOnline() {
        return IsOnline;
    }
}
