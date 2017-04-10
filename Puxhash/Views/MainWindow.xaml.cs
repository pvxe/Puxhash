﻿using Microsoft.Win32;
using Puxhash.ViewModels;
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

namespace Puxhash
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel vm;

        public MainWindow()
        {
            InitializeComponent();
            vm = (MainWindowViewModel)DataContext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            MainWindowViewModel vm = (MainWindowViewModel)DataContext;

            ofd.ShowDialog();
            String new_filepath = ofd.FileName;

            tb_FilePath.Text = new_filepath;
            vm.FilePath = new_filepath;

            vm.NotifyPropertyChanged("Md5Background");
            
        }
    }
}
