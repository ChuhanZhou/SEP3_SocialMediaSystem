package com.example.SEP3_Database.jdbc;

import com.example.SEP3_Database.model.domain.unit.user.Birthday;

public class UserPure {
    private Birthday birthday;
    private String id;
    private String userName;
    private String password;
    private char gender;
    private String hometown;
    private long phoneNumber;
    public UserPure(String id, String userName, Birthday birthday, String password,char gender, String hometown, long phoneNumber)
    {
        this.gender = gender;
        this.hometown = hometown;
        this.phoneNumber = phoneNumber;
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

    public char getGender() {
        return gender;
    }

    public long getPhoneNumber() {
        return phoneNumber;
    }

    public void setGender(char gender) {
        this.gender = gender;
    }

    public void setHometown(String hometown) {
        this.hometown = hometown;
    }

    public void setPhoneNumber(long phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public String getHometown() {
        return hometown;
    }
}
