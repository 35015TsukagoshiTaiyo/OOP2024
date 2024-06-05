using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    internal class Program {
        static void Main(string[] args) {
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            string[] pairs = line.Split(';');
            foreach (string pair in pairs) {
                string[] keyValue = pair.Split('=');
                Console.WriteLine(ToJapanese(keyValue[0]) + keyValue[1]);
            }
        }

        //できたら以下のメソッドを完成させて利用する
        static string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家：";
                case "BestWork":
                    return "代表作：";
                case "Born":
                    return "誕生年：";
            }
            throw new ArgumentException("引数に誤りがあります");
        }
    }
}
