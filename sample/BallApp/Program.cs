using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program:Form {
        private Timer scmoveTimer; //タイマー用
        private Timer temoveTimer;
        private SoccerBall soccerBall;
        private TennisBall tennisBall;
        private PictureBox scpb;
        private PictureBox tepb;

        private List<SoccerBall> scballs = new List<SoccerBall>(); //ボールインスタンス格納用
        private List<TennisBall> teballs = new List<TennisBall>();
        private List<PictureBox> scpbs = new List<PictureBox>(); //表示用
        private List<PictureBox> tepbs = new List<PictureBox>();

        //private int BallCount; //ボールの数　クリック回数でカウント

        static void Main(string[] args){
            Application.Run(new Program());
        }

        public Program(){
            this.Size = new Size(800, 600);
            this.BackColor = Color.Green; 
            this.Text = "BallGame";
            this.MouseClick += Program_MouseClick;

            scmoveTimer = new Timer();
            temoveTimer = new Timer();
            scmoveTimer.Interval = 10; //タイマーのインターバル
            temoveTimer.Interval = 10;
            //moveTimer.Start(); //タイマースタート
            scmoveTimer.Tick += scMoveTimer_Tick; //デリゲート登録
            temoveTimer.Tick += teMoveTimer_Tick;
            

        }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e){
            if (e.Button == MouseButtons.Left) {

                //ボールインスタンス生成
                soccerBall = new SoccerBall(e.X - 25, e.Y - 25);
                scpb = new PictureBox(); //画像を表示するコントロール
                scpb.Image = soccerBall.Image;
                scpb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
                scpb.Size = new Size(50, 50); //画像サイズ
                scpb.SizeMode = PictureBoxSizeMode.StretchImage; //画像の表示モード
                scpb.Parent = this;

                scballs.Add(soccerBall);
                scpbs.Add(scpb);

                //this.Text = "BallGame:" + ++BallCount; //ボールの数　クリック回数でカウント
                this.Text = "BallGame [SoccerBall:"+SoccerBall.Count+"][TennisBall:"+TennisBall.Count+"]";　//ボール数　ボールクラスでカウント

                scmoveTimer.Start(); //タイマースタート
            }
            else {
                tennisBall = new TennisBall(e.X - 25, e.Y - 25);
                tepb = new PictureBox(); //画像を表示するコントロール
                tepb.Image = tennisBall.Image;
                tepb.Location = new Point((int)tennisBall.PosX, (int)tennisBall.PosY);
                tepb.Size = new Size(50, 50); //画像サイズ
                tepb.SizeMode = PictureBoxSizeMode.StretchImage; //画像の表示モード
                tepb.Parent = this;

                teballs.Add(tennisBall);
                tepbs.Add(tepb);

                //this.Text = "BallGame:" + ++BallCount; //ボールの数　クリック回数でカウント
                this.Text = "BallGame [SoccerBall:" + SoccerBall.Count + "][TennisBall:" + TennisBall.Count + "]";　//ボール数　ボールクラスでカウント

                temoveTimer.Start(); //タイマースタート

            }
        }

        private void scMoveTimer_Tick(object sender, EventArgs e){
            for (int i = 0; i < scballs.Count;i++) {
                scballs[i].Move(); //移動
                scpbs[i].Location = new Point((int)scballs[i].PosX, (int)scballs[i].PosY); //画像の位置
                //this.Text = "BallGame["+(i+1)+"]"; //ボール数　配列の数でカウント
            }
        }

        private void teMoveTimer_Tick(object sender, EventArgs e){
            for (int i = 0; i < teballs.Count; i++) {
                teballs[i].Move(); //移動
                tepbs[i].Location = new Point((int)teballs[i].PosX, (int)teballs[i].PosY); //画像の位置
                //this.Text = "BallGame["+(i+1)+"]"; //ボール数　配列の数でカウント
            }
        }
    }
}
