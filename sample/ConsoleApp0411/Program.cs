using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args){

            Console.Write("何個：");
            int count = int.Parse(Console.ReadLine());


            for (int i = 0; i < count; i++) {

                for (int k = 0; k < count-(i+1); k++) {
                    Console.Write(" ");
                }


                for (int j = 0; j < (i+1); j++) {
                    Console.Write("*");
                }

                Console.WriteLine();

            }




        }
    }
}
