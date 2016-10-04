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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The First App is in the book!");
        }
       /* private void Exit_Click(object sender, RoutedEventArgs e)
        {
            
        }*/

        private void Exit_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Another button in the book!");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Another button in the book!");
            Environment.Exit(0);
        }

        private void HelloWorld_Click(object sender, RoutedEventArgs e)
        {
            //need to insert command to ask for name
            DateTime localDate = DateTime.Now;
            string HWorld = localDate.ToString("yyyymmdd");
            MessageBox.Show(HWorld);
        }
    }
}
