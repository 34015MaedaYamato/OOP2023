using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0412 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void btButton_Click(object sender, EventArgs e)
        {
            //int ans = int.Parse(tbNum1.Text) + int.Parse(tbNum2.Text);
            //tbAns.Text = ans.ToString();
            int num1 = int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum2.Text);
            int sum = num1 + num2;
            tbAns.Text = sum.ToString();
        }

        private void btPow_Click(object sender, EventArgs e)
        {
            double PowAns = System.Math.Pow(double.Parse(nudX.Text), double.Parse(nudY.Text));
            tbPow.Text = PowAns.ToString();

            //一行で書く場合
            //tbPow.Text = (Math.Pow((double)nudX.Value,(double)nudY.Value).ToString(); 

        }
    }
}
