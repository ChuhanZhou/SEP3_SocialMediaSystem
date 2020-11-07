package information;

public class InformationPackage {
    private InformationType informationType;

    public InformationPackage(InformationType informationType)
    {
        this.informationType = informationType;
    }

    public InformationType getInformationType()
    {
        return informationType;
    }

    @Override public String toString()
    {
        return "[" + informationType + "]";
    }
}
