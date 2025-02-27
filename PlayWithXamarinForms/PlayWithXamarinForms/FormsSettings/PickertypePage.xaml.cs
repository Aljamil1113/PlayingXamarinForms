﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlayWithXamarinForms.FormsSettings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickertypePage : ContentPage
    {
        private IList<ContactMethod> _contactMethods;
        public PickertypePage()
        {
            InitializeComponent();

            _contactMethods = GetContactMethods();

            foreach (var method in _contactMethods)
            {
                contactMethods.Items.Add(method.Name);

            }
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = contactMethods.Items[contactMethods.SelectedIndex];
            var contactMethod = GetContactMethods().Single(cm => cm.Name == name);

            DisplayAlert("Selection", name, "Ok");
        }

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            { 
                new ContactMethod{ Id = 1, Name = "SMS"},
                new ContactMethod{ Id = 2, Name = "Email"}
            };
        }
    }

    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}