using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program:Form {

        Bar bar; //Barインスタンス格納用
        PictureBox pbBar;

        private Timer moveTimer; //タイマー用
        //private SoccerBall soccerBall;
        //private TennisBall tennisBall;
        private PictureBox pb;

        //ボールインスタンス格納用
        private List<Obj> balls = new List<Obj>();
        private List<PictureBox> pbs = new List<PictureBox>(); //表示用

        //private int BallCount; //ボールの数　クリック回数でカウント

        static void Main(string[] args){
            Application.Run(new Program());
        }
        public Program(){
            //フォーム生成
            this.Size = new Size(800, 600);
            this.BackColor = Color.Green; 
            this.Text = "BallGame";
            this.MouseClick += Program_MouseClick;
            this.KeyDown += Program_KeyDown;

            //Barインスタンス
            bar = new Bar(320, 550);
            pbBar = new PictureBox();
            pbBar.Image = bar.Image;
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
            pbBar.Size = new Size(150, 10);
            pbBar.SizeMode = PictureBoxSizeMode.StretchImage; //画像の表示モード
            pbBar.Parent = this;

            moveTimer = new Timer();
            moveTimer.Interval = 10; //タイマーのインターバル
            //moveTimer.Start(); //タイマースタート
            moveTimer.Tick += MoveTimer_Tick; //デリゲート登録

        }


        //キーが押された時のイベントハンドラ
        private void Program_KeyDown(object sender, KeyEventArgs e){
            bar.Move(e.KeyData);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);


        }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e){
            Obj ballobj = null;
            pb = new PictureBox(); //画像を表示するコントロール
            if (e.Button == MouseButtons.Left) {
                //ボールインスタンス生成
                ballobj = new SoccerBall(e.X - 25, e.Y - 25);
                pb.Size = new Size(50, 50); //画像サイズ
            }
            else {
                ballobj = new TennisBall(e.X - 12, e.Y - 12);
                pb.Size = new Size(25, 25);
            }
            
            pb.Image = ballobj.Image;
            pb.Location = new Point((int)ballobj.PosX, (int)ballobj.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage; //画像の表示モード
            pb.Parent = this;

            balls.Add(ballobj);
            pbs.Add(pb);

            //this.Text = "BallGame:" + ++BallCount; //ボールの数　クリック回数でカウント
            this.Text = "BallGame [SoccerBall:" + SoccerBall.Count + "][TennisBall:" + TennisBall.Count + "]"; //ボール数　ボールクラスでカウント

            moveTimer.Start(); //タイマースタート

        }

        private void MoveTimer_Tick(object sender, EventArgs e){
            for (int i = 0; i < balls.Count; i++) {
                balls[i].Move(pbBar,pbs[i]); //移動
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY); //画像の位置
                //this.Text = "BallGame["+(i+1)+"]"; //ボール数　配列の数でカウント
            }
        }
    }
}
