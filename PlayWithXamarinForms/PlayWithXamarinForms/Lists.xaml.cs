using PlayWithXamarinForms.MarkupExtensions;
using PlayWithXamarinForms.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlayWithXamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lists : MasterDetailPage
    {
        private ObservableCollection<Contact> _contacts;
        public Lists()
        {
            InitializeComponent();

            //var names = new List<string>
            //{
            //    "Mosh", "John", "beverly"
            //};

            //listView.ItemsSource = names;

            //listView.ItemsSource = new List<ContactGroup>
            //{
            //    new ContactGroup("M", "M")
            //    {
            //        new Contact{Name = "Mosh", ImageUrl = "https://randomuser.me/api/portraits/men/28.jpg", Status = "Hey!"}
            //    },

            //    new ContactGroup("F", "F")
            //    {
            //        new Contact{ Name = "Franzin", ImageUrl = "https://randomuser.me/api/portraits/women/81.jpg", Status = "Yow Wazzup"}
            //    }             
            //};

            _contacts = new ObservableCollection<Contact>
            {
                new Contact{Name = "Mosh", ImageUrl = "https://randomuser.me/api/portraits/men/28.jpg", Status = "Hey!"},
                new Contact{ Name = "Franzin", ImageUrl = "https://randomuser.me/api/portraits/women/81.jpg", Status = "Yow Wazzup"}
            };

            listView.ItemsSource = _contacts;

            //listView.ItemsSource = GetContacts();
        }

        //private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var contact = e.SelectedItem as Contact;
        //    DisplayAlert("Selected", contact.Name, "Ok");
        //}

        //private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    var contact = e.Item as Contact;
        //    DisplayAlert("Tapped", contact.Name, "Ok");
        //}

        //private void Call_Clicked(object sender, EventArgs e)
        //{
        //    var menuItem = sender as MenuItem;
        //    var contact = menuItem.CommandParameter as Contact;

        //    DisplayAlert("Call", contact.Name, "Ok");
        //}

        //private void Delete_Clicked(object sender, EventArgs e)
        //{
        //    var contact = (sender as MenuItem).CommandParameter as Contact;
        //    _contacts.Remove(contact);
        //}

        List<Contact> GetContacts()
        {
            return new List<Contact>
            {
                new Contact{Name = "Mosh", ImageUrl = "https://randomuser.me/api/portraits/men/28.jpg", Status = "Hey!"},
                new Contact{ Name = "Franzin", ImageUrl = "https://randomuser.me/api/portraits/women/81.jpg", Status = "Yow Wazzup"}
            };
        }
        //private void listView_Refreshing(object sender, EventArgs e)
        //{
        //    listView.ItemsSource = GetContacts();
        //    listView.EndRefresh();
        //}

        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>
            {
                new Contact{Name = "Mosh", ImageUrl = "https://randomuser.me/api/portraits/men/28.jpg", Status = "Hey!"},
                new Contact{ Name = "Franzin", ImageUrl = "https://randomuser.me/api/portraits/women/81.jpg", Status = "Yow Wazzup"}
            };

            if (string.IsNullOrWhiteSpace(searchText))
            {
                return contacts;
            }

            return contacts.Where(u => u.Name.StartsWith(searchText)).ToList();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            Detail = new NavigationPage( new ListDetail(contact));
            IsPresented = false; //IsMasterPresented
        }
    }
}