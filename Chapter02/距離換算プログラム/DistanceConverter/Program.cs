using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {

        static void Main(string[] args) {
            

            if(args.Length >= 1 && args[0] == "-tom")
            {

                PrintFeetToMeterList(1,10);
                
            }
            else
            {
                PrintMeterToFeetList(1, 10);
                
            }
        }


        private static void PrintFeetToMeterList(int start,int stop) {
            FeetConverter feetConverter = new FeetConverter();
            //フィートからメートルへの対応表を出力
            for (int feet = start; feet <= stop; feet++) {
                double meter = feetConverter.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000}m", feet, meter);
            }
        }

        private static void PrintMeterToFeetList(int start, int stop) {
            FeetConverter feetConverter = new FeetConverter();
            //メートルからフィートへの対応表を出力
            for (int meter = start; meter <= stop; meter++) {
                double feet = feetConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000}ft", meter, feet);
            }
        }
    }
}
