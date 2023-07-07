using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();


        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        private void btAddReport_Click(object sender, EventArgs e) {
            CarReport NewRepo = new CarReport();



            CarReports.Add(NewRepo);
        }
    }
}
