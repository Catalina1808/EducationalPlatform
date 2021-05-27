using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    /// Interaction logic for MaterialElevView.xaml
    /// </summary>
    public partial class MaterialElevView : Window
    {
        public MaterialElevView()
        {
            InitializeComponent();
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            ElevView elevView = new ElevView();
            elevView.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(File.Exists(txtPath.Text))
            {
                Process.Start(txtPath.Text);
            }
        }
    }
}
