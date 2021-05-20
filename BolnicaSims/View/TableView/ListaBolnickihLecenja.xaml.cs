using BolnicaSims.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BolnicaSims.View.TableView
{
    /// <summary>
    /// Interaction logic for ListaBolnickihLecenja.xaml
    /// </summary>
    public partial class ListaBolnickihLecenja : Page
    {
        public ListaBolnickihLecenja()
        {
            InitializeComponent();
            dataGridSopstveniTermini.ItemsSource = LecenjaStorage.Instance.Read();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_karton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
