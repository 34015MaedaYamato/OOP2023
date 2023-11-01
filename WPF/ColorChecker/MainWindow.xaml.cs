using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        BindingList<Rgb> Rgbs = new BindingList<Rgb>();

        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
            stockList.ItemsSource = Rgbs;
            stockList.DisplayMemberPath = "RgbName";
        }

        private AllColorList[] GetColorList(){
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new AllColorList() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            byte r = (byte)((int)rSlider.Value);
            byte g = (byte)((int)gSlider.Value);
            byte b = (byte)((int)bSlider.Value);
            rValue.Text = ((int)rSlider.Value).ToString();
            gValue.Text = ((int)gSlider.Value).ToString();
            bValue.Text = ((int)bSlider.Value).ToString();
            colorArea.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            Rgb NewRgb = new Rgb();
            
            NewRgb.RgbName = "R="+ rSlider.Value + " G="+ gSlider.Value + " B="+ bSlider.Value;
            NewRgb.R = (byte)((int)rSlider.Value);
            NewRgb.G = (byte)((int)gSlider.Value);
            NewRgb.B = (byte)((int)bSlider.Value);
            Rgbs.Add(NewRgb);
        }


        private void stockList_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            Rgb rgb = (Rgb)stockList.SelectedItem;
            setColor(rgb);
        }

        void setColor(Rgb rgb) {
            rSlider.Value = rgb.R;
            gSlider.Value = rgb.G;
            bSlider.Value = rgb.B;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (AllColorList)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }
    }
}
