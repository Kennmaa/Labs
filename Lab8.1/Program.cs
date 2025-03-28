using System;

class SimpleAlarmClock
{
    static void Main()
    {
        // 1
        Console.WriteLine("Введите время (формат ЧЧ:ММ:СС.ммм):");
        if (!TimeSpan.TryParse(Console.ReadLine(), out TimeSpan time))
        {
            Console.WriteLine("Ошибка формата времени!");
            return;
        }

        Console.WriteLine($"\nРазбор времени:\nЧасы: {time.Hours}\nМинуты: {time.Minutes}\nСекунды: {time.Seconds}\nМиллисекунды: {time.Milliseconds}");

        // 2
        Console.WriteLine("\nВведите время будильника (формат ЧЧ:ММ):");
        if (!TimeSpan.TryParse(Console.ReadLine(), out TimeSpan alarmTime))
        {
            Console.WriteLine("Ошибка формата будильника!");
            return;
        }

        DateTime now = DateTime.Now;
        DateTime alarm = now.Date.Add(alarmTime);

        if (alarm < now) alarm = alarm.AddDays(1);

        Console.WriteLine($"\nДо будильника: {(int)(alarm - now).TotalMinutes} мин.");
        Console.WriteLine($"Сработает на {alarmTime.Hours * 60 + alarmTime.Minutes} минуте суток.");
    }
}
