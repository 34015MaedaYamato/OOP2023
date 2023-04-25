using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class TennisBall : Obj {

        Random rand = new Random();
        private static int count;

        

        public TennisBall(double x,double y) :base(x, y,@"pic\tennis_ball.png"){
            int randX = rand.Next(-15, 15);
            MoveX = (randX != 0 ? randX : 1);
            int randY = rand.Next(-15, 15);
            MoveY = (randY != 0 ? randY : 1);
            count++;
        }

        public static int Count { get => count; set => count = value; }

        public override void Move(){
            Console.WriteLine("[TennisBall] X座標 = {0} Y座標 = {0}", PosX, PosY);

            if (PosX < 0 || PosX > 730) {
                MoveX = -MoveX;
            }
            if (PosY < 0 || PosY > 530) {
                MoveY = -MoveY;
            }

            PosX += MoveX;
            PosY += MoveY;

        }
    }
}
