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
    public partial class Information : ContentPage
    {
        public static Device device;
        public Information()
        {
            InitializeComponent();
            ScrollView scroll = new ScrollView();
            Grid grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            string device_name = device.name;
            device = Get.getData(device_name);
            Label label = new Label()
            {
                Text = device.name,
                FontAttributes = FontAttributes.Bold,
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Black,
                HeightRequest = 100,
                FontSize = 46
            };
            Button b = new Button
            {
                Text = "Обнови",
                VerticalOptions = LayoutOptions.Center
            };
            b.Clicked += B_Clicked;
            grid.Children.Add(b, 2, 0);
            Label label1 = new Label()
            {
                Text = "Температура: " + device.sensorsData.temp_cel + "°C" + "\r\n" + "Усеща се: " + device.sensorsData.heat_index_cel + "°C",
                FontAttributes = FontAttributes.Bold,
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Black,
                HeightRequest = 60,
                FontSize = 12
            };

            Label label2 = new Label()
            {
                Text = "Температура: " + device.sensorsData.temp_far + "°F" + "\r\n" + "Усеща се: " + device.sensorsData.heat_index_far + "°F",
                FontAttributes = FontAttributes.Bold,
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Black,
                HeightRequest = 60,
                FontSize = 12
            };

            Label label3 = new Label()
            {
                Text = "Влажност: " + device.sensorsData.hum + "%" + "\r\n" + "Количество вредни газове: " + device.sensorsData.gas_ppm + "PPM",
                FontAttributes = FontAttributes.Bold,
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Black,
                HeightRequest = 60,
                FontSize = 12
            };
            grid.Children.Add(label, 0, 1);
            Grid.SetColumnSpan(label, 3);
            grid.Children.Add(label1, 0, 2);
            grid.Children.Add(label2, 1, 2);
            grid.Children.Add(label3, 2, 2);
            Button Register_home_device = new Button
            {
                Text = "Добави домашно устройство",
                HeightRequest = 50,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            List<Home_device> Home_devices = new List<Home_device>();
            List<Label> add_buttons = new List<Label>();
            foreach (var item in device.homeDevice)
            {
                Label home_d = new Label()
                {
                    Text = item.name,
                    VerticalOptions = LayoutOptions.End,
                    HorizontalOptions = LayoutOptions.Center,
                    FontSize = 28,
                    HeightRequest = 40,
                    TextColor = Color.Black
                };
                Home_device hd = new Home_device
                {
                    HomeDevice = home_d
                };
                List<Label> butt = new List<Label>();
                foreach (var item1 in item.button)
                {
                    Label button = new Label()
                    {
                        Text = item1,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center,
                        TextColor = Color.Red,
                        HeightRequest = 60,
                        FontSize = 20
                    };
                    butt.Add(button);                    
                }
                Label button1 = new Label()
                {
                    Text = "Регистрирай бутон",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    HeightRequest = 30,
                    TextColor = Color.Black,
                };
                add_buttons.Add(button1);
                hd.Device_buttons = butt;
                Home_devices.Add(hd);
            }
            int p = 0;
            int k = 3;
            int i = 0;
            foreach (var item in Home_devices)
            {
                grid.Children.Add(item.HomeDevice, p, k);
                Grid.SetColumnSpan(item.HomeDevice,3);
                p = 2;
                foreach (Label item1 in item.Device_buttons)
                {
                    if (p == 2)
                    {
                        p = 0;
                        k++;
                    }
                    else
                    {
                        p++;
                    }
                    grid.Children.Add(item1, p, k);
                    item1.GestureRecognizers.Add(new TapGestureRecognizer
                    {
                        Command = new Command(() => LabelClicked(item1.Text, item.HomeDevice.Text))
                    });
                }
                k++;
                grid.Children.Add(add_buttons[i],0,k);
                Grid.SetColumnSpan(add_buttons[i], 3);
                add_buttons[i].GestureRecognizers.Add(new TapGestureRecognizer
                {
                    Command = new Command(() => Label1Clicked(item.HomeDevice.Text, device.name))
                });
                p = 0;
                k++;
                i++;
            }
            grid.Children.Add(Register_home_device, 0, k+1);
            Grid.SetColumnSpan(Register_home_device, 3);
            Register_home_device.Clicked += Register_home_device_Clicked;
            scroll.Content = grid;
            Content = scroll;
            void Register_home_device_Clicked(object sender, EventArgs e)
            {
                Entry name = new Entry
                {
                    Placeholder = "Име на устройството",
                    HeightRequest = 50,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                Button register = new Button()
                {
                    Text = "Регистрирай",
                    HeightRequest = 50,
                    FontSize = 12,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                };
                grid.Children.Add(name, 0, k);
                Grid.SetColumnSpan(name, 2);
                grid.Children.Add(register, 2, k);
                register.Clicked += Register_Clicked;
                void Register_Clicked(object sender1, EventArgs e1)
                {
                    var data = new NameValueCollection
                    {
                        ["username"] = Login.Username,
                        ["password"] = Login.Password,
                        ["device_name"] = device.name,
                        ["name"] = name.Text
                    };
                    WebClient wb = new WebClient();
                    string result = Encoding.UTF8.GetString(wb.UploadValues("http://www.smarthome.dimitarkostov.eu/register_home_device.php", "POST", data));
                    if (result != "Success")
                    {
                        DisplayAlert("Неуспех", "Моля опитайте отново: " + result, "OK");
                        return;
                    }
                    DisplayAlert("Успех", "Успешно добавяне на устройство към списъка!", "ОК");
                    grid.Children.Remove(register);
                    grid.Children.Remove(name);
                }
            }
        }

        void B_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
            Navigation.PushModalAsync(new Information());
        }

        private void LabelClicked(string clicked_button, string dev_name)
        {
            var data = new NameValueCollection
            {
                ["username"] = Login.Username,
                ["password"] = Login.Password,
                ["device_name"] = device.name,
                ["home_device_name"] = dev_name,
                ["button_name"] = clicked_button
            };
            WebClient wb = new WebClient();
            string result = Encoding.UTF8.GetString(wb.UploadValues("http://www.smarthome.dimitarkostov.eu/click_button.php", "POST", data));
            if (result == "Success")
                DisplayAlert("Успех", "Успешно натискане на бутон!", "ОК");
            else
                DisplayAlert("Неуспех", "Моля опитайте отново: "+result, "OK");
        }
        private void Label1Clicked(string dev_name, string device_name)
        {
            RegisterButton.home_device_name = dev_name;
            RegisterButton.device_name = device_name;
            Navigation.PushModalAsync(new RegisterButton());
        }
    }
}