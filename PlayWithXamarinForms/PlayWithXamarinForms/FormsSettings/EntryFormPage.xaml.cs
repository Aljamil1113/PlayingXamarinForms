using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlayWithXamarinForms.FormsSettings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryFormPage : ContentPage
    {
        public EntryFormPage()
        {
            InitializeComponent();
        }

        //private void Entry_Completed(object sender, EventArgs e)
        //{
        //    label1.Text = "Completed";
        //}

        //private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    label1.Text = e.NewTextValue;
        //}
    }
}