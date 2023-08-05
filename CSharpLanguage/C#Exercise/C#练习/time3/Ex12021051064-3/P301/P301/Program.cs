using System;
namespace P301
{
    class Program1
    {
        enum weekday
        {
            Sun,Mon=5,Tue,Wed,Thu=10,Fri,Sat=15
        }

        static void Main()
        {
            int day1= (int)weekday.Sun;
            int day2 = (int)weekday.Mon;
            int day3 = (int)weekday.Tue;
            int day4 = (int)weekday.Wed;
            int day5 = (int)weekday.Thu;
            int day6 = (int)weekday.Fri;
            int day7 = (int)weekday.Sat;
            Console.WriteLine("Sun={0}",day1);
            Console.WriteLine("Mon={0}",day2);
            Console.WriteLine("Tue={0}",day3);
            Console.WriteLine("Wed={0}",day4);
            Console.WriteLine("Thu={0}",day5);
            Console.WriteLine("Fri={0}",day6);
            Console.WriteLine("Sat={0}",day7);
            Console.ReadKey();
        }
    }
}