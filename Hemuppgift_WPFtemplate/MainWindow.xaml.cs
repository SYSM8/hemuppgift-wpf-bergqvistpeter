﻿using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGrid_Click(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
        }

        private void btnStack_Click(object sender, RoutedEventArgs e)
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Show();
        }
    }
}