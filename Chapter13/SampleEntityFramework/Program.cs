using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {
            //InsertBooks();
            //Console.Write("データを挿入しました。続けるにはEnterキーを押してください。");

            //DisplayAllBooks();

            //AddAuthors();

            //AddBooks();

            //UpdateBook();

            //DeleteBook();

            //13-13
            //foreach (var book in GetBooks()) {
            //    Console.WriteLine($"{book.Title} {book.Author.Name}");
            //}

            //13-17
            //using (var db = new BooksDbContext()) {

            //    db.Database.Log = sql => { Debug.Write(sql); }; //sql文をVisualStudioの出力ウィンドウに表示(p343コラム)

            //    var count = db.Books.Count();
            //    Console.WriteLine(count);
            //}

            //Console.ReadLine();
            //Console.WriteLine();

            //演習問題
            Console.WriteLine("# 1.1");
            //Exercise1_1();

            Console.WriteLine();
            Console.WriteLine("# 1.2");
            Exercise1_2();

            Console.WriteLine();
            Console.WriteLine("# 1.3");
            Exercise1_3();

            Console.WriteLine();
            Console.WriteLine("# 1.4");
            Exercise1_4();

            Console.WriteLine();
            Console.WriteLine("# 1.5");
            Exercise1_5();

            Console.ReadLine();

        }

        private static void Exercise1_1() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛"
                };
                db.Authors.Add(author1);
                var author2 = new Author {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成"
                };
                db.Authors.Add(author2);
                db.SaveChanges(); //データベースを更新
            }

            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book1 = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author1
                };
                db.Books.Add(book1);
                var author2 = db.Authors.Single(a => a.Name == "川端康成");
                var book2 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = author2
                };
                db.Books.Add(book2);
                var author3 = db.Authors.Single(a => a.Name == "菊池寛");
                var book3 = new Book {
                    Title = "真珠婦人",
                    PublishedYear = 2002,
                    Author = author3
                };
                db.Books.Add(book3);
                var author4 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book4 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author4
                };
                db.Books.Add(book4);

                db.SaveChanges();
            }
        }

        private static void Exercise1_2() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.Include(nameof(Author)).ToList();
                foreach (var book in books) {
                    Console.WriteLine($"{book.Title} {book.PublishedYear} {book.Author.Name}");
                }
            }
        }

        private static void Exercise1_3() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.Where(a => a.Title.Length == db.Books.Max(b => b.Title.Length)).ToList();
                foreach (var book in books) {
                    Console.WriteLine($"{book.Title} {book.PublishedYear} {book.Author.Name}");
                }
            }
        }

        private static void Exercise1_4() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.OrderBy(a => a.PublishedYear).Take(3).ToList();
                foreach (var book in books) {
                    Console.WriteLine($"{book.Title} {book.PublishedYear} {book.Author.Name}");
                }
            }
        }

        private static void Exercise1_5() {
            using (var db = new BooksDbContext()) {
                /*var books = db.Books.Include(nameof(Author)).OrderByDescending(a => a.Author.Birthday).ToList();
                foreach (var book in books) {
                    Console.WriteLine($"{book.Author.Name} {book.Title} {book.PublishedYear}");
                }*/
                var authors = db.Authors.OrderByDescending(a => a.Birthday).ToList();
                foreach (var author in authors) {
                    Console.WriteLine($"{author.Name}");
                    var books = db.Books.Include(nameof(Author)).Where(a => a.Author.Name == author.Name);
                    foreach (var book in books) {
                        Console.WriteLine($"　{book.Title} {book.PublishedYear}");
                    }
                }
            }
        }

        // List 13-5
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);
                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);
                db.SaveChanges(); //データベースを更新
                Console.WriteLine($"{book1.Id} {book2.Id}");
            }
        }

        //13-7
        static IEnumerable<Book> GetBooks() {
            using (var db = new BooksDbContext()) {
                //return db.Books.Where(book => book.Author.Name.StartsWith("夏目")).ToList();

                //13-13&14
                return db.Books.Where(book => book.PublishedYear > 1900).Include(nameof(Author)).ToList();
            }
        }

        //13-8
        static void DisplayAllBooks() {
            var books = GetBooks();
            foreach(var book in books) {
                Console.WriteLine($"{book.Title} {book.PublishedYear}");
            }
            Console.ReadLine();
        }

        //13-9
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1878,12, 7),
                    Gender = "F",
                    Name = "与謝野晶子" 
                };
                db.Authors.Add(author1);
                var author2 = new Author {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };
                db.Authors.Add(author2);
                db.SaveChanges(); //データベースを更新
            }
        }

        //13-10
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1
                };
                db.Books.Add(book1);
                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2
                };
                db.Books.Add(book2);

                db.SaveChanges();
            }
        }

        //13-11
        private static void UpdateBook() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.Single(a => a.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }

        //13-12
        private static void DeleteBook() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.SingleOrDefault(x => x.Id == 10);
                if (book != null) {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }
    }
}
