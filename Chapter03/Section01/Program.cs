﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {

        static void Main(string[] args) {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            //int count = numbers.Count(n => n >= 3 && n < 8); //３以上８未満
            //int count = numbers.Count(n => n.ToString().Contains('1')); //１を含む
            //int count = numbers.Count(n => n % 5 == 0 && n >= 0); //５の倍数
            //合計
            //var sum = numbers.Where(n => n % 2 == 0).Sum();
            //平均
            var ave = numbers.Where(n => n % 2 == 0).Average();
            Console.WriteLine(ave);
        }
    }
}
