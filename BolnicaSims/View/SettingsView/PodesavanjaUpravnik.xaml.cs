using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BolnicaSims.View.SettingsView
{
    /// <summary>
    /// Interaction logic for PodesavanjaUpravnik.xaml
    /// </summary>
    public partial class PodesavanjaUpravnik : Window
    {
        public PodesavanjaUpravnik()
        {
            InitializeComponent();
            if (isToolTipVisible)
            {
                toggleTooltips.IsChecked = true;
            }
            else
            {
                toggleTooltips.IsChecked = false;
            }
        }

        private void btnNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private bool isToolTipVisible = true;
        private void toggleTooltips_Checked(object sender, RoutedEventArgs e)
        {
            this.isToolTipVisible = true;
            Style style = new Style(typeof(ToolTip));
            style.Setters.Add(new Setter(UIElement.VisibilityProperty, Visibility.Collapsed));
            style.Seal();
            foreach (Window window in Application.Current.Windows)
            {
                window.Resources.Remove(typeof(ToolTip));
                isToolTipVisible = true;
            }

        }

        private void toggleTooltips_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBoxResult rsltMessageBox = MessageBox.Show("Da li ste sigurni da zelite da iskljucite tooltip-ove?", "Tooltips",
                MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);
            switch (rsltMessageBox)
            {
                case MessageBoxResult.Yes:
                    this.isToolTipVisible = false;

                    Style style = new Style(typeof(ToolTip));
                    style.Setters.Add(new Setter(UIElement.VisibilityProperty, Visibility.Collapsed));
                    style.Seal();

                    foreach (Window window in Application.Current.Windows)
                    {
                        window.Resources.Add(typeof(ToolTip), style);
                        isToolTipVisible = false;
                    }
                    break;
                case MessageBoxResult.No:
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }
        
        

    }    
}
