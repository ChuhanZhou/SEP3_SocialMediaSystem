package mediator.information;

public class ErrorPackage extends InformationPackage{
    private boolean IsError;

    public ErrorPackage(String error,boolean isError)
    {
        super(InformationType.ERROR,error);
        IsError = isError;
    }

    public boolean isError() {
        return IsError;
    }
}
