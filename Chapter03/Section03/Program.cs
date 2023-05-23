using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03 {
    class Program {
        static void Main(string[] args) {
            var list = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            var exists = list.Exists(s => s[0] == 'A');
            Console.WriteLine(exists);

            var name = list.Find(s => s.Length == 6);
            Console.WriteLine(name);

            var index = list.FindIndex(s => s == "London");
            Console.WriteLine(index);

            var names = list.FindAll(s => s.Length <= 6);
            names.ForEach(s => Console.WriteLine(s));
            //foreach (var s in findAll) {
            //    Console.WriteLine(s);
            //}

            var lowerList = list.ConvertAll(s => s.ToLower());
            lowerList.ForEach(s => Console.WriteLine(s));




        }
    }
}
