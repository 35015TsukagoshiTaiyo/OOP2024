using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            #region p204
            //var dt1 = new DateTime(2024, 6, 19);
            //var dt2 = new DateTime(2010, 3, 12, 8, 45, 20);
            //Console.WriteLine(dt1);
            //Console.WriteLine(dt2);


            //var today = DateTime.Today;
            //var now = DateTime.Now;
            //Console.WriteLine("Today : {0}", today);
            //Console.WriteLine("Now : {0}", now);

            //var isLeapYear = DateTime.IsLeapYear(2024);
            //if (isLeapYear) {
            //    Console.WriteLine("閏年です");
            //} else {
            //    Console.WriteLine("閏年ではありません");
            //}
            #endregion

            //var dt2 = new DateTime(2004, 7, 22);
            //DayOfWeek dayOfWeek = dt2.DayOfWeek;
            //Console.WriteLine(dayOfWeek);

            Console.WriteLine("生年月日を入力");
            Console.Write("年：");
            var year = int.Parse(Console.ReadLine());
            Console.Write("月：");
            var month = int.Parse(Console.ReadLine());
            Console.Write("日：");
            var day = int.Parse(Console.ReadLine());

            var dt1 = new DateTime(year, month, day);
            //DayOfWeek dayOfWeek = dt1.DayOfWeek;
            //switch (dayOfWeek) {
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("日曜日");
            //        break;
            //    case DayOfWeek.Monday:
            //        Console.WriteLine("月曜日");
            //        break;
            //    case DayOfWeek.Tuesday:
            //        Console.WriteLine("火曜日");
            //        break;
            //    case DayOfWeek.Wednesday:
            //        Console.WriteLine("水曜日");
            //        break;
            //    case DayOfWeek.Thursday:
            //        Console.WriteLine("木曜日");
            //        break;
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("金曜日");
            //        break;
            //    case DayOfWeek.Saturday:
            //        Console.WriteLine("土曜日");
            //        break;
            //}

            CultureInfo culture = new CultureInfo("ja-JP");
            Console.WriteLine("あなたは{0}に生まれました。", dt1.ToString("dddd", culture));




        }
    }
}