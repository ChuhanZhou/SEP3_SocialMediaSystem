namespace SEP3_Client.Mediator.Information
{
    public class SearchPackage : InformationPackage
    {
        public string Id { get; set; }

        public SearchPackage(string id, string keyword) : base(InformationType.SEARCH, keyword)
        {
            Id = id;
        }

        public SearchPackage() {}

        public string GetId()
        {
            return Id;
        }
    }
}