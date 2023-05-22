using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {

        //public delegate bool judgement(int value); //デリゲートの宣言

        static void Main(string[] args) {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 10, 4 };
            //judgement judge = IsEven;
            int count = Count(numbers,delegate(int n){ return n % 2 == 0; });
            Console.WriteLine(count);
        }


        static public bool IsEven(int n) {
            return n % 2 == 0;
        }


        static public int Count(int[] numbers,Predicate<int> judge) {
            int cnt = 1;
            foreach (var n in numbers) {
                if(judge(n) == true) {
                    cnt++;
                }
            }
            /*
            for (int i = 0 ; i < numbers.Length ; i++) {
                if(numbers[i] == num) {
                    cnt++;
                }
            }*/
            return cnt;
        }
    }
}
