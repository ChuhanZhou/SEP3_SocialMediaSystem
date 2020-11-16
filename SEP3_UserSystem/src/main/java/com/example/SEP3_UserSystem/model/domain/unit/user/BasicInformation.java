package com.example.SEP3_UserSystem.model.domain.unit.user;

public abstract class BasicInformation extends User{
    private String UserName;
    private Birthday Birthday;
    private char Gender;
    private String Hometown;
    private int PhoneNumber;

    public BasicInformation(String id, String userName)
    {
        super(id);
        UserName = userName;
        Birthday = new Birthday();
        Gender = ' ';
        Hometown = "";
        PhoneNumber = -1;
    }

    public String getUserName() {
        return UserName;
    }

    public void setUserName(String userName) {
        UserName = userName;
    }

    public Birthday getBirthday() {
        return Birthday;
    }

    public void setBirthday(Birthday birthday) {
        Birthday = birthday;
    }

    public char getGender() {
        return Gender;
    }

    public void setGender(char gender) {
        Gender = gender;
    }

    public String getHometown() {
        return Hometown;
    }

    public void setHometown(String hometown) {
        Hometown = hometown;
    }

    public int getPhoneNumber() {
        return PhoneNumber;
    }

    public void setPhoneNumber(int phoneNumber) {
        PhoneNumber = phoneNumber;
    }

    public void update(String userName, Birthday birthday, char gender, String homeTown, int phoneNumber) {
        UserName = userName;
        Birthday = birthday;
        Gender = gender;
        Hometown = homeTown;
        PhoneNumber = phoneNumber;
    }
}
