// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

long ticks = 0;
var time = "73:54:00";

var timeSpan = new TimeSpan(int.Parse(time.Split(':')[0]),    // hours
                           int.Parse(time.Split(':')[1]),    // minutes
                           0);
Console.WriteLine($"Pars to TimeSpan: {timeSpan}");

ticks = timeSpan.Ticks;
Console.WriteLine($"Get ticks from timeSpan: {ticks}");

TimeSpan newTimeSpan = new TimeSpan(ticks);
Console.WriteLine($"ticks is: {newTimeSpan}");

var totalWorkedTime = string.Format("{0}:{1}:{2}", newTimeSpan.Days * 24 + newTimeSpan.Hours, newTimeSpan.Minutes, newTimeSpan.Seconds);
Console.WriteLine($"timespan is: {totalWorkedTime}"); // 73:19:48

Console.ReadKey() ;