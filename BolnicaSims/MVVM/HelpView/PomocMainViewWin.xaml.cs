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
using System.Windows.Shapes;

namespace BolnicaSims.MVVM.HelpView
{
    /// <summary>
    /// Interaction logic for PomocMainViewWin.xaml
    /// </summary>
    public partial class PomocMainViewWin : Window
    {
        public PomocMainViewWin()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
