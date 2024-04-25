using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize2 {
    internal class YardConverter {
        //private const double ratio = 0.9144;    //定数
        public static readonly double ratio = 0.9144;   //  定数（外部にも公開する場合）

        //メートルからヤードを求める
        public static double FromMeter(int meter) {
            return meter / ratio;
        }

        //ヤードからインチを求める
        public static double ToMeter(int yard) {
            return yard * ratio;
        }

    }
}
