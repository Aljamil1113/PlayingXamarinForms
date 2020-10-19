using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlayWithXamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class GreetPage : ContentPage
    {
        private string[] quotes = { "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.",
            "If you can't explain it to a six year old, you don't understand it yourself.",
            "I am enough of an artist to draw freely upon my imagination. ..." };
        private int i = 0;
        public GreetPage()
        {
            InitializeComponent();

            slider1.Value = 16;

            var x = new OnPlatform<Thickness>
            {
                Android = new Thickness(20, 30, 20, 20),
                iOS = new Thickness(20, 40, 20, 20)
            };
            Padding = x;
            label1.Text = quotes[0];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(i > (quotes.Length - 1))
            {
                i = 0;
            }
            label1.Text = quotes[i++];        
        }
    }
}