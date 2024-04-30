using Watch;


Console.WriteLine("Введите время на часах в формате: Часы:минуты ");
string currentTimeString= Console.ReadLine();
Console.WriteLine("Введите реальное время в формате: Часы:минуты ");
string realTimeString = Console.ReadLine();
string[] currentTimeMass = currentTimeString.Split(":");
string[] realTimeMass = realTimeString.Split(":");
Time currentTime = new(int.Parse(currentTimeMass[0]), int.Parse(currentTimeMass[1]));
Time realTime = new(int.Parse(realTimeMass[0]), int.Parse(realTimeMass[1]));
ITimeSettings timeSettings = new WatchWithHandsAdapter(new WatchWithHands());
ITimeSettings timeSettingsDigital = new WatchDigital();
timeSettings.GetTimeSettings(currentTime, realTime);
timeSettingsDigital.GetTimeSettings(currentTime, realTime);
