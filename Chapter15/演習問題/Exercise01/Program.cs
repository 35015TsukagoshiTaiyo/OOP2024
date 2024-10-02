using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(b => b.Price);
            var book = Library.Books.First(b => b.Price == max);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
#if true
            var groups = Library.Books
                .GroupBy(b => b.PublishedYear)
                .OrderBy(g => g.Key);
            foreach (var group in groups) {
                Console.WriteLine("{0}年 {1}冊", group.Key, group.Count());
            }
#else //模範解答
            var query = Library.Books
                .GroupBy(b => b.PublishedYear)
                .Select(g => new { publishedYear = g.Key, count = g.Count() })
                .OrderBy(g => g.publishedYear);
                foreach (var group in groups) {
                Console.WriteLine("{0}年 {1}冊", group.Key, group.Count());
            }
#endif
        }

        private static void Exercise1_4() {
            var books = Library.Books
                .Join(Library.Categories, //結合する２番目のシーケンス
                        book => book.CategoryId, //対象シーケンスの結合キー
                        category => category.Id, //２番目のシーケンスの結合キー
                        (book, category) => new { //オブジェクト生成関数
                            book.PublishedYear,
                            book.Price,
                            book.Title,
                            CategoryName = category.Name,
                        }
                    )
                .OrderByDescending(b => b.PublishedYear)
                .ThenByDescending(b => b.Price);
            foreach (var book in books) {
                Console.WriteLine($"{book.PublishedYear}年 {book.Price}円 {book.Title} ({book.CategoryName})  ");
            }
        }

        private static void Exercise1_5() {
            var names = Library.Books
                .Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories,
                        book => book.CategoryId,
                        category => category.Id,
                        (book, category) => category.Name)
                .Distinct();
            foreach (var name in names) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise1_6() {
            var groups = Library.Categories
                .OrderBy(c => c.Name)
                .GroupJoin(Library.Books,
                            c => c.Id,
                            d => d.CategoryId,
                            (c, books) => new { category = c.Name, Books = books });
            foreach (var group in groups) {
                Console.WriteLine($"#{group.category}");
                foreach (var book in group.Books) {
                    Console.WriteLine($"  {book.Title}");
                }
            }
        }

        private static void Exercise1_7() {
            var groups = Library.Categories
                .OrderBy(c => c.Name)
                .GroupJoin(Library.Books,
                            c => c.Id,
                            d => d.CategoryId,
                            (c, books) => new { category = c.Name, Books = books });
            
            foreach (var group in groups) {
                if (group.category == "Development") {
                    var g = group.Books.GroupBy(b => b.PublishedYear).OrderBy(x => x.Key);
                    foreach (var book in g) {
                        Console.WriteLine($"{book.Key}");
                        foreach (var b in book) {
                            Console.WriteLine(b.Title);
                        }
                    }
                }
            }
        }

        private static void Exercise1_8() {

        }
    }
}
