package model.domain.unit.user;

import java.util.Date;

public abstract class BasicInformation extends User{
    private String UserName;
    private Date Birthday;

    public BasicInformation(String id, String userName)
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
}
