using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace tema3.Views
{
    /// <summary>
    /// Interaction logic for MaterialVIew.xaml
    /// </summary>
    public partial class MaterialView : Window
    {
        public MaterialView()
        {
            InitializeComponent();
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            ProfesorView profesorView = new ProfesorView();
            profesorView.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
       
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Open file dialog";
            fileDialog.InitialDirectory = @"C:\univ\mvp\tema3\tema3\MaterialeDidactice";
            fileDialog.RestoreDirectory = true;
            fileDialog.Filter = "txt files (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.CheckFileExists = true;
            fileDialog.CheckPathExists = true;

            txtPath.Text = fileDialog.FileName;
            if (fileDialog.ShowDialog()==true)
            {
                txtPath.Text = fileDialog.FileName;
            }
        }
    }
}
