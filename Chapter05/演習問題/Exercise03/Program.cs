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
            int cnt = 0;
            foreach (var str in text) {
                if(str == ' ') {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            int cnt = 0;
            foreach (var str in text) {
                if (str == ' ') {
                    cnt++;
                }
            }
            Console.WriteLine(cnt+1);
        }

        private static void Exercise3_4(string text) {
            var words = text.Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words) {
                if(word.Length <= 4) {
                    Console.WriteLine(word);
                }
            }
        }

        private static void Exercise3_5(string text) {
            var sb = new StringBuilder();
            var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words) {
                if (Array.IndexOf(words, word) != words.Length - 1) {
                    sb.Append(word + ' ');
                }else { 
                    sb.Append(word);
                }
            }
            var Newtext = sb.ToString();
            Console.WriteLine(Newtext);
        }
    }
}
