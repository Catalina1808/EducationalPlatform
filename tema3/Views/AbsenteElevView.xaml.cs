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

namespace tema3.Views
{
    /// <summary>
    /// Interaction logic for AbsenteElevView.xaml
    /// </summary>
    public partial class AbsenteElevView : Window
    {
        public AbsenteElevView()
        {
            InitializeComponent();
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            DiriginteView profesorView = new DiriginteView();
            profesorView.Show();
            Close();
        }
    }
}