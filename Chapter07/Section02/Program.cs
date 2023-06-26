using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {

            string prefecture, location;
            int Popu;
            bool Check = false;

            Console.WriteLine("市町村別の人口の登録");

            var Address = new Dictionary<string, List<CityInfo>>();

            Console.Write("県名：");
            prefecture = Console.ReadLine();

            while (prefecture != "999") {
                Console.Write("都市名：");
                location = Console.ReadLine();

                Console.Write("人口：");
                while (!int.TryParse(Console.ReadLine(), out Popu)) {
                    Console.WriteLine("不正な文字列です。数字を入力してください。");
                    Console.Write("人口：");
                }


                if (Address.ContainsKey(prefecture)){
                    foreach (var item in Address[prefecture]) {
                        if(item.City == location) {
                            Check = true;
                            item.Population = Popu;
                        }
                    }
                    if(Check == false) {
                        Address[prefecture].Add(new CityInfo { City = location, Population = Popu });
                    } 
                } else {
                    Address[prefecture] = new List<CityInfo>();
                    Address[prefecture].Add(new CityInfo { City = location, Population = Popu });
                }
                Console.Write("県名：");
                prefecture = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("一覧で表示しますか？（y/n）");
            if (ynCheck(Console.ReadLine())) {
                foreach (var item in Address) {
                    foreach (var list in item.Value.OrderBy(n=>n.Population)) {
                        Console.WriteLine("{0}【{1}(人口：{2:#,0}人)】", item.Key,list.City, list.Population);
                    }  
                }
            } else {
                Console.Write("県名を入力：");
                string prefectureName = Console.ReadLine();
                if (Address.ContainsKey(prefectureName)) {
                    foreach (var item in Address[prefectureName]) {
                        Console.WriteLine("{0}【{1}(人口：{2:#,0}人)】", prefectureName, item.City, item.Population);
                    }
                    
                } else {
                    Console.WriteLine("{0}は登録されていません。", prefectureName);
                }
            }
        }
        public static bool ynCheck(string ans) {
            while (true) {
                if (ans == "y") {
                    return true;
                } else if (ans == "n") {
                    return false;
                } else {
                    Console.WriteLine("yかnで入力してください。");
                    ans = Console.ReadLine();
                }
            }
        }

        class CityInfo {
            public string City { get; set; }
            public int Population { get; set; }
        }
    }
}
