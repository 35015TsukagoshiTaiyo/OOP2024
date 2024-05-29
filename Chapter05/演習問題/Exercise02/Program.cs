using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("数字を入力：");
            var str = Console.ReadLine();
            int num;

            if (int.TryParse(str, out num)) {
                string numStr = String.Format("{0:N0}", num);
                Console.WriteLine(numStr);
            }
            
            

        }
    }
}
