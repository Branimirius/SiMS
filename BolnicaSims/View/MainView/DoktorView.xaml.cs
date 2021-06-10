using BolnicaSims.View.EditView;
using BolnicaSims.View.MainView;
using BolnicaSims.View.NotificationsView;
using BolnicaSims.View.TableView;
using BolnicaSims.Demo;
using Model;
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
using BolnicaSims.Controller;
using BolnicaSims.View.Feedback;

namespace BolnicaSims
{
    /// <summary>
    /// Interaction logic for DoktorView.xaml
    /// </summary>
    public partial class DoktorView : Window
    {
        Page p1 = new ListaTerminaDoktor();
        Page p2 = new ListaLekovaDoktor();
        Page p3 = new ListaPacijenataDoktor();
        Page p4 = new ListaBolnickihLecenja();
        Page p5 = new StatistikaDoktor();
        Page p6 = new DemoDoktor();

        public DoktorView()
        {
            InitializeComponent();
            if (DoktorController.Instance.wantsDemo)
            {
                frame.Content = p6;
            }
            else
            {
                frame.Content = p1;
                menuItem1.Background = Brushes.DarkCyan;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = new NotifikacijeDoktor();
            s.Show();
        }

        private void validacijaBtn_Click(object sender, RoutedEventArgs e)
        {
            var s = new ValidacijaLekova();
            s.Show();
        }

        private void ButtonLogOut_Click(object sender, RoutedEventArgs e)
        {
            var s = new MainWindow();
            s.Show();
            Close();
        }

        private void ManualColumns_Click(object sender, RoutedEventArgs e)
        {
            p1.ShowsNavigationUI = false;
            frame.Content = p1;
            menuItem1.Background = Brushes.DarkCyan;
            menuItem2.Background = null;
            menuItem3.Background = null;
            menuItem4.Background = null;
            menuItem5.Background = null;
        }

        private void ManualColumns_Click2(object sender, RoutedEventArgs e)
        {
            p2.ShowsNavigationUI = false;
            frame.Content = p2;
            menuItem1.Background = null;
            menuItem2.Background = Brushes.DarkCyan;
            menuItem3.Background = null;
            menuItem4.Background = null;
            menuItem5.Background = null;
        }

        private void ManualColumns_Click3(object sender, RoutedEventArgs e)
        {
            p3.ShowsNavigationUI = false;
            frame.Content = p3;
            menuItem1.Background = null;
            menuItem2.Background = null;
            menuItem3.Background = Brushes.DarkCyan;
            menuItem4.Background = null;
            menuItem5.Background = null;
        }

        private void ManualColumns_Click4(object sender, RoutedEventArgs e)
        {
            p4.ShowsNavigationUI = false;
            frame.Content = p4;
            menuItem1.Background = null;
            menuItem2.Background = null;
            menuItem3.Background = null;
            menuItem4.Background = Brushes.DarkCyan;
            menuItem5.Background = null;
        }

        private void ManualColumns_Click5(object sender, RoutedEventArgs e)
        {
            p4.ShowsNavigationUI = false;
            frame.Content = p5;
            menuItem1.Background = null;
            menuItem2.Background = null;
            menuItem3.Background = null;
            menuItem4.Background = null;
            menuItem5.Background = Brushes.DarkCyan;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var s = new DoktorFeedback();
            s.Show();
        }
    }
}
