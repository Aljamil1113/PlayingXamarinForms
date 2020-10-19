using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlayWithXamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            //var imageSource = new UriImageSource { Uri = new Uri("https://picsum.photos/id/237/200/300") };
            //imageSource.CachingEnabled = false;
            //imageSource.CacheValidity = TimeSpan.FromHours(1);

            //image.Source = imageSource;

            //image.Source = ImageSource.FromResource("PlayWithXamarinForms.Images.elchaten.jpg");

            //btn.Image = (FileImageSource)ImageSource.FromFile(Device.OnPlatform(
            //    iOS: "clock.png",
            //    Android: "clock.png",
            //    WinPhone: "Images/clock.png"
            //    ));
        }
    }
}