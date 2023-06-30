using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var dateTime = DateTime.Now;
            //var dateTime = new DateTime(2023,6,18);
            Console.WriteLine(NextWeekDay(dateTime, DayOfWeek.Saturday));
        }
        public static DateTime NextWeekDay(DateTime date,DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            if (days <= 6) {
                days += 7;
            }
            return date.AddDays(days);
        }
    }
}
