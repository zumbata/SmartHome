using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using Xamarin.Forms;
using System.Collections.Specialized;

namespace SmartHome
{
    public partial class Login : ContentPage
    {
        public static string Username;
        public static string Password;
        Entry Username_entry = new Entry
        {
            Placeholder = "Потрбителско име",
            VerticalOptions = LayoutOptions.CenterAndExpand
        };
        Entry Password_entry = new Entry
        {
            Placeholder = "Парола",
            VerticalOptions = LayoutOptions.StartAndExpand,
            IsPassword = true
        };
        public Login()
        {
            InitializeComponent();
            var Login_layout = new Grid();
            Login_layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            Login_layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            Login_layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            Login_layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            Login_layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            Login_layout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            Login_layout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            var Main_Label = new Label
            {
                Text = "SmartHome",
                FontAttributes = FontAttributes.Bold,
                FontSize = 45,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.Black
            };
            var Login_button = new Button
            {
                Text = "Вход",
                VerticalOptions = LayoutOptions.StartAndExpand

            };
            Login_button.Clicked += OnButtonClicked;


            Login_layout.Children.Add(Main_Label, 0, 0);
            Login_layout.Children.Add(Username_entry, 0, 1);
            Login_layout.Children.Add(Password_entry, 0, 2);
            Login_layout.Children.Add(Login_button, 0, 3);
            Grid.SetColumnSpan(Username_entry, 2);
            Grid.SetColumnSpan(Password_entry, 2);
            Grid.SetColumnSpan(Main_Label, 2);
            Grid.SetColumnSpan(Login_button, 2);
            Content = Login_layout;

        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            Username = Username_entry.Text;
            Password = Password_entry.Text;
            WebClient wb = new WebClient();
            var data = new NameValueCollection
            {
                ["username"] = Username,
                ["password"] = Password
            };
            string response = Encoding.UTF8.GetString(wb.UploadValues("http://www.smarthome.dimitarkostov.eu/login.php", "POST", data));
            string Alert = "";
            if (response == "Invalid username")
            {
                Alert = "Грешно потрбителско име";
            }
            else if (response == "E-mail not confirmed")
            {
                Alert = "Е-мейлът не е потвърден";
            }
            else if (response == "Invalid password")
            {
                Alert = "Грешна парола";
            }
            if (response == "Invalid username" || response == "E-mail not confirmed" || response == "Invalid password")
                DisplayAlert("Error!", Alert, "Try again");
            else
            {
                Navigation.PopModalAsync();
                Navigation.PushModalAsync(new Main_Page());
            }
        }
    }
}
