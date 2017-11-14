using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinSearchBar
{
    public partial class MainPage : ContentPage
    {
        public List<Contacts> tempdata;

        public MainPage()
        {
            InitializeComponent();
            Data();
            List.ItemsSource = tempdata;
        }

        void Data()
        {
            tempdata = new List<Contacts>
            {
                new Contacts(){ Name = "John", Number = "2323423"},
                new Contacts(){ Name = "Jane", Number = "23423"},
                new Contacts(){ Name = "Allen", Number = "233423423"},
                new Contacts(){ Name = "Sonia", Number = "2423"},
                new Contacts(){ Name = "Julie", Number = "323423"},
                new Contacts(){ Name = "Shawn", Number = "2323423"},
                new Contacts(){ Name = "Amar", Number = "2323423"},
                new Contacts(){ Name = "Nelly", Number = "2323423"},
                new Contacts(){ Name = "Ursula", Number = "2323423"},
                new Contacts(){ Name = "Evan", Number = "2323423"}
            };
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
                List.ItemsSource = tempdata;

            else
                List.ItemsSource = tempdata.Where(x => x.Name.StartsWith(e.NewTextValue));
        }
    }
}
