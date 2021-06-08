using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BolnicaSims.Demo
{
    /// <summary>
    /// Interaction logic for DemoDoktor.xaml
    /// </summary>
    public partial class DemoDoktor : Page
    {
        public DemoDoktor()
        {
            InitializeComponent();
        }

        private List<BitmapImage> Images = new List<BitmapImage>();
        private int ImageNumber = 0;
        private DispatcherTimer PictureTimer = new DispatcherTimer();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //DirectoryInfo dir_info = new DirectoryInfo(Environment.CurrentDirectory);
            //foreach (FileInfo file_info in dir_info.GetFiles())
            //{
            //    if ((file_info.Extension.ToLower() == ".jpg") ||
            //        (file_info.Extension.ToLower() == ".png"))
            //    {
            //        Images.Add(new BitmapImage(new Uri(file_info.FullName, UriKind.Absolute)));
            //    }
            //}

            Images.Add(new BitmapImage(new Uri("../Resources/DemoImg/Screenshot_1.png", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("../Resources/DemoImg/Screenshot_2.png", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("../Resources/DemoImg/Screenshot_3.png", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("../Resources/DemoImg/Screenshot_4.png", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("../Resources/DemoImg/Screenshot_5.png", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("../Resources/DemoImg/Screenshot_6.png", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("../Resources/DemoImg/Screenshot_7.png", UriKind.Relative)));

            // Display the first image.
            imgPicture.Source = Images[0];

            // Install a timer to show each image.
            PictureTimer.Interval = TimeSpan.FromSeconds(3);
            PictureTimer.Tick += Tick;
            PictureTimer.Start();
        }

        private void Tick(object sender, System.EventArgs e)
        {
            if (ImageNumber == 6)
            {
                PictureTimer.Stop();
            }
            else
            {
                ImageNumber = (ImageNumber + 1);
                imgPicture.Source = Images[ImageNumber];
            }
        }

    }
}
