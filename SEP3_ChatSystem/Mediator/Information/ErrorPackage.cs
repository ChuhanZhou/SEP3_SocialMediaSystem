namespace SEP3_ChatSystem.Mediator.Information
{
    public class ErrorPackage : InformationPackage
    {
        public bool Error { get; set; }

        public ErrorPackage(string errorMessage,bool error) : base(InformationType.ERROR,errorMessage)
        {
            Error = error;
        }

        public ErrorPackage() {}

        public bool IsError() {
            return Error;
        }
    }
}