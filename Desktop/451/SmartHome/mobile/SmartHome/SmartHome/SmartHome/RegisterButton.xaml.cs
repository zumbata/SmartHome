using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHome
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterButton : ContentPage
	{
        public static string home_device_name;
        public static string device_name;
        Label Title = new Label()
        {
            Text = "Регистрация на бутон в секция " + home_device_name,
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            TextColor = Color.Black,
            HeightRequest = 150,
            FontSize = 36
        };
        Entry button_name = new Entry
        {
            Placeholder = "Име на бутона",
            HeightRequest = 50,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };
        Button register = new Button()
        {
            Text = "Регистрирай",
            HeightRequest = 50,
            VerticalOptions = LayoutOptions.CenterAndExpand,
        };
        Picker position = new Picker
        {
            Title = "Позиция на ИЧ индикатор"
        };
        public RegisterButton ()
		{
			InitializeComponent ();
            ScrollView scroll = new ScrollView();
            Grid grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            position.Items.Add("Ляво");
            position.Items.Add("Дясно");
            position.Items.Add("Отпред");
            register.Clicked += Register_Clicked;
            grid.Children.Add(Title, 0, 0);
            Grid.SetColumnSpan(Title, 3);
            grid.Children.Add(button_name, 0, 1);
            Grid.SetColumnSpan(button_name, 3);
            grid.Children.Add(position, 0, 2);
            Grid.SetColumnSpan(position, 3);
            grid.Children.Add(register, 0, 3);
            Grid.SetColumnSpan(register, 3);
            grid.RowSpacing = 25;
            Content = grid;
        }

        void Register_Clicked(object sender, EventArgs e)
        {
            string pos = position.SelectedItem.ToString();
            string pos1 = "";
            if (pos == "Ляво")
                pos1 = "l";
            else if (pos == "Дясно")
                pos1 = "r";
            else
                pos1 = "u";
            var data = new NameValueCollection
            {
                ["username"] = Login.Username,
                ["password"] = Login.Password,
                ["device_name"] = device_name,
                ["home_device_name"] = home_device_name,
                ["name"] = button_name.Text,
                ["position"] = pos1
            };
            WebClient wb = new WebClient();
            string result = Encoding.UTF8.GetString(wb.UploadValues("http://www.smarthome.dimitarkostov.eu/register_button.php", "POST", data));
            if (result == "Success")
            {
                DisplayAlert("Успех", "Успешно регистриране на бутон!", "ОК");
                Navigation.PopModalAsync();
            }
               
            else
                DisplayAlert("Неуспех", "Моля опитайте отново: " + result, "OK");
        }
    }
}