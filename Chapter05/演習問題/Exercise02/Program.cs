using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("数字を入力：");
            
            if(int.TryParse(Console.ReadLine(),out int num)) {
                Console.WriteLine("{0:#,#}",num);
            } else {
                Console.WriteLine("数字文字列ではありません。");
            }
            
        }
    }
}
