package com.example.SEP3_UserSystem.mediator.information;

public class ErrorPackage extends InformationPackage{
    private boolean Error;

    public ErrorPackage(String errorMessage,boolean error)
    {
        super(InformationType.ERROR,errorMessage);
        Error = error;
    }

    public boolean isError() {
        return Error;
    }
}
