using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));


        }

        private static void Exercise1_1(string outfile) {
            //シリアル化
            var employee = new Employee {
                Id = 1,
                Name = "佐藤",
                HireDate = DateTime.Today,
            };
            using (var writer = XmlWriter.Create(outfile)) {
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

        }

        private static void Exercise1_3(string v) {

        }

        private static void Exercise1_4(string v) {

        }
    }
}
