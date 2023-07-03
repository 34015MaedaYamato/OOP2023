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
            DayOfWeek[] Week = { DayOfWeek.Sunday,DayOfWeek.Monday,DayOfWeek.Tuesday,DayOfWeek.Wednesday,DayOfWeek.Thursday,DayOfWeek.Friday,DayOfWeek.Saturday };
            
            for (int i = 0; i < Week.Length; i++) {
                Console.WriteLine("{0}の次の{1}です。",dateTime.ToString("D"),NextWeekDay(dateTime,Week[i]).ToString("ddd曜日は、yyyy年M月d日"));
            }
 
        }
        public static DateTime NextWeekDay(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            if (days <= 6) {
                days += 7;
            }
            return date.AddDays(days);
        }
    }
}
