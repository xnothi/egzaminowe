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
using System.Windows.Shapes;

namespace INF04
{
    /// <summary>
    /// Logika interakcji dla klasy Styczen2024.xaml
    /// </summary>
    public partial class Styczen2024 : Window
    {
        public Styczen2024()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           MainWindow mainWindow = new MainWindow();
           mainWindow.Show();
           this.Close();  
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
