package mediator.information;

public class LoginOrRegisterPackage extends InformationPackage{
    private String Id;
    private String Password;
    private String Name;

    public LoginOrRegisterPackage(String keyword,String id,String password)
    {
        super(InformationType.LOGIN,keyword);
        Id = id;
        Password = password;
    }

    public String getId() {
        return Id;
    }

    public String getPassword() {
        return Password;
    }
}
