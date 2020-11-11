package com.example.SEP3_UserSystem.mediator.information;

public class LoginOrRegisterPackage extends InformationPackage{
    private String Id;
    private String Password;
    private String Name;

    public LoginOrRegisterPackage(String keyword,String idOrName,String password)
    {
        super(InformationType.LOGIN,keyword);
        switch (keyword)
        {
            case "login":
                Id = idOrName;
                break;
            case "register":
                Name = idOrName;
                break;
            default:
                break;
        }
        Password = password;
    }

    public String getId() {
        return Id;
    }

    public String getPassword() {
        return Password;
    }

    public String getName() {
        return Name;
    }
}
