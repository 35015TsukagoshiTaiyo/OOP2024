using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            //// これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));


        }

        private static void Exercise1_1(string outfile) {
            //シリアル化
            var employee = new Employee {
                Id = 1,
                Name = "佐藤",
                HireDate = new DateTime(2001, 5, 10),
            };
            var settings = new XmlWriterSettings {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };
            using (var writer = XmlWriter.Create(outfile, settings)) {
                var serializer = new XmlSerializer(employee.GetType());
                serializer.Serialize(writer, employee);
            }

            //逆シリアル化
            using (var reader = XmlReader.Create(outfile)) {
                var serializer = new XmlSerializer(typeof(Employee));
                var emp = serializer.Deserialize(reader) as Employee;
                Console.WriteLine(emp);
            }
        }

        private static void Exercise1_2(string outfile) {
            //シリアル化
            var emps = new Employee[] {
                new Employee{
                    Id = 123,
                    Name = "出井 秀行",
                    HireDate = new DateTime(2001,5,10),
                },
                new Employee {
                    Id = 139,
                    Name = "大橋 孝仁",
                    HireDate = new DateTime(2004,12,1),
                }
            };
            var settings = new XmlWriterSettings {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };
            using (var writer = XmlWriter.Create(outfile, settings)) {
                var serializer = new DataContractSerializer(emps.GetType());
                serializer.WriteObject(writer, emps);
            }
        }

        private static void Exercise1_3(string file) {
            //逆シリアル化
            using (var reader = XmlReader.Create(file)) {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var emps = serializer.ReadObject(reader) as Employee[];
                foreach (var emp in emps) {
                    Console.WriteLine("{0} {1} {2}",emp.Id,emp.Name,emp.HireDate);
                }
            }
        }

        private static void Exercise1_4(string file) {
            var emps = new Employee[] {
                new Employee{
                    Id = 123,
                    Name = "出井 秀行",
                    HireDate = new DateTime(2001,5,10),
                },
                new Employee {
                    Id = 139,
                    Name = "大橋 孝仁",
                    HireDate = new DateTime(2004,12,1),
                }
            };

#if false
            var options = new JsonSerializerOptions {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true,
            };

            string jsonString = JsonSerializer.Serialize(emps, options);
            Console.WriteLine(jsonString); //画面へ出力
            File.WriteAllText(file,jsonString);
#else
            //模範解答
            using (var stream = new FileStream("employees.json", FileMode.Create, FileAccess.Write)) {

                var options = new JsonSerializerOptions {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                    WriteIndented = true,
                };

                JsonSerializer.Serialize(stream, emps, options);
                
            }
#endif
        }
    }
}
