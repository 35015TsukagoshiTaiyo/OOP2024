﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ColorChecker {
    public struct MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
        public override string ToString() {
            //return $"R:{Color.R}  G:{Color.G}  B:{Color.B}";
            return string.Format("R:{0,3}  G:{1,3}  B:{2,3}", Color.R, Color.G, Color.B);
        }
        //同じ色でもそれぞれnewされると参照番地が違うから
        //色が同じなら等しいとする
        public override bool Equals(object obj) {
            if (obj is MyColor other) {
                return this.Color == other.Color;
            }
            return false;
        }
        //Equalsメソッドとセットでoverrideする
        public override int GetHashCode() {
            return Color.GetHashCode();
        }
    }
}
