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

namespace VisibilityConverter {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e) {
            Resources["ButtonBrushKey"] = new SolidColorBrush(Colors.Red);
        }

        //private void Button_Click(object sender, RoutedEventArgs e) {
        //    Resources["ButtonBrushKey"] = new SolidColorBrush(Colors.Gray);
        //}

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e) {
            Resources["ButtonBrushKey"] = new SolidColorBrush(Colors.Yellow);
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e) {
            Resources["ButtonBrushKey"] = new SolidColorBrush(Colors.Green);
        }
    }
}
