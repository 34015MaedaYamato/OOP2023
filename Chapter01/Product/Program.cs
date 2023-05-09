using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    
    class Program {
        static void Main(string[] args){

            #region P26のサンプルプログラム
            //インスタンスの生成
            //Product karinto = new Product(123,"かりんとう",180);
            //Product daifukumoti = new Product(235,"大福もち",160);

            //Console.WriteLine("かりんとう："+karinto.GetPriceIncludingTax());
            //Console.WriteLine("大福もち："+daifukumoti.GetPriceIncludingTax());
            #endregion

            #region 0508演習1
            //DateTime date = new DateTime(2023, 5, 8);
            /*
            DateTime date = DateTime.Today;
            Console.WriteLine("今日の日付：" + +date.Year + "年" + date.Month + "月" + date.Day + "日");

            //10日後を求める
            DateTime daysAfter10 = date.AddDays(10);
            Console.WriteLine("10日後：" + daysAfter10.Year + "年" + daysAfter10.Month + "月" + daysAfter10.Day + "日");

            //10日前を求める
            DateTime daysBefore10 = date.AddDays(-10);
            Console.WriteLine("10日前：" + daysBefore10.Year + "年" + daysBefore10.Month + "月" + daysBefore10.Day + "日");
            */
            #endregion

            #region 0508演習2
            /*
            Console.WriteLine("誕生日を入力");
            Console.Write("西暦：");
            int Year = int.Parse(Console.ReadLine());
            Console.Write("月：");
            int Month = int.Parse(Console.ReadLine());
            Console.Write("日：");
            int Day = int.Parse(Console.ReadLine());

            DateTime date = DateTime.Today;
            DateTime bd = new DateTime(Year, Month, Day);
            TimeSpan interval = date - bd;
            Console.WriteLine("あなたが生まれてから今日で"+interval.Days+"日です。");
            */
            #endregion

            #region 0509演習3
            Console.WriteLine("誕生日を入力");
            Console.Write("西暦：");
            int Year = int.Parse(Console.ReadLine());
            Console.Write("月：");
            int Month = int.Parse(Console.ReadLine());
            Console.Write("日：");
            int Day = int.Parse(Console.ReadLine());

            DateTime bd = new DateTime(Year, Month, Day);
            DayOfWeek bdOfWeek = bd.DayOfWeek;

            String dd = null;

            switch (bdOfWeek) {
                case DayOfWeek.Sunday:
                    dd = "日";
                    break;
                case DayOfWeek.Monday:
                    dd = "月";
                    break;
                case DayOfWeek.Tuesday:
                    dd = "火";
                    break;
                case DayOfWeek.Wednesday:
                    dd = "水";
                    break;
                case DayOfWeek.Thursday:
                    dd = "木";
                    break;
                case DayOfWeek.Friday:
                    dd = "金";
                    break;
                case DayOfWeek.Saturday:
                    dd = "土";
                    break;
            }

            Console.WriteLine("あなたが生まれた日は" + dd + "曜日です。");

            #endregion


        }
    }
}
