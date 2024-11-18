using CustomerApp.Objects;
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
        //Saveボタン
        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (NameTextBox.Text == "" || PhoneTextBox.Text == "" || AddressTextBox.Text == "") {
                MessageBox.Show("項目がすべて入力されていません。","警告",MessageBoxButton.OK,MessageBoxImage.Warning);
                return;
            }

            var customer = new Customer {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
            };

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }
            ReadDatabase(); //ListView更新

            ClearScrean();

        }

        

        //updateボタン
        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var updateItem = CustomerListView.SelectedItem as Customer;
            if (updateItem != null) { 
                updateItem.Name = NameTextBox.Text;
                updateItem.Phone = PhoneTextBox.Text;
                updateItem.Address = AddressTextBox.Text;
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
        
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x=>x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;
        }

        //Deleteボタン
        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
             var item = CustomerListView.SelectedItem as Customer; //as:参照のキャスト
            if(item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;
            }

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item); //item:消したい場所(参照)

                ReadDatabase(); //ListView更新
            }
        }

        //起動時に呼ばれるイベントハンドラ
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            ReadDatabase(); //ListView更新
        }
        //選択行を表示
        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectedItem = CustomerListView.SelectedItem as Customer;
            if(selectedItem != null) {
                NameTextBox.Text = selectedItem.Name;
                PhoneTextBox.Text = selectedItem.Phone;
                AddressTextBox.Text = selectedItem.Address;
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
            CustomerListView.SelectedItem = null;
        }
    }
}
