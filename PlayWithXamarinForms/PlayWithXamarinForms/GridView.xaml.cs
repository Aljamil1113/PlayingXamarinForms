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
    public partial class GridView : ContentPage
    {
        public GridView()
        {
            InitializeComponent();

            //var grid = new Grid
            //{
            //    RowSpacing = 20,
            //    ColumnSpacing = 40
            //};
            //var Label = new Label { Text = "Label 1" };
            //grid.Children.Add(Label, 0, 0);
            //Grid.SetRowSpan(Label, 2);
            //Grid.SetColumnSpan(Label, 2);
            //Grid.SetRow(Label, 0);
            //Grid.SetColumn(Label, 0);

            //grid.RowDefinitions.Add(new RowDefinition
            //{
            //    Height = new GridLength(100, GridUnitType.Absolute)
            //});

            //grid.RowDefinitions.Add(new RowDefinition
            //{
            //    Height = new GridLength(2, GridUnitType.Star)
            //});

            //grid.RowDefinitions.Add(new RowDefinition
            //{
            //    Height = new GridLength(1, GridUnitType.Auto)
            //});

            //grid.ColumnDefinitions.Add(new ColumnDefinition
            //{
            //    Width = new GridLength(100, GridUnitType.Absolute)
            //});

            //grid.ColumnDefinitions.Add(new ColumnDefinition
            //{
            //    Width = new GridLength(2, GridUnitType.Star)
            //});

            //grid.ColumnDefinitions.Add(new ColumnDefinition
            //{
            //    Width = new GridLength(1, GridUnitType.Auto)
            //});
        }
    }
}