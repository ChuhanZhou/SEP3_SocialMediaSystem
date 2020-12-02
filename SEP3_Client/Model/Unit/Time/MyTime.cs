using System;

namespace SEP3_Client.Model.Unit.Time
{
    public class MyTime
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }

        public MyTime(DateTime dateTime)
        {
            Year = dateTime.Year;
            Month = dateTime.Month;
            Day = dateTime.Day;
            Hour = dateTime.Hour;
            Minute = dateTime.Minute;
        }
        
        public MyTime(){}

        public string ToString()
        {
            return Day + "/" + Month + "/" + Year + "-" + Hour + ":" + Minute;
        }
    }
}