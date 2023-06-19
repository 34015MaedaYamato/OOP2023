using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);  
        }


        //メソッドの概要： 学生データを読み込みStudentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            var scores = new List<Student>();
            var lines = File.ReadAllLines(filePath);

            foreach(string Line in lines) {   //すべての行から一行ずつ取り出す。
                var items = Line.Split(',');  //区切りで項目別に分ける

                var score = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                scores.Add(score);
            }
            return scores;
        }

        //メソッドの概要： 科目別の点数を求める
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var score in _score) {
                if (dict.ContainsKey(score.Subject)) {
                    dict[score.Subject] += score.Score;　//科目名が既に存在する（点数加算）
                } else {
                    dict[score.Subject] = score.Score;   //科目名が存在しない（新規格納）
                }
            }
            return dict; 
        }
    }
}
