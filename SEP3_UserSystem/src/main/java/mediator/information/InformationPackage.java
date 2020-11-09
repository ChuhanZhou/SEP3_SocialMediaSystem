package mediator.information;

public abstract class InformationPackage {
    private InformationType informationType;
    private String Keyword;

    public InformationPackage(InformationType informationType,String keyword)
    {
        this.informationType = informationType;
        Keyword = keyword;
    }

    public InformationType getInformationType()
    {
        return informationType;
    }

    public String getKeyword() {
        return Keyword;
    }

    @Override public String toString()
    {
        return "[" + informationType + "]";
    }
}
