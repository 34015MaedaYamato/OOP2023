using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {
        public DateTime  NowTime = DateTime.Now;
        public DateTime birthday = new DateTime(2004, 3, 10);

        public Form1() {
            InitializeComponent();
            NowDate.Text = NowTime.ToString();
        }

        private void btDayCalc_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var a = NowTime - dtp;
            tbMessage.Text = a.Days.ToString();
        }

        private void btAge_Click(object sender, EventArgs e) {
            var age = NowTime.Year - birthday.Year;
            if (birthday > NowTime.AddYears(-age)) {
                age--;
            }
            tbMessage.Text = "年齢は" + age + "歳です。";

            /*int age = GetAge(birthday, NowTime);
            tbMessage.Text = "年齢は" + age + "歳です。";*/
        }

        public static int GetAge(DateTime birthday,DateTime targetDay) {
            var age = targetDay.Year -birthday.Year;
            if (birthday > targetDay.AddYears(-age)) {
                age--;
            }
            return age;
        }


        private void button1_Click(object sender, EventArgs e) {
            tbMessage.Text = (int.Parse(tbMessage.Text)-365).ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            tbMessage.Text = (int.Parse(tbMessage.Text) + 365).ToString();
        }

        private void button3_Click(object sender, EventArgs e) {
            tbMessage.Text = (int.Parse(tbMessage.Text) - 31).ToString();
        }

        private void button4_Click(object sender, EventArgs e) {
            tbMessage.Text = (int.Parse(tbMessage.Text) + 31).ToString();
        }

        private void button7_Click(object sender, EventArgs e) {
            tbMessage.Text = (int.Parse(tbMessage.Text) - 1).ToString();
        }

        private void button8_Click(object sender, EventArgs e) {
            tbMessage.Text = (int.Parse(tbMessage.Text) + 1).ToString();
        }

        
    }
}
