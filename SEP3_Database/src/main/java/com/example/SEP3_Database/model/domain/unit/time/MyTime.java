package com.example.SEP3_Database.model.domain.unit.time;

import javafx.scene.shape.HLineTo;

import java.sql.Timestamp;
import java.time.LocalDateTime;

public class MyTime {
    private int Year;
    private int Month;
    private int Day;
    private int Hour;
    private int Minute;

    public MyTime(LocalDateTime dateTime)
    {
        Year = dateTime.getYear();
        Month = dateTime.getMonthValue();
        Day = dateTime.getDayOfMonth();
        Hour = dateTime.getHour();
        Minute = dateTime.getMinute();
    }

    public MyTime(int year,int month,int day,int hour,int minute)
    {
        Year = year;
        Month = month;
        Day = day;
        Hour = hour;
        Minute = minute;
    }

    public int getMinute() {
        return Minute;
    }

    public void setMinute(int minute) {
        Minute = minute;
    }

    public int getHour() {
        return Hour;
    }

    public void setHour(int hour) {
        Hour = hour;
    }

    public int getDay() {
        return Day;
    }

    public void setDay(int day) {
        Day = day;
    }

    public int getMonth() {
        return Month;
    }

    public void setMonth(int month) {
        Month = month;
    }

    public int getYear() {
        return Year;
    }

    public void setYear(int year) {
        Year = year;
    }

    public String toString()
    {
        return Day + "/" + Month + "/" + Year + "-" + Hour + ":" + Minute;
    }

    public MyTime copy()
    {
        return new MyTime(Year,Month,Day,Hour,Minute);
    }

    public void setThroughDateTime(Timestamp dateTime)
    {
        int Y = dateTime.getYear();
        int M = dateTime.getMonth();
        int D = dateTime.getDay();
        int H = dateTime.getHours();
        int Mi = dateTime.getMinutes();
        Year = Y;
        Month = M;
        Day = D;
        Hour = H;
        Minute = Mi;
    }
}
