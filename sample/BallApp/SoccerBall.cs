using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall : Obj {

        Random rnd = new Random();

        private static int count; //ボール数　ボールクラスでカウント

        //コンストラクタ
        public SoccerBall(double x, double y) : base(x, y, @"pic\soccer_ball.png") { 

            int rndX = rnd.Next(-15, 15);
            MoveX = (rndX != 0 ? rndX : 1); //乱数で移動量を設定（x座標）
            int rndY = rnd.Next(-15, 15);
            MoveY = (rndY != 0 ? rndY : 1); //乱数で移動量を設定（y座標）

            count++; //ボール数　ボールクラスでカウント
        }

        //プロパティ
        public static int Count { get => count; set => count = value; }

        public override void Move(){

            Console.WriteLine("[SoccreBall] X座標 = {0} Y座標 = {0}", PosX, PosY);

            if(PosX<0 || PosX >730) {
                MoveX = -MoveX;
            }
            if(PosY<0 || PosY >530) {
                MoveY = -MoveY;
            }

            PosX += MoveX;
            PosY += MoveY;
        }


    }
}
