﻿using System;
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

            foreach (var line in lines) {
                lines[Array.IndexOf(lines,line)] = Regex.Replace(line,@"\b(V|v)ersion\s*=\s*""v4.0""", @"version=""v5.0""");
            }
            File.WriteAllLines("sample.txt",lines);

            //先生
            //var newline = lines.Select(s => Regex.Replace(s, @"\b(v|V)ersion\s*=\s*""v4.0""", @"version=""v5.0"""));
            //File.WriteAllLines("sample.txt", newline);

            // これ以降は確認用
            var text = File.ReadAllText("sample.txt");
            Console.WriteLine(text);
        }
    }
}
