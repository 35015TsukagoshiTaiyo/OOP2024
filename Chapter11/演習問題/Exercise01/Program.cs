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
            var xelements = xdoc.Root.Elements().Select(x => new {
                Name = (string)x.Element("name"),
                teamMembers = (int)x.Element("teammembers"),
            });

            foreach (var xelement in xelements) {
                Console.WriteLine("{0} {1}", xelement.Name, xelement.teamMembers);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements()
                                .OrderBy(x => (string)x.Element("firstplayed"));
            foreach (var xelement in xelements) {
                var xname = xelement.Element("name");
                var xkanji = xname.Attribute("kanji");
                var xFirstPlayed = xelement.Element("firstplayed");
                Console.WriteLine("{0}({1})", xkanji.Value, xFirstPlayed.Value);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().Select(x => new {
                Name = (string)(x.Element("name")),
                teamMembers = (int)x.Element("teammembers")
            });

            var maxTeamMembers = xelements.Max(x => x.teamMembers);

            foreach (var item in xelements) {
                if (item.teamMembers == maxTeamMembers) {
                    Console.WriteLine("{0}:{1}",item.Name,item.teamMembers);
                }
            }
        }

        private static void Exercise1_4(string file, string newfile) {

        }
    }
}
