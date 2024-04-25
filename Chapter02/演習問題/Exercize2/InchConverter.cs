using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize2 {
    public class InchConverter {
        //private const double ratio = 0.0254;    //定数
        public static readonly double ratio = 0.0254;   //  定数（外部にも公開する場合）

        //メートルからインチを求める
        public static double FromMeter(int meter) {
            return meter / ratio;
        }

        //フィートからインチを求める
        public static double ToMeter(int inch) {
            return inch * ratio;
        }


    }
}
