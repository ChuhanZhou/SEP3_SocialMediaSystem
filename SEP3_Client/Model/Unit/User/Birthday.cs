namespace SEP3_Client.Model.Unit.User
{
    public class Birthday
    {
        public int Month { get; set; }
        public int Day { get; set; }

        public Birthday(int day,int month)
        {
            Month = month;
            Day = day;
        }

        public int GetDay() {
            return Day;
        }

        public int GetMonth() {
            return Month;
        }

        public void Set(int day,int month)
        {
            Month = month;
            Day = day;
        }

        public Birthday Copy()
        {
            return new Birthday(Day,Month);
        }
    }
}