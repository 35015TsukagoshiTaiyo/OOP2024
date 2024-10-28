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
            currentColor.Color = Color.FromArgb(255, 0, 0, 0);
            DataContext = GetColorList();
        }
        MyColor currentColor /*= new MyColor()*/;
        //private List<MyColor> stockColors = new List<MyColor>();

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            colorArea.Background = new SolidColorBrush(currentColor.Color);
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {

            if (currentColor.Name == null) {
                //同じ要素が存在したら追加できない処理
                if (!stockList.Items.Contains(currentColor)) {
                    stockList.Items.Insert(0, currentColor);
                } else {
                    MessageBox.Show("そのRGBは既に登録されています。", "エラー");
                }
            } else {
                if (!stockList.Items.Contains(currentColor)) {
                    stockList.Items.Insert(0, currentColor);
                } else {
                    MessageBox.Show("その名前の色は既に登録されています。", "エラー");
                }
            }
            currentColor.Name = null;
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            colorArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            //各スライダーの値を設定する
            SetSliderValue(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
        }

        //各スライダー野値を設定する
        private void SetSliderValue(Color color) {
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        // すべての色を取得するメソッド
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            currentColor = (MyColor)colorSelectComboBox.SelectedItem;
            //各スライダーの値を設定する
            SetSliderValue(currentColor.Color);
        }
    }
}
