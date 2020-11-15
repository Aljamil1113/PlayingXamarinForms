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
    public partial class ContactListPagexaml : ContentPage
    {
        public ContactListPagexaml()
        {
            InitializeComponent();

            listView.ItemsSource = new List<string>
            {
                "None","Email", "SMS"
            };
        }

        public ListView ContactMethods { get { return listView; } }
    }
}