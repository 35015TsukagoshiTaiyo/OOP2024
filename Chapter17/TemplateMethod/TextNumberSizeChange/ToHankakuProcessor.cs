using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;
using TextNumberSizeChange.Framework;
using static System.Net.Mime.MediaTypeNames;

namespace TextNumberSizeChange {
    class ToHankakuProcessor : ITextFileService {

        Dictionary<char, char> numDictionary = new Dictionary<char, char>() {
                {'１','1'},{'２','2'},{'３','3'},{'４','4'},{'５','5'},
                {'６','6'},{'７','7'},{'８','8'},{'９','9'},{'０','0'},
        };

        public void Excute(string line) {
            string s = new string(line.Select(n =>
                        (numDictionary.ContainsKey(n) ? numDictionary[n] : n)).ToArray());
            Console.WriteLine(s);
        }

        public void Initialize(string fname) { }

        public void Terminate() { }

    }
}
