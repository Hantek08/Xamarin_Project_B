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

            gif1.Source = $"https://cdn.dribbble.com/users/481941/screenshots/9797705/media/d6fc408897d7de56eb9c5fe6e39a1dcc.gif";
            
            gif2.Source = $"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-18.jpg";

          
        }
    }
}
