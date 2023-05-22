using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("**売り上げ集計**");
            Console.WriteLine("1．店舗別売上");
            Console.WriteLine("2．商品カテゴリー別売上");
            Console.Write(">");
            int select = int.Parse(Console.ReadLine());

            var sales = new SalesCounter(@"data\sales.csv");

            switch (select) {
                case 1:
                    var amountPerStore = sales.GetPerStoreSales();
                    foreach (var obj in amountPerStore) {
                        Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
                    }
                    break;
                case 2:
                    var amountPerCategory = sales.GetPerCategorySales();
                    foreach (var obj in amountPerCategory) {
                        Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
                    }
                    break;

            }
        }
    }
}
