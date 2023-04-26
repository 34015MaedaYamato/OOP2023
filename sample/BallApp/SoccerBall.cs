using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public override void Move(PictureBox pbBar, PictureBox pbBall){

            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y, pbBar.Width, pbBar.Height);
            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y, pbBall.Width, pbBall.Height);


            Console.WriteLine("[SoccreBall] X座標 = {0} Y座標 = {0}", PosX, PosY);

            if(PosX<0 || PosX >730 ||rBar.IntersectsWith(rBall)) {
                MoveX = -MoveX;
            }
            if(PosY<0 || PosY >530 || rBar.IntersectsWith(rBall)) {
                MoveY = -MoveY;
            }

            PosX += MoveX;
            PosY += MoveY;
        }
        public override void Move(Keys direction){
        }


    }
}
