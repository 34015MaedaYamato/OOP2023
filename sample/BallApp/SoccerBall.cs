using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall {
        //フィールド
        private Image image; //画像データ
        
        private double posX; //x座標
        private double posY; //y座標

        //private double moveX = 10.0; //移動量（x座標）
        //private double moveY = 10.0; //移動量（y座標）

        Random rnd = new Random();
        private double moveX;
        private double moveY;


        public SoccerBall(){
            Image = Image.FromFile(@"pic\soccer_ball.png");
            PosX = 0.0;
            PosY = 0.0;
        }

        public SoccerBall(double x, double y){
            Image = Image.FromFile(@"pic\soccer_ball.png");
            PosX = x;
            PosY = y;

            int rndX = rnd.Next(-15, 15);
            moveX = (rndX != 0 ? rndX : 1); //乱数で移動量を設定（x座標）
            int rndY = rnd.Next(-15, 15);
            moveY = (rndY != 0 ? rndY : 1); //乱数で移動量を設定（y座標）
        }


        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image= value; }

        public void Move(){

            Console.WriteLine("X座標 = {0} Y座標 = {0}", posX, posY);

            if(posX<0 || posX >730) {
                moveX = -moveX;
            }
            if(posY<0 || posY >530) {
                moveY = -moveY;
            }

            posX += moveX;
            posY += moveY;
        }


    }
}
