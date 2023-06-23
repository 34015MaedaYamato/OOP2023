using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            string prefecture, location;
            int Popu;

            Console.WriteLine("県庁所在地の登録");

            var Address = new Dictionary<string, CityInfo>();

            Console.Write("県名：");
            prefecture = Console.ReadLine();

            while (prefecture != "999") {
                Console.Write("県庁所在地：");
                location = Console.ReadLine();
                
                Console.Write("人口：");
                while (!int.TryParse(Console.ReadLine(), out Popu)) {
                    Console.WriteLine("不正な文字列です。数字を入力してください。");
                    Console.Write("人口：");
                }

                if (Address.ContainsKey(prefecture)) {
                    Console.WriteLine("{0}は入力済みです。県庁所在地と人口を上書きしますか？（y/n）", prefecture);
                    if (ynCheck(Console.ReadLine())) {
                        Address[prefecture] = new CityInfo { City = location, Population = Popu };
                    }
                } else {
                    Address[prefecture] = new CityInfo {City = location,Population = Popu };
                }
                Console.Write("県名：");
                prefecture = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("一覧で表示しますか？（y/n）");
            if (ynCheck(Console.ReadLine())){
                var address = Address.OrderBy(n => n.Value.Population);
                foreach (var item in address) {
                    Console.WriteLine("{0}【{1}(人口：{2:#,0}人)】", item.Key, item.Value.City,item.Value.Population);
                }
            } else{
                Console.Write("県名を入力：");
                string prefectureName = Console.ReadLine();
                if (Address.ContainsKey(prefectureName)) {
                    Console.WriteLine("{0}の県庁所在地は{1}で、人口は{2:#,0}人です。", prefectureName, Address[prefectureName].City, Address[prefectureName].Population);
                } else {
                    Console.WriteLine("{0}は登録されていません。", prefectureName);
                }
            }

            //教科書
            //var flowerDict = new Dictionary<string, int>() {

            //    ["sunflower"] = 400,
            //    ["pansy"] = 300,
            //    ["tulip"] = 350,
            //    ["rose"] = 500,
            //    ["dahlia"] = 450,
            //};

            //flowerDict["morning glory"] = 250;
            //
            //Console.WriteLine("ひまわりの価格は{0}円です",flowerDict["sunflower"]);
            //Console.WriteLine("チューリップの価格は{0}円です", flowerDict["tulip"]);
            //Console.WriteLine("あさがおの価格は{0}円です", flowerDict["morning glory"]);

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

        class CityInfo{
            public string City { get; set; }
            public int Population { get; set; }
        }   
    }
}
