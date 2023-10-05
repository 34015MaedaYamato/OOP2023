using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Pickup3DigitNumber("sample.txt");
        }

        private static void Pickup3DigitNumber(string file) {
            foreach (var line in File.ReadLines(file)) {
                string[] texts = Regex.Split(line, @"\s");
                foreach (var text in texts) {
                    var match = Regex.Match(text, @"^\d{3,}$");
                    if (match.Success)
                        Console.WriteLine(text);
                }
            }

            //先生
            /*foreach (var line in File.ReadLines(file)) {
                var matches = Regex.Matches(line, @"\b\d{3,}\b");
                foreach (var match in matches) {
                    Console.WriteLine(match);
                }
            }*/


        }
    }
}
