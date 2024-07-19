using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xsports = xdoc.Root.Elements().Select(x => new {
                Name = (string)x.Element("name"),
                teamMembers = (int)x.Element("teammembers"),
            });

            foreach (var xelement in xsports) {
                Console.WriteLine("{0} {1}", xelement.Name, xelement.teamMembers);
            }
            //模範解答
            //var sports = xdoc.Root.Elements()
            //                 .Select(x => new {
            //                     Name = x.element("name").Value,
            //                     Teammembers = x.element("teammembers").Value
            //                 });
            //foreach (var sports in sports) {
            //    Console.WriteLine("{0} {1}", sports.Name, sports.Teammembers);
            //}
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var xsports = xdoc.Root.Elements()
                                .OrderBy(x => (string)x.Element("firstplayed"));
            foreach (var sports in xsports) {
                var xNameKanji = sports.Element("name").Attribute("kanji");
                var xFirstPlayed = sports.Element("firstplayed");
                Console.WriteLine("{0}({1})", xNameKanji.Value, xFirstPlayed.Value);
            }
            //模範解答
            //var sports = xdoc.Root.Elements()
            //                .Select(x => new {
            //                    Name = x.element("name").Attribute("kanji").Value,
            //                    Firstplayed = x.element("firstplayed").Value,
            //                }).OrderBy(x => x.Firstplayed);

            //foreach (var sports in sports) {
            //    Console.WriteLine("{0}({1})", sports.Name, sports.Firstplayed);
            //}
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().Select(x => new {
                Name = (string)(x.Element("name")),
                teamMembers = (int)x.Element("teammembers")
            });

            var maxTeamMembers = xelements.Max(x => x.teamMembers);

            foreach (var item in xelements) {
                if (item.teamMembers == maxTeamMembers)
                    Console.WriteLine("{0}:{1}人", item.Name, item.teamMembers);
            }
            //模範解答
            //var sports = xdoc.Root.Elements()
            //    .OrderByDescending(x => x.element("teammembers").Value)
            //    .First();
            //Console.WriteLine($"{sports.element("name").Value}");
        }

        private static void Exercise1_4(string file, string newfile) {
            List<XElement> xElements = new List<XElement>();

            var xdoc = XDocument.Load(file); //１回だけロード
            var flag = true;

            while (flag) {
                //入力処理
                Console.Write("名称：");
                var name = Console.ReadLine();
                Console.Write("漢字：");
                var kanji = Console.ReadLine();
                Console.Write("プレイ人数：");
                var teamMember = Console.ReadLine();
                Console.Write("起源：");
                var firstPlayd = Console.ReadLine();
                //１件分の要素作成
                var element = new XElement("ballSports",
                                new XElement("name", name, new XAttribute("kanji", kanji)),
                                new XElement("teammembers", teamMember),
                                new XElement("firstplayed", firstPlayd)
                );
                //要素をListに追加
                xElements.Add(element);

                Console.WriteLine("追加[1]  保存[2]");
                Console.Write(">");
                var select = Console.ReadLine();

                if (select == "2")
                    flag = false; //無限ループを抜ける
            }

            xdoc.Root.Add(xElements);
            xdoc.Save(newfile); //保存


        }
    }
}
