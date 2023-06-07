using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hours and minutes of the clock in the following format: (H:M)");
            string time = Console.ReadLine();
            int hour = Convert.ToInt32(time.Split(':')[0]);
            int minute = Convert.ToInt32(time.Split(':')[1]);
            Console.WriteLine(Calculate(hour, minute));
        }

        static double Calculate(int h, int m)
        {
            double angle = Math.Abs(30 * (h%12) - (11.0 * m) / 2.0);  // 0.5 * (60 * H + M) - 6 * M
            return Math.Min(angle, 360 - angle); // Clockwise and counterclockwise.
        }
    }
}
