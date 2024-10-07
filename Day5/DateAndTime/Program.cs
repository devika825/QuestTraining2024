using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt);

            //DateTime dtu = DateTime.UtcNow;
            //Console.WriteLine(dtu);

            //Console.WriteLine($"Day: {dt.Day}");
            //Console.WriteLine($"Month: {dt.Month}");
            //Console.WriteLine($"Year: {dt.Year}");

            //Console.WriteLine($"Hour: {dt.Hour}");
            //Console.WriteLine($"Minute: {dt.Minute}");
            //Console.WriteLine($"Second: {dt.Second}");
            //Console.WriteLine($"Millisecond: {dt.Millisecond}");

            ////Date time operation

            ////Add days

            //var tenDaysFromNow = dt.AddDays(10);
            //Console.WriteLine(tenDaysFromNow);

            //var tenDaysFromNowAftertwentyHour = dt.AddDays(10).AddHours(20);
            //Console.WriteLine(tenDaysFromNowAftertwentyHour);

            ////Formatting the output

            //Console.WriteLine("------");
            //Console.WriteLine($"Standard Output: {dt}");

            //Console.WriteLine(dt.ToString("dd-MM-yyyy hh:mm:ss"));
            //Console.WriteLine(dt.ToString("MM-dd-yyyy hh:mm;ss"));
            //Console.WriteLine(dt.ToString("MM/dd/yyyy hh:mm:ss"));
            //Console.WriteLine(dt.ToString("MM-dd-yyyy"));
            //Console.WriteLine(dt.ToString("hh:mm:ss"));

            //constructing date and time
            var myDt = new DateTime(2024, 10, 7, 10, 49,0);
            Console.WriteLine($"My Date and time : {myDt}");

        }
    }
}
