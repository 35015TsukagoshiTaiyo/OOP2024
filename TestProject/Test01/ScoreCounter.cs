using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要： スコアのデータを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> students = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                string[] items = line.Split(',');
                Student student = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2]),
                };
                students.Add(student);
            }
            return students;
        }

        //メソッドの概要： 科目別のスコア合計を求める
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject)) {
                    dict[student.Subject] += student.Score;
                } else {
                    dict[student.Subject] = student.Score;
                }
            }
            return dict;
        }
    }
}
