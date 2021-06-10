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
    /// Interaction logic for UpravnikWizardView.xaml
    /// </summary>
    public partial class UpravnikWizardView : Window
    {
        public UpravnikWizardView()
        {
            InitializeComponent();
            frame.Content = new WizardFirstPage();
            FrameContentChanged();
        }

        private void prevBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (frame.Content is WizardSecondPage)
            {
                frame.Content = new WizardFirstPage();
            }
            else if(frame.Content is WizardThirdPage)
            {
                frame.Content = new WizardSecondPage();
            }
            else if(frame.Content is WizardLastPage)
            {
                frame.Content = new WizardThirdPage();
            }
            FrameContentChanged();
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            if(frame.Content is WizardFirstPage)
            {
                frame.Content = new WizardSecondPage();
            }
            else if (frame.Content is WizardSecondPage)
            {
                frame.Content = new WizardThirdPage();
            }
            else if (frame.Content is WizardThirdPage)
            {
                frame.Content = new WizardLastPage();
            }          
            FrameContentChanged();
        }
        private void FrameContentChanged()
        {
            if(frame.Content is WizardFirstPage)
            {
                prevBtn.IsEnabled = false;
                
            }
            else
            {
                prevBtn.IsEnabled = true;
            }

            if (frame.Content is WizardLastPage)
            {
                nextBtn.IsEnabled = false;
                finishBtn.IsEnabled = true;
            }
            else
            {
                nextBtn.IsEnabled = true;
                finishBtn.IsEnabled = false;
            }
        }

        private void finishBtn_Click(object sender, RoutedEventArgs e)
        {
            var d = new UpravnikView();
            d.Show();
            this.Close();
        }
    }
}
