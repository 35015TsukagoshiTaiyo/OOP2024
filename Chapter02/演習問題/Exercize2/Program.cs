﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize2 {
    public class Program {
        static void Main(string[] args) {

            if (args.Length >= 1 && args[0] == "-tom") {
                //インチからメートルへの対応表を出力
                PrintInchToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                //メートルからインチへの対応表を出力
                PrintMeterToInchList(int.Parse(args[1]), int.Parse(args[2]));
            }
        }

        //インチからメートルへの対応表を出力
        private static void PrintInchToMeterList(int start, int stop) {
            for (int inch = start; inch <= stop; inch++) {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0}inch = {1:0.0000} m", inch, meter);
            }
        }
        //メートルからインチへの対応表を出力
        private static void PrintMeterToInchList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double inch = InchConverter.FromMeter(meter);
                Console.WriteLine("{0}m = {1:0.0000} inch", meter, inch);
            }
        }


    }
}
