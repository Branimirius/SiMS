using BolnicaSims.Model;
using BolnicaSims.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BolnicaSims.View.MainView
{
    /// <summary>
    /// Interaction logic for ListaRecepata.xaml
    /// </summary>
    public partial class ListaRecepata : Window
    {
        private static ListaRecepata instance = null;
        public static ListaRecepata Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListaRecepata();
                }
                return instance;
            }
        }
        public ObservableCollection<Recept> recepti = ReceptiStorage.Instance.Read();
        public ListaRecepata()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
