using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlayWithXamarinForms.Extension
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DateCell : ViewCell
    {
        public static readonly BindableProperty LabelProperty =
            BindableProperty.Create("Label", typeof(string), typeof(DateCell));

        public string Lable
        {
            get { return (string)GetValue(LabelProperty);  }
            set { SetValue(LabelProperty, value); }
        }
        public string Label { get; set; }
        public DateCell()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}