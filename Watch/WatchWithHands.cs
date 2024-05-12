namespace Watch
{
    /// <summary>
    /// Класс настроек стрелочных часов.
    /// </summary>
    public class WatchWithHands
    {
        /// <summary>
        /// Настройка стрелочных часов, возвращяет угол поворота минутной стрелки для настройки времени.
        /// </summary>
        /// <param name="currentTime"></param>
        /// <param name="realTime"></param>
        public void GetAngleOfRotation(Time currentTime,Time realTime)
        {
            int currentMin = currentTime.Hour * 60 + currentTime.Minute;
            int realMin = realTime.Hour * 60 + realTime.Minute;
            if (realMin < currentMin)
            {
                Console.WriteLine(360 * 12 - (currentMin - realMin) * 6);
                return;
            }
            Console.WriteLine($"Стрелку необходимо повернуть на: {(realMin - currentMin) * 6} градусов");
        }
    }
}
