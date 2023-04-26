using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Bar : Obj {
        Random rnd = new Random();

        private static int count; //ボール数　ボールクラスでカウント

        //コンストラクタ
        public Bar(double x, double y) : base(x, y, @"pic\bar.png"){
            MoveX = 10;
            MoveY = 0;
        }

        //抽象クラスを継承しているので、不要なメソッドは空にする
        public override void Move(){
            //空のメソッドにする
        }

        public void Move(Keys direction){
            if (direction == Keys.Right) {
                if(PosX <= 630) {
                    PosX += 10;
                }
            }
            if(direction == Keys.Left) {
                if (PosX >= 0) {
                    PosX -= 10;
                }
            }
            if(direction == Keys.Down) {
                if (PosY <= 540) {
                    PosY += 10;
                }
                
            }
            if(direction == Keys.Up) {
                if (PosY >= 10) {
                    PosY -= 10;
                }
               
            }
        }
    }
}
