using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BolnicaSims.Model.ButtonFactories
{
    class LightButtonFactory : ButtonFactory
    {
        public Button createButton()
        {
            Button but = new Button();
            but.Background = new SolidColorBrush(Colors.LightCyan);
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("../../Resources/bell.png", UriKind.Relative));
            but.Content = img;

            return but;
        }
    }
}
