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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(textBox4.Text);
            double y = double.Parse(textBox5.Text);
            int n = int.Parse(textBox1.Text);
            int k = int.Parse(textBox2.Text);
            double z = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    z += (Math.Abs(Math.Pow(x, i)) + Math.Cos(y) + Math.Pow(y, i)) / (i * j);
                }
            }
            textBox3.Text = z.ToString();
        }
    }
}
