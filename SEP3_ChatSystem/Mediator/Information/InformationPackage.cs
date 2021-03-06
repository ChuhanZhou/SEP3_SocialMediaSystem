﻿namespace SEP3_ChatSystem.Mediator.Information
{
    public class InformationPackage
    {
        public InformationType informationType { get; set; }
        public string Keyword { get; set; }

        public InformationPackage(InformationType informationType,string keyword)
        {
            this.informationType = informationType;
            Keyword = keyword;
        }

        public InformationPackage() {}

        public InformationType GetInformationType()
        {
            return informationType;
        }

        public string GetKeyword() {
            return Keyword;
        }

        public override string ToString()
        {
            return "[" + informationType + "]";
        }
    }
}