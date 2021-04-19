using BolnicaSims.Controller;
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

namespace BolnicaSims
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
   

        private void ManualColumnsPacijent_Click(object sender, RoutedEventArgs e)
        {
            var s = new PacijentView();
            s.Show();
        }

        private void ManualColumnsSekretar_Click(object sender, RoutedEventArgs e)
        {
            var s = new SekretarView();
            s.Show();
        }
        private void ManualColumnsLekar_Click(object sender, RoutedEventArgs e)
        {
            var s = new DoktorView();
            s.Show();
        }
        private void ManualColumnsUpravnik_Click(object sender, RoutedEventArgs e)
        {
            var s = new UpravnikView();
            s.Show();
        }
        private void login()
        {

        }

        private void checkUser(string username, string password)
        {

        }

        private void Button_ClickLogin(object sender, RoutedEventArgs e)
        {
            switch (KorisnikController.Instance.Login2(txtKorisnickoIme.Text, txtLozinka.Password).Zvanje)
            {
                case "Sekretar":
                    var s = new SekretarView();
                    s.Show();
                    break;
                case "Pacijent":
                    var p = new PacijentView();
                    p.Show();
                    break;
                case "Upravnik":
                    var d = new UpravnikView();
                    d.Show();
                    break;
                case "Doktor":
                    var r = new DoktorView();
                    r.Show();
                    break;

                default:
                    break;
            }


        }
    }
}
