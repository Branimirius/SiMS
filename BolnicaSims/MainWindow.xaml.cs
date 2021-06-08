using BolnicaSims.Controller;
using BolnicaSims.MVVM.HelpView;
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

        private void Button_ClickLogin(object sender, RoutedEventArgs e)
        {
            if((bool)checkWizard.IsChecked) { DoktorController.Instance.wantsDemo = true;  };
            switch (KorisnikController.Instance.Login2(txtKorisnickoIme.Text, txtLozinka.Password).Zvanje)
            { 
                case "Sekretar":
                    var s = new SekretarView();
                    s.Show();
                    Close();
                    break;
                case "Pacijent":
                    var p = new PacijentView();
                    p.Show();
                    Close();
                    break;
                case "Upravnik":
                    if ((bool)checkWizard.IsChecked)
                    {
                        var d = new UpravnikWizardView();
                        d.Show();
                    }
                    else
                    {
                        var d = new UpravnikView();
                        d.Show();
                    }
                    
                    Close();
                    break;
                case "Doktor":
                    var r = new DoktorView();
                    r.Show();
                    Close();
                    break;

                default:
                    break;
            }


        }
    }
}
