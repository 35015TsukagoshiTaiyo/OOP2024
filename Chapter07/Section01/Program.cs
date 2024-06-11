using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            #region 教科書
            //var employeeDict = new Dictionary<int, Employee> {
            //   { 100, new Employee(100, "清水遼久") },
            //   { 112, new Employee(112, "芹沢洋和") },
            //   { 125, new Employee(125, "岩瀬奈央子") },
            //};

            //employeeDict.Add(126, new Employee(126, "庄野和花"));


            //foreach (var item in employeeDict.Keys) {
            //    Console.WriteLine($"{item}");
            //}
            #endregion

            var prefecturesDict = new Dictionary<string, string>();
            Console.WriteLine("県庁所在地の登録");
            while (true) {
                Console.Write("都道府県：");
                string key = Console.ReadLine();
                if (key == null) {
                    break;
                }

                string value;
                if (prefecturesDict.ContainsKey(key)) {
                    Console.WriteLine("上書きしますか？ yes/no");
                    if (Console.ReadLine().ToLower() == "yes") {
                        Console.Write("県庁所在地：");
                        value = Console.ReadLine();
                        prefecturesDict[key] = value;
                    }
                } else {
                    Console.Write("県庁所在地：");
                    value = Console.ReadLine();
                    prefecturesDict.Add(key, value);
                }
            }

            bool isLoop = false;
            do {
                Console.WriteLine("*メニュー*");
                Console.WriteLine("1.一覧表示");
                Console.WriteLine("2.検索");
                Console.WriteLine("9.終了");
                int menuNum;
                if (int.TryParse(Console.ReadLine(), out menuNum)) {
                    switch (menuNum) {
                        case 1:
                            foreach (var item in prefecturesDict) {
                                Console.WriteLine("「{0}」の県庁所在地は「{1}」です", item.Key, item.Value);
                            }
                            break;
                        case 2:
                            Console.Write("都道府県：");
                            string searchKey = Console.ReadLine();
                            if (prefecturesDict.ContainsKey(searchKey)) {
                                Console.WriteLine($"県庁所在地：{prefecturesDict[searchKey]}");
                            } else {
                                Console.WriteLine("登録されていません");
                            }
                            break;
                        case 9:
                            isLoop = true;
                            break;
                        default:
                            Console.WriteLine("エラーです");
                            isLoop = true;
                            break;
                    }
                } else {
                    Console.WriteLine("正しく数値が入力されていません");
                }
            } while (!isLoop);
        }
    }
}