using Section01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(b => b.Price);
            var book = Library.Books.First(b => b.Price == max);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
        
        }

        private static void Exercise1_4() {
        
        }

        private static void Exercise1_5() {
        
        }

        private static void Exercise1_6() {
        
        }

        private static void Exercise1_7() {
        
        }

        private static void Exercise1_8() {
        
        }
    }
}
