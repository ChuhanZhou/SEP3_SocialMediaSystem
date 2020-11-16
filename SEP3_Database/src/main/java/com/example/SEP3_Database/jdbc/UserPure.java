package com.example.SEP3_Database.jdbc;

import com.example.SEP3_Database.model.domain.unit.user.Birthday;

public class UserPure {
    private Birthday birthday;
    private String id;
    private String userName;
    private String password;

    public UserPure(String id, String userName, Birthday birthday, String password)
    {
        this.birthday = birthday;
        this.id = id;
        this.userName = userName;
        this.password = password;
    }

    public void setBirthday(Birthday birthday) {
        this.birthday = birthday;
    }

    public String getUserName() {
        return userName;
    }

    public Birthday getBirthday() {
        return birthday;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getId() {
        return id;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public void setUserName(String userName) {
        this.userName = userName;
    }
}
