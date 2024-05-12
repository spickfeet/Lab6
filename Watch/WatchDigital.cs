namespace Watch
{
    /// <summary>
    /// Класс настроек цифровых часов.
    /// </summary>
    public class WatchDigital : ITimeSettings
    {
        /// <summary>
        /// Метод для настройки цифровых часов.
        /// </summary>
        /// <param name="currentTime"></param>
        /// <param name="realTime"></param>
        public void GetTimeSettings(Time currentTime, Time realTime)
        {
            Console.WriteLine($"Переведите часы на:\n{realTime.Hour - currentTime.Hour} часов(а)\n{realTime.Minute - currentTime.Minute} минут(ы)");
        }
    }
}
