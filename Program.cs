using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            if (weekNum % 2 == 0)
            {
                Console.WriteLine("четное");// четное
            }
            else
            {
                Console.WriteLine("не четное");// не четное
            }
        }
        DateTime dt = DateTime.Parse(Console.ReadLine());
        int weekNum = GetWeekNumber(dt);

        public int GetWeekNumber(DateTime dt)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dt, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }
    }
}
