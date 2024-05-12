namespace Watch
{
    /// <summary>
    /// Общий интерфейс для настроек часов.
    /// </summary>
    public interface ITimeSettings
    {
        public void GetTimeSettings(Time currentTime, Time realTime);
    }
}
