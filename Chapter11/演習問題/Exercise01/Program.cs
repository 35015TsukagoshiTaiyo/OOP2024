using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //                     Name = x.Element("name").Value,
            //                     Teammembers = x.Element("teammembers").Value
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
            //                    Name = x.Element("name").Attribute("kanji").Value,
            //                    Firstplayed = x.Element("firstplayed").Value,
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
            //    .OrderByDescending(x => x.Element("teammembers").Value)
            //    .First();
            //Console.WriteLine($"{sports.Element("name").Value}");
        }

        private static void Exercise1_4(string file, string newfile) {
            var soccerElement = new XElement("ballSports",
                            new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                            new XElement("teammembers", "11"),
                            new XElement("firstplayed", "1863")
                            );
            var rugbyElement = new XElement("ballSports",
                            new XElement("name", "ラグビー", new XAttribute("kanji", "闘球")),
                            new XElement("teammembers", "15"),
                            new XElement("firstplayed", "1823")
                            );
            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(soccerElement);
            xdoc.Root.Add(rugbyElement);

            xdoc.Save(newfile);
        }
    }
}
