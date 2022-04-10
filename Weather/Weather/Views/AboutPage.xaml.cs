using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Weather.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            sunnyGif.Source = $"https://cdn.dribbble.com/users/481941/screenshots/9797705/media/d6fc408897d7de56eb9c5fe6e39a1dcc.gif";
            
            Gif.Source = $"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-18.jpg";
        }
    }
}
