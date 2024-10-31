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

        MyColor currentColor /*= new MyColor()*/;
        MyColor[] colorsTable; //色のデータ

        public MainWindow() {
            InitializeComponent();
            //αチャンネルの初期値を設定 (起動時にすぐにストックボタンが押された場合の対応)
            currentColor.Color = Color.FromArgb(255, 0, 0, 0);
            DataContext = colorsTable = GetColorList();
        }


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);

            //int i;
            //for (i = 0; i < colorsTable.Length; i++) {
            //    if (colorsTable[i].Color.Equals(currentColor.Color)) {
            //        currentColor.Name = colorsTable[i].Name;
            //        break;
            //    }
            //}
            //colorSelectComboBox.SelectedIndex = i;

            colorArea.Background = new SolidColorBrush(currentColor.Color);
            colorSelectComboBox.SelectedItem = null;
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            //currentColor.Name = GetColorList().Where(c => c.Color.Equals(currentColor.Color)).Select(x => x.Name).FirstOrDefault();
            currentColor.Name = colorsTable.FirstOrDefault(c => c.Color.Equals(currentColor.Color)).Name;
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
            colorSelectComboBox.SelectedItem = null;
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            try {
                colorArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
                //各スライダーの値を設定する
                SetSliderValue(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            }
            catch (Exception) {
            }
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
            //currentColor = (MyColor)((ComboBox)sender).SelectedItem;
            //SetSliderValue(currentColor.Color);

            if (colorSelectComboBox.SelectedItem != null) {
                var tempCurrentColor = currentColor = (MyColor)((ComboBox)sender).SelectedItem;
                // 各スライダーの値を設定する
                SetSliderValue(currentColor.Color);
                currentColor.Name = tempCurrentColor.Name; //Nameプロパティの文字列を再設定
                colorSelectComboBox.SelectedItem = tempCurrentColor; //CbSelectedIndexを再設定
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e) {
            if (stockList.Items.Count != 0) {
                stockList.Items.RemoveAt(stockList.SelectedIndex);
            } else {
                MessageBox.Show("削除するレコードが選択されていません。", "エラー");
            }
        }
    }
}
