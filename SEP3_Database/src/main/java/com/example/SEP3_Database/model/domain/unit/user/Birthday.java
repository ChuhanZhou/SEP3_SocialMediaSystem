package com.example.SEP3_Database.model.domain.unit.user;

public class Birthday {
    private int Month;
    private int Day;

    public Birthday(int day,int month)
    {
        Month = month;
        Day = day;
    }

    public int getDay() {
        return Day;
    }

    public int getMonth() {
        return Month;
    }

    public void set(int day,int month)
    {
        Month = month;
        Day = day;
    }

    public Birthday copy()
    {
        return new Birthday(Day,Month);
    }
}
