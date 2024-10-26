using System;
using System.Collections.Generic;
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
        public MainWindow() {
            InitializeComponent();
            //αチャンネルの初期値を設定 (起動時にすぐにストックボタンが押された場合の対応)
            //currentColor.Color = Color.FromArgb(255, 0, 0, 0);

            colorSelectComboBox.DataContext = GetColorList();
        }
        MyColor currentColor /*= new MyColor()*/;
        //private List<MyColor> stockColors = new List<MyColor>();

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            colorArea.Background = new SolidColorBrush(currentColor.Color);
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            //MyColor color = new MyColor {
            //    Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value),
            //    Name = "",
            //};

            //同じ要素が存在したら追加できない処理
            if (!stockList.Items.Contains(currentColor)) {
                stockList.Items.Insert(0, currentColor);
                //stockColors.Insert(0, color);
            }
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            //模範解答
            colorArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            rSlider.Value = ((MyColor)stockList.Items[stockList.SelectedIndex]).Color.R;
            gSlider.Value = ((MyColor)stockList.Items[stockList.SelectedIndex]).Color.G;
            bSlider.Value = ((MyColor)stockList.Items[stockList.SelectedIndex]).Color.B;

            //rSlider.Value = stockColors[stockList.SelectedIndex].Color.R;
            //gSlider.Value = stockColors[stockList.SelectedIndex].Color.G;
            //bSlider.Value = stockColors[stockList.SelectedIndex].Color.B;
        }

        // すべての色を取得するメソッド
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var myColor = (MyColor)colorSelectComboBox.SelectedItem;
            colorArea.Background = new SolidColorBrush(myColor.Color);
            rSlider.Value = myColor.Color.R;
            gSlider.Value = myColor.Color.G;
            bSlider.Value = myColor.Color.B;

            //var color = myColor.Color;
            currentColor.Name= myColor.Name;
        }
    }
}
