using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411_2 {
    class Program {
        static void Main(string[] args) {
            //int man = 0, sen = 0, gohyaku = 0, hyaku = 0, gojyu = 0, jyu = 0, go = 0, iti = 0;
            string[] moneyName = { "一万円札", "五千円札", "　千円札", "五百円玉", "　百円玉", "五十円玉", "　十円玉", "　五円玉", "　一円玉" };
            int[] moneyInt = { 10000, 5000, 1000, 500, 100, 50, 10, 5, 1 };

            Console.Write("合計金額：");
            int money = int.Parse(Console.ReadLine());

            Console.Write("支払い金額：");
            int pay = int.Parse(Console.ReadLine());

            int change = pay - money;
            Console.WriteLine("お釣り："+change);



            for (int i = 0; i < moneyName.Length; i++) {
                Console.WriteLine(moneyName[i] + "：{0}枚", change / moneyInt[i]);
                change %= moneyInt[i];
            }

            /*
            if (money >= 10000) {
                man = money / 10000;
                money %= 10000;
            }
            if (money >= 1000) {
                sen = money / 1000;
                money %= 1000;
            }
            if (money >= 500) {
                gohyaku = money / 500;
                money %= 500;
            }
            if (money >= 100) {
                hyaku = money / 100;
                money %= 100;
            }
            if (money >= 50) {
                gojyu = money / 50;
                money %= 50;
            }
            if (money >= 10) {
                jyu = money / 10;
                money %= 10;
            }
            if (money >= 5) {
                go = 1;
                money %= 5;
            }
            iti = money;

            Console.WriteLine("一万円" + man + "枚");
            Console.WriteLine("千円" + sen + "枚");
            Console.WriteLine("五百円" + gohyaku + "枚");
            Console.WriteLine("百円" + hyaku + "枚");
            Console.WriteLine("五十円" + gojyu + "枚");
            Console.WriteLine("十円" + jyu + "枚");
            Console.WriteLine("五円" + go + "枚");
            Console.WriteLine("一円" + iti + "枚");
            */
        }
        private static void Asu(int count){
            for (int i = 0; i < count; i++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
