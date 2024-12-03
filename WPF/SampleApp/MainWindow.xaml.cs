using System;
using System.Collections.Generic;
using System.Linq;
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

namespace SampleApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            // 最初に表示するページを指定
            MainFrame.Navigate(new Page1());
        }

        //private void OnNextScreenButtonClick(object sender, RoutedEventArgs e) {
        //    // 次の画面へ遷移する
        //    var nextWindow = new NextWindow();
        //    nextWindow.Show();
        //    this.Close(); // 現在のウィンドウを閉じる
        //}
    }

}
