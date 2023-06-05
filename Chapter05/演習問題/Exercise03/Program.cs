using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);

        }

        private static void Exercise3_1(string text) {
            int cnt = text.Count(c => c == ' ');
            Console.WriteLine(cnt);

            //int cnt = 0;
            //foreach (var str in text) {
            //    if(str == ' ') {
            //        cnt++;
            //    }
            //}
            //Console.WriteLine(cnt);
        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            String[] words = text.Split(' ');
            Console.WriteLine(words.Length);

            //int cnt = 0;
            //foreach (var str in text) {
            //    if (str == ' ') {
            //        cnt++;
            //    }
            //}
            //Console.WriteLine(cnt+1);


            //解説
            //int count = text.Split(' ').Length;
            //Console.WriteLine(count);
        }

        private static void Exercise3_4(string text) {
            var words = text.Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words) {
                if(word.Length <= 4) {
                    Console.WriteLine(word);
                }
            }

            //解説
            //var words = text.Split(' ').Where(word => word.Length <= 4);
            //foreach (var word in words)
            //    Console.WriteLine(word);   
            
        }

        private static void Exercise3_5(string text) {
            var sb = new StringBuilder();
            var words = text.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries); 
            foreach (var word in words) {
                if (Array.IndexOf(words, word) != words.Length - 1) {
                    sb.Append(word + ' ');
                }else { 
                    sb.Append(word);
                }
            }
            var Newtext = sb.ToString();
            Console.WriteLine(Newtext);

            //解説
            //if(Array.Length > 0) {
            //  text.Split(' ').ToArray();
            //  var sb = new StringBuilder(array[0]);
            //  foreach(var word in array.Skip(1)){
            //      sb.Append(' ');
            //      sb.Append(word);
            //  }
            //  var Newtext = sb.ToString();
            //  Console.WriteLine(Newtext);
            //}
        }
    }
}
