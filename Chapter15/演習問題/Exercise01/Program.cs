using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
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
            var MaxPrice = Library.Books.Where(x => x.Price == Library.Books.Max(a => a.Price));
            foreach (var book in MaxPrice) {
                Console.WriteLine(book);
            }
            //先生
            //var price = Library.Books.Max(a => a.Price);
            //var books = Library.Books.Where(b => b.Price == price);
            //foreach (var book in books) {
            //    Console.WriteLine(book);
            //}
        }

        private static void Exercise1_3() {
            var pbyear = Library.Books.GroupBy(a => a.PublishedYear).OrderBy(b => b.Key);
            foreach (var year in pbyear) {
                Console.WriteLine("{0}年 {1}冊", year.Key, year.Count());
            }

            //先生
            //var query = Library.Books.GroupBy(b => b.PublishedYear).Select(g => new {PublishedYear = g.Key,Count = g.Count()}).OrderBy(x => x.PublishedYear);
            //foreach (var year in pbyear) {
            //    Console.WriteLine("{0}年 {1}冊", year.Key, year.Count());
            //}
        }

        private static void Exercise1_4() {
            var pbyear = Library.Books.GroupBy(a => a.PublishedYear).OrderByDescending(b => b.Key);
            foreach (var year in pbyear) {
                foreach (var book in year.OrderByDescending(a => a.Price)){
                    //Console.WriteLine(book);
                    Console.WriteLine("{0}年 {1}円 {2}({3})",book.PublishedYear,book.Price,book.Title,Library.Categories.First(a=> a.Id == book.CategoryId).Name);
                }
            }
        }

        private static void Exercise1_5() {
            var categories = Library.Books.Where(a => a.PublishedYear == 2016).Join(Library.Categories, book => book.CategoryId, category => category.Id, (book, category) => category.Name).Distinct();
            foreach (var category in categories) {
                Console.WriteLine(category);
            }
        }

        private static void Exercise1_6() {
            //joinなしvar
            //var categoris = Library.Categories.OrderBy(a => a.Name);
            //foreach (var cate in categoris) {
            //    Console.WriteLine("#{0}",cate.Name);
            //    foreach (var book in Library.Books.Where(a => a.CategoryId == cate.Id)) {
            //        Console.WriteLine(" {0}",book.Title);
            //    }
            //}

            var groups = Library.Categories.GroupJoin(Library.Books, c => c.Id, b => b.CategoryId, (c, books) => new { Category = c.Name, Books = books });
            foreach (var group in groups.OrderBy(a => a.Category)) {
                Console.WriteLine($"#{group.Category}");
                foreach (var book in group.Books) {
                    Console.WriteLine($" {book.Title}({book.PublishedYear}年)");
                }
            }
        }

        private static void Exercise1_7() {
            var groups = Library.Books.GroupJoin(Library.Categories, a => a.CategoryId, b => b.Id, (a,categories) => new { Categories = categories});
            
            
        }

        private static void Exercise1_8() {
            var groups = Library.Categories.GroupJoin(Library.Books, c => c.Id, b => b.CategoryId, (c, books) => new { Category = c.Name, Books = books }).Where(a => a.Books.Count() >= 4);
            foreach (var group in groups) {
                Console.WriteLine(group.Category);
            }
        }
    }
}
