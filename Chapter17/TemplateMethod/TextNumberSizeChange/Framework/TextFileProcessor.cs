using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextNumberSizeChange.Framework {
    public class TextFileProcessor {
        private ITextFileService _service;

        public TextFileProcessor(ITextFileService service) {
            _service = service;
        }

        public void Run(string filename) {
            _service.Initialize(filename);
            using (var sr = new StreamReader(filename)) {
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    _service.Excute(line);
                }
            }
            _service.Terminate();
        }

    }
}
