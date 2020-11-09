package model.domain.User;

import java.util.Date;

public abstract class UserInformation extends User{
    private String UserName;
    private Date Birthday;

    public UserInformation(String id,String userName)
    {
        super(id);
        UserName = userName;
    }

    public String getUserName() {
        return UserName;
    }

    public void setUserName(String userName) {
        UserName = userName;
    }

    public Date getBirthday() {
        return Birthday;
    }

    public void setBirthday(Date birthday) {
        Birthday = birthday;
    }

    public void update(String userName,Date birthday) {
        UserName = userName;
        Birthday = birthday;
    }

    @Override
    public abstract UserInformation copy();
}
