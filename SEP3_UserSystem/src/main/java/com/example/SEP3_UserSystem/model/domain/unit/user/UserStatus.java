package com.example.SEP3_UserSystem.model.domain.unit.user;

public class UserStatus {
    private boolean Online;
    private String Status;

    public UserStatus()
    {
        Online = false;
    }

    private UserStatus(boolean online, String status)
    {
        Online = online;
        Status = status;
    }

    public void login()
    {
        Online = true;
        Status = "online";
    }

    public void logoff()
    {
        Online = false;
    }

    public void setStatus(String status) {
        Status = status;
    }

    public String getStatus() {
        if (Online)
        {
            return "[" + Status + "]";
        }
        else
        {
            return "[offline]";
        }
    }

    public boolean isOnline() {
        return Online;
    }

    public UserStatus copy()
    {
        return new UserStatus(Online,Status);
    }
}
