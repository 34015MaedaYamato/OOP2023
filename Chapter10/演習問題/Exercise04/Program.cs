using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            var lines = File.ReadAllLines("sample.txt");
            foreach(var line in lines) {
                var pattern = @"(V|v)arsion\s*=\s*"v4.0"";
                var replaced = Regex.Replace(line,pattern, "varsion="v5.0"");
                File.WriteAllLines("sample.txt");
            }

            // これ以降は確認用
            var text = File.ReadAllText("sample.txt");
            Console.WriteLine(text);
        }
    }
}
