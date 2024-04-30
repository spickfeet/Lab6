Console.WriteLine("Введите начальное время в формате: Часы:минуты ");
string startTime = Console.ReadLine();
Console.WriteLine("Введите конечное время в формате: Часы:минуты ");
string endTime = Console.ReadLine();
string[] startMinAndHour = startTime.Split(":");
string[] endMinAndHour = endTime.Split(":");
int startMin = int.Parse(startMinAndHour[0]) * 60 + int.Parse(startMinAndHour[1]);
int endMin = int.Parse(endMinAndHour[0]) * 60 + int.Parse(endMinAndHour[1]);
if (endMin < startMin)
{
    Console.WriteLine(360*12 - (startMin - endMin) * 6);
    return;
}
Console.WriteLine($"Стрелку необходимо повернуть на: {(endMin - startMin) * 6} градусов");