﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            // 3.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise1_4(numbers);
        }

        private static void Exercise1_1(List<int> numbers) {
            var exist = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);
            Console.WriteLine(exist);
        }

        private static void Exercise1_2(List<int> numbers) {
            //var halfNum = numbers.ConvertAll(s => s / 2.0);
            //halfNum.ForEach(s => Console.WriteLine(s));
            numbers.ForEach(s=> Console.WriteLine(s/2.0));
        }

        private static void Exercise1_3(List<int> numbers) {
            //IEnumerable<int> query = numbers.Where(s => s >= 50);
            //foreach (int num in query) {
            //    Console.WriteLine(num);
            //}
            numbers.Where(s => s >= 50).ToList().ForEach(s=> Console.WriteLine(s));
        }

        private static void Exercise1_4(List<int> numbers) {
            //IEnumerable<int> query = numbers.Select(s => s * 2);
            //List<int> twiceNum = query.ToList();
            //foreach(int num in twiceNum) {
            //    Console.WriteLine(num);
            //}
            numbers.Select(s => s * 2).ToList().ForEach(s => Console.WriteLine(s));
        }
    }
}
