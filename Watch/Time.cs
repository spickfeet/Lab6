namespace Watch
{
    /// <summary>
    /// Класс хранящий время.
    /// </summary>
    public class Time
    {
        private int _hour;
        private int _minute;
        
        public int Minute
        {
            get { return _minute; }
            set { _minute = value; }
        }
        public int Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }
        public Time(int hour,int min)
        {
            Minute = min;
            Hour = hour;
        }
    }
}
