using PlayWithXamarinForms.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayWithXamarinForms.MarkupExtensions
{
    public class ContactGroup : List<Contact>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }

        public ContactGroup(string title, string shortTitle)
        {
            Title = title;
            ShortTitle = shortTitle;
        }
    }
}
