namespace Watch
{
    /// <summary>
    /// Класс адаптер для стрелочных часов.
    /// </summary>
    public class WatchWithHandsAdapter : ITimeSettings
    {
        private WatchWithHands _watchWithHands;
        public WatchWithHandsAdapter(WatchWithHands watchWithHands)
        {
            _watchWithHands = watchWithHands;
        }

        /// <summary>
        /// Метод адаптер.
        /// </summary>
        /// <param name="currentTime"></param>
        /// <param name="realTime"></param>
        public void GetTimeSettings(Time currentTime, Time realTime)
        {
            _watchWithHands.GetAngleOfRotation(currentTime, realTime);
        }
    }
}
