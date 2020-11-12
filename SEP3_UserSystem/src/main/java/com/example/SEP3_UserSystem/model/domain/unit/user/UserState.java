package com.example.SEP3_UserSystem.model.domain.unit.user;

public class UserState {
    private boolean Online;
    private String State;

    public UserState()
    {
        Online = false;
    }

    private UserState(boolean online,String state)
    {
        Online = online;
        State = state;
    }

    public void login()
    {
        Online = true;
        State = "online";
    }

    public void logoff()
    {
        Online = false;
    }

    public void setState(String state) {
        State = state;
    }

    public String getState() {
        if (Online)
        {
            return "[" + State + "]";
        }
        else
        {
            return "[offline]";
        }
    }

    public boolean isOnline() {
        return Online;
    }

    public UserState copy()
    {
        return new UserState(Online,State);
    }
}
