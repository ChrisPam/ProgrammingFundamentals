using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double takenPictures = double.Parse(Console.ReadLine());

        double filterTime = double.Parse(Console.ReadLine());
        double filterFactor = double.Parse(Console.ReadLine());
        double uploadTime = double.Parse(Console.ReadLine());

        double filtredPictures = Math.Ceiling(takenPictures * filterFactor / 100.0);
        double totalFilterTime = takenPictures * filterTime;
        double totalUploadTime = filtredPictures * uploadTime;

        double totalTime = totalFilterTime + totalUploadTime;

        TimeSpan time = TimeSpan.FromSeconds(totalTime);

        string answer = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                        time.Days,
                        time.Hours,
                        time.Minutes,
                        time.Seconds);
        Console.WriteLine(answer);

    }
}
