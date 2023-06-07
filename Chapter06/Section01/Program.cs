using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var number = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4};

            Console.WriteLine(number.Average());

            var books = Books.GetBooks();


            var booksObj = books.Where(x => x.Title.Contains("物語")).OrderByDescending(x => x.Price);
            foreach (var book in booksObj) {
                Console.WriteLine("{0}:{1}円",book.Title,book.Price);
            }


            //タイトルに「物語」が含まれている書籍の平均ページ数
            var booksMonoPage = books.Where(x => x.Title.Contains("物語")).Average(x => x.Pages);
            Console.WriteLine(booksMonoPage+"円");


            //タイトルが長い順に出力
            var booksTitleLength = books.OrderByDescending(x => x.Title.Length);
            foreach (var book in booksTitleLength) {
                Console.WriteLine("{0}:{1}円", book.Title, book.Price);
            }



        }
    }
}
