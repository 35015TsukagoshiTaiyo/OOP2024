﻿using System;
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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        MyColor currentColor = new MyColor();
        private List<MyColor> stockColors = new List<MyColor>();


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            colorArea.Background = new SolidColorBrush(currentColor.Color);
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            MyColor color = new MyColor {
                Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value),
            };
            //同じ要素が存在したら追加できない処理
            if (!stockList.Items.Contains(color.ToString())) {
                stockList.Items.Insert(0,color.ToString());
                stockColors.Add(color);
            }
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            rSlider.Value = stockColors[stockList.SelectedIndex].Color.R;
            gSlider.Value = stockColors[stockList.SelectedIndex].Color.G;
            bSlider.Value = stockColors[stockList.SelectedIndex].Color.B;
        }
    }
}
