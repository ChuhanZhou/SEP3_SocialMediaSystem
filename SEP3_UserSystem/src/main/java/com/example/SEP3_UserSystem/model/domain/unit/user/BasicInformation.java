package com.example.SEP3_UserSystem.model.domain.unit.user;

public abstract class BasicInformation extends User{
    private String UserName;
    private Birthday Birthday;
    private char Gender;
    private String Hometown;
    private long PhoneNumber;

    public BasicInformation(String id, String userName)
    {
        super(id);
        UserName = userName;
        Birthday = new Birthday();
        Gender = ' ';
        Hometown = "";
        PhoneNumber = -1;
    }

    public BasicInformation(BasicInformation basicInformation)
    {
        super(basicInformation);
        UserName = basicInformation.UserName;
        Birthday = basicInformation.Birthday.copy();
        Gender = basicInformation.Gender;
        Hometown = basicInformation.Hometown;
        PhoneNumber = basicInformation.PhoneNumber;
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

    public long getPhoneNumber() {
        return PhoneNumber;
    }

    public void setPhoneNumber(int phoneNumber) {
        PhoneNumber = phoneNumber;
    }

    public void update(String userName, Birthday birthday, char gender, String homeTown, long phoneNumber) {
        UserName = userName;
        Birthday = birthday;
        Gender = gender;
        Hometown = homeTown;
        PhoneNumber = phoneNumber;
    }

    public void update(BasicInformation basicInformation) {
        UserName = basicInformation.UserName;
        Birthday = basicInformation.Birthday;
        Gender = basicInformation.Gender;
        Hometown = basicInformation.Hometown;
        PhoneNumber = basicInformation.PhoneNumber;
    }
}
