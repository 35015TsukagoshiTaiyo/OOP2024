using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
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

namespace CustomerApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        List<Customer> _customers;
        public MainWindow() {
            InitializeComponent();
        }

        //起動時に呼ばれるイベントハンドラ
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            ReadDatabase(); //ListView更新
        }

        //Saveボタン
        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (NameTextBox.Text == "" || PhoneTextBox.Text == "" || AddressTextBox.Text == "") {
                MessageBox.Show("項目がすべて入力されていません。", "警告", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var customer = new Customer {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                PictureImage = GetImagePath(),
            };

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }
            ReadDatabase(); //ListView更新

            ClearScrean();

        }

        // 画像をファイルパスとして保存
        private string GetImagePath() {
            string imagePath = null;
            if (PictureImage.Source != null) {
                var bitmap = PictureImage.Source as BitmapImage;
                if (bitmap != null) {
                    imagePath = bitmap.UriSource.LocalPath;
                }
            }
            return imagePath;
        }

        //updateボタン
        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            if (NameTextBox.Text == "" || PhoneTextBox.Text == "" || AddressTextBox.Text == "") {
                MessageBox.Show("項目がすべて入力されていません。", "警告", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var updateItem = CustomerListView.SelectedItem as Customer;
            if (updateItem != null) {
                updateItem.Name = NameTextBox.Text;
                updateItem.Phone = PhoneTextBox.Text;
                updateItem.Address = AddressTextBox.Text;
                updateItem.PictureImage = GetImagePath();
            }

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Update(updateItem);
            }
            ReadDatabase();
        }

        //ListView更新
        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();

                CustomerListView.ItemsSource = _customers;
            }
        }
        //検索機能
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;
        }

        //Deleteボタン
        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer; //as:参照のキャスト
            if (item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;
            }

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item); //item:消したい場所(参照)

                ReadDatabase(); //ListView更新
            }
            ClearScrean();
        }

        //選択行を表示
        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var imagePath = GetImagePath();
            var selectedItem = CustomerListView.SelectedItem as Customer;
            if (selectedItem != null) {
                NameTextBox.Text = selectedItem.Name;
                PhoneTextBox.Text = selectedItem.Phone;
                AddressTextBox.Text = selectedItem.Address;
                PictureImage.Source = new BitmapImage(new Uri(selectedItem.PictureImage));
            }
        }

        //画面のクリア
        private void ClearButton_Click(object sender, RoutedEventArgs e) {
            ClearScrean();
        }

        //クリア処理
        private void ClearScrean() {
            NameTextBox.Text = "";
            PhoneTextBox.Text = "";
            AddressTextBox.Text = "";
            PictureImage.Source = null;
            CustomerListView.SelectedItem = null;
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e) {
            var ofd = new OpenFileDialog();
            try {
                if (ofd.ShowDialog() == true) {
                    //画像をPictureImageにセット
                    PictureImage.Source = new BitmapImage(new Uri(ofd.FileName));
                }
            }
            catch (Exception) {
                MessageBox.Show("画像ファイルが選択されていません。");
            }
        }
    }
}
