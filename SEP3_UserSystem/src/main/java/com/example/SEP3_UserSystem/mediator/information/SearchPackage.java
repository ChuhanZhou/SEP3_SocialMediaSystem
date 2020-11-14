package com.example.SEP3_UserSystem.mediator.information;

public class SearchPackage extends InformationPackage{
    private String Id;

    public SearchPackage(String id,String keyword)
    {
        super(InformationType.SEARCH,keyword);
        Id = id;
    }

    public String getId() {
        return Id;
    }
}
