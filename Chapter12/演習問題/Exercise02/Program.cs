using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var novelist = Exercise2_1("Sample.xml");

            Exercise2_2(novelist, "novelist.json");
            
            //// これは確認のためのコード 12.2.1
            //Console.WriteLine("{0} {1}", novelist.Name, novelist.Birth);
            //foreach (var title in novelist.Masterpieces) {
            //    Console.WriteLine(title);
            //}
            //Console.WriteLine();

            //// これは確認のためのコード 12.2.2
            //Console.WriteLine(File.ReadAllText("novelist.json"));
            //Console.WriteLine();
        }

        private static object Exercise2_1(string v) {
            using (var reader = XmlReader.Create(v)) {
                var serializer = new XmlSerializer(typeof(novelist));
                var novels = serializer.Deserialize(reader) as novelist;

                //// これは確認のためのコード 12.2.1
                Console.WriteLine("{0} {1}", novels.Name, novels.Birth);
                foreach (var title in novels.Masterpieces) {
                    Console.WriteLine(title);
                }
                Console.WriteLine();

                return novels;
            }

        }

        private static void Exercise2_2(object novelist, string v) {

        }
    }
}
