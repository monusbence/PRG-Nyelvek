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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtNev_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            string nev =  txtNev.Text;
            string megjelenes = txtMegjelenes.Text;
            Nyelv xy = new Nyelv();
            StreamWriter
        }
    }
}
